using System;
using System.Collections.Generic;
using Better_Limited_Project.Login;
using Better_Limited_Project.ProductUtility.Restocking.Entity;
using Better_Limited_Project.ProductUtility.Restocking.Repository;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;

namespace Better_Limited_Project.ProductUtility.Restocking
{
    public class RestockArrangingService
    {
        private readonly RestockDelivery _restockDelivery   ;
        private readonly List<RestockRequest> _selectedRestockRequests = new();
        private readonly List<Courier> _selectedCouriers  = new();

        public RestockArrangingService(DateTime deliveryDateTime)
        {
            _restockDelivery = new RestockDelivery(deliveryDateTime);
        }

        public void AddRestockRequest(RestockRequest restockRequest)
        {
            _selectedRestockRequests.Add(restockRequest);
        }

        public void AddCourier(Courier courier)
        {
            _selectedCouriers.Add(courier);
        }

        public void Arrange()
        {
            if (_selectedRestockRequests.Count == 0 || _selectedCouriers.Count == 0)
                throw new InvalidOperationException("At least 1 restock request and courier must be selected");

            _restockDelivery.Save();
            
            foreach (var request in _selectedRestockRequests)
            {
                request.ArrangedOn = DateTime.Now;
                request.ArrangedByStaffId = LoginSession.GetSession().CurrentStaff.Id;
                request.Save();
                RestockDeliveryRestockRequestRepository.Insert(_restockDelivery, request);
            }

            foreach (var courier in _selectedCouriers)
                RestockDeliveryCourierRepository.Insert(_restockDelivery, courier);
        }
    }
}