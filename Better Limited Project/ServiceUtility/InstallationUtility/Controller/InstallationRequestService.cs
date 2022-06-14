using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Controller
{
    public class InstallationRequestService
    {
        private readonly List<InstallationRequestProduct> _productsToInstall = new();
        private readonly InstallationRequest _request;

        public InstallationRequestService(string salesOrderId)
        {
            _request = new InstallationRequest(salesOrderId);
        }

        public void SendRequest()
        {
            _request.Save();
            _productsToInstall.ForEach(irp => irp.Save());
        }

        public void AddProductRange(IEnumerable<SalesOrderProduct> productToInstall)
        {
            _productsToInstall.AddRange(productToInstall.Select(sop =>
                new InstallationRequestProduct(_request.Id, sop.ProductId, sop.Quantity)));
        }
    }
}