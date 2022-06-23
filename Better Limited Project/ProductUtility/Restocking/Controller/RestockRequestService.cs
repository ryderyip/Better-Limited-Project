using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;

namespace Better_Limited_Project.ProductUtility.Restocking.Controller
{
    public static class RestockRequestService
    {
        public static void SendRequest(RestockRequest request)
        {
            RestockRequestRepository.InsertOrUpdate(request);
            foreach (var requestedProduct in request.RequestedProducts)
                RestockRequestProductRepository.Insert(requestedProduct);
        }
    }
}