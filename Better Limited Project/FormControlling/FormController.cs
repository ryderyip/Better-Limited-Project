using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Better_Limited_Project.FormControlling
{
    public class FormController
    {
        private readonly Form _outerForm;
        public Form ContentForm { get; private set; }
        private Form _navigationBar;

        public FormController(Form outerForm)
        {
            _outerForm = outerForm;
            _outerForm.IsMdiContainer = true;
        }

        public void OpenFullForm(Form form)
        {
            ContentForm = form;
            FormPropertyController.SetInnerFormProperty(_outerForm, ContentForm, DockStyle.Fill);
            ContentForm.Show();
        }
        
        public void OpenContentForm(Form contentForm)
        {
            ContentForm?.Close();

            ContentForm = contentForm;
            ContentForm.Size = FormPropertyController.GetChildFormSize(_outerForm.Size);
            FormPropertyController.SetInnerFormProperty(_outerForm, ContentForm, DockStyle.Right);
            // TODO Set theme
            
            ContentForm.Show();
        }

        public void OpenNavigationForm(Form navigationForm)
        {
            _navigationBar = navigationForm;
            _navigationBar.Size = FormPropertyController.GetNavigationBarSize(_outerForm.Size);
            FormPropertyController.SetInnerFormProperty(_outerForm, _navigationBar, DockStyle.Left);
            _navigationBar.Show();
        }

        private List<Control> GetAll(Control control)
        {
            var controls = control.Controls.Cast<Control>().ToList();
            return controls.SelectMany(GetAll).Concat(controls).ToList();
        }
    }
}