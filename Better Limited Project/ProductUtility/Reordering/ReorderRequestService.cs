namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestService
    {
        public static void SendRequest(ReorderRequest request)
        {
            ReorderRequestRepository.Insert(request);
            foreach (var requestedProduct in request.RequestedProducts)
                ReorderRequestProductRepository.Insert(requestedProduct);
        }
    }
}