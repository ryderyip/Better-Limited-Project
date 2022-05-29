namespace Better_Limited_Project.ProductUtility.Restocking
{
    public static class RestockRequestService
    {
        public static void SendRequest(RestockRequest request)
        {
            RestockRequestRepository.Insert(request);
            foreach (var requestedProduct in request.RequestedProducts)
                RestockRequestProductRepository.Insert(requestedProduct);
        }
    }
}