namespace Better_Limited_Project.ProductUtility.Restocking
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