using System.Linq;
using System.Windows.Forms;

namespace Better_Limited_Project.FormControlling
{
    public class FormController
    {
        private readonly Form _outerForm;
        public Form? ContentForm { get; private set; }
        private Form? _navigationBar;

        public FormController(Form outerForm)
        {
            _outerForm = outerForm;
            _outerForm.IsMdiContainer = true;
        }

        public void OpenFullForm(Form form)
        {
            OpenOuterForm();
            ContentForm?.Close();
            ContentForm = form;
            FormPropertyController.SetInnerFormProperty(_outerForm, ContentForm, DockStyle.Fill);
            ContentForm.Show();
        }
        
        public void OpenContentForm(Form contentForm)
        {
            OpenOuterForm();
            ContentForm?.Close();

            ContentForm = contentForm;
            ContentForm.Size = FormPropertyController.GetChildFormSize(_outerForm.Size);
            FormPropertyController.SetInnerFormProperty(_outerForm, ContentForm, DockStyle.Right);
            // TODO Set theme
            
            ContentForm.Show();
        }

        public void OpenNavigationForm(Form navigationForm)
        {
            OpenOuterForm();
            _navigationBar = navigationForm;
            _navigationBar.Size = FormPropertyController.GetNavigationBarSize(_outerForm.Size);
            FormPropertyController.SetInnerFormProperty(_outerForm, _navigationBar, DockStyle.Left);
            _navigationBar.Show();
        }

        private void OpenOuterForm()
        {
            if (!IsFormOpened(_outerForm.Name))
            {
                _outerForm.StartPosition = FormStartPosition.CenterScreen;
                _outerForm.Show();
            }
        }

        public static bool IsFormOpened(string formName)
        {
            return Application.OpenForms.Cast<Form>().Any(frm => frm.Text == formName);
        }

        public void Close()
        {
            ContentForm?.Close();
            _outerForm.Close();
        }
    }
}