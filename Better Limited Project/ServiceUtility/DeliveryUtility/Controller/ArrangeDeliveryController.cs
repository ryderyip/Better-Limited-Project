using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.FormControlling;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.UI;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.Controller
{
    public class ArrangeDeliveryController
    {
        private readonly DeliveryRequest _deliveryRequest;
        public EventHandler? DeliveryArranged;
        private IArrangeDeliveryForm _form;
        private readonly List<Courier> _selectedDeliveryCouriers = new();
        private readonly FormController _formController;

        public ArrangeDeliveryController(DeliveryRequest deliveryRequest)
        {
            _deliveryRequest = deliveryRequest;
            _form = new ArrangeSingleDeliveryForm(_deliveryRequest, _selectedDeliveryCouriers);
            _formController = new FormController(OuterFormGenerator.Generate(((ArrangeSingleDeliveryForm) _form).Size));
            _form.DeliveryArranged += (_, _) =>
            {
                DeliveryArranged?.Invoke(this, EventArgs.Empty);
                _formController.Close();
            };
            _form.SwitchFormClicked += (_, _) => SwitchForm();
        }

        private void SwitchForm()
        {
            if (_form is ArrangeSingleDeliveryForm)
            {
                /*_form = new ArrangeSplitDeliveryForm(_deliveryRequest, _selectedDeliveryCouriers);
                _formController.OpenFullForm((ArrangeSplitDeliveryForm) _form);*/
            }
            else
            {
                _form = new ArrangeSingleDeliveryForm(_deliveryRequest, _selectedDeliveryCouriers);
                _formController.OpenFullForm((ArrangeSingleDeliveryForm) _form);
            }

            _form.SwitchFormClicked += (_, _) => SwitchForm();
        }

        public void OpenForm()
        {
            if (Application.OpenForms.Cast<Form>()
                .Any(f => f is ArrangeSingleDeliveryForm or ArrangeSplitDeliveryForm))
                return;

            if (_form is ArrangeSingleDeliveryForm form)
                _formController.OpenFullForm(form);
            else
                _formController.OpenFullForm((ArrangeSplitDeliveryForm) _form);
        }
    }
}