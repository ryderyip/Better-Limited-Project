using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Repository;
using Better_Limited_Project.ServiceUtility;

namespace Better_Limited_Project.Tools
{
    public static class AutoProductReserveHelper
    {
        public static void WaitListToReservedOnStockUpdated(object sender, IStock updatedStock)
        {
            if (updatedStock.Quantity <= 0)
                return;

            var waitList = SalesOrderProductWaitingRepository.GetAll();
            var idk = waitList.Where(sop => sop.ProductId == updatedStock.Product.Id).ToList();

            if (!idk.Any())
                return;

            var productsWaitingForStock = idk.OrderByDescending(stock => stock.CreatedOn);
            foreach (var productWaitingForStock in productsWaitingForStock)
            {
                if (updatedStock.Quantity <= 0)
                    return;
                var service = new ProductReservationService(productWaitingForStock.SalesOrder);
                int quantityToReserve;
                if (updatedStock.Quantity >= productWaitingForStock.Quantity)
                {
                    quantityToReserve = productWaitingForStock.Quantity;
                    productWaitingForStock.Delete();
                }
                else
                {
                    quantityToReserve = updatedStock.Quantity;
                    productWaitingForStock.Quantity -= quantityToReserve;
                    productWaitingForStock.Save();
                }

                service.Reserve(productWaitingForStock.ProductId, quantityToReserve);
            }
        }
    }
}