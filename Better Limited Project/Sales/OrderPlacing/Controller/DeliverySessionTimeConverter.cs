using System;
using Better_Limited_Project.Sales.OrderPlacing.Entity;

namespace Better_Limited_Project.Sales.OrderPlacing.Controller
{
    public static class DeliverySessionTimeConverter
    {
        public static TimeSpan GetTimeSpan(DeliverySession session)
        {
            return session switch
            {
                DeliverySession.Morning => TimeSpan.FromHours(9),
                DeliverySession.Afternoon => TimeSpan.FromHours(13),
                _ => TimeSpan.FromHours(18)
            };
        }
    }
}