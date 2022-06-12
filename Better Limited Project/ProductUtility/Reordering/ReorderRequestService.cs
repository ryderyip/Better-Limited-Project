namespace Better_Limited_Project.ProductUtility.Reordering
{
    public static class ReorderRequestService
    {
        public static void SendRequest(ReorderRequest request)
        {
            ReorderRequestRepository.InsertOrUpdate(request);
            foreach (var requestedProduct in request.RequestedProducts)
                ReorderRequestProductRepository.InsertOrUpdate(requestedProduct);
        }
    }
}