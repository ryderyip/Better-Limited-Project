using System;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.UI
{
    public interface IArrangeDeliveryForm
    {
        event EventHandler? SwitchFormClicked;
        event EventHandler? DeliveryArranged;
        void ShowForm();
        void CloseForm();
    }
}