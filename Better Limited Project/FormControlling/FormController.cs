using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Settings;
using Better_Limited_Project.SettingsUtility;

namespace Better_Limited_Project.FormControlling
{
    public class FormController
    {
        private readonly UserSettings _settings;
        private readonly MainForm _mainForm;
        private const double NavigatorWidthPercentage = 0.25;

        public FormController(UserSettings settings, MainForm mainForm)
        {
            _settings = settings;
            _mainForm = mainForm;
            _mainForm.IsMdiContainer = true;
        }

        private int GetNavigationFormWidth()
        {
            return (int) Math.Ceiling(_mainForm.Size.Width * NavigatorWidthPercentage);
        }
        
        public void OpenForm(Form subform)
        {
            SetSubformSize(subform);
            SetSubformProperties(subform, DockStyle.Right);
            // TODO Set theme
            
            subform.Show();
        }

        public void OpenNavigationForm(Form navigationForm)
        {
            SetNavigationFormSize(navigationForm);
            SetSubformProperties(navigationForm, DockStyle.Left);
            navigationForm.Show();
        }

        private void SetSubformProperties(Form subform, DockStyle dockStyle)
        {
            subform.MdiParent = _mainForm;
            subform.Dock = dockStyle;
            subform.FormBorderStyle = FormBorderStyle.None;
        }

        private void SetSubformSize(Form subform)
        {
            int parentFormHeight = _mainForm.Size.Height;
            int parentFormWidth = _mainForm.Size.Width;
            int childFormWidth = parentFormWidth - GetNavigationFormWidth();
            subform.Size = new Size(childFormWidth, parentFormHeight);
        }

        private void SetNavigationFormSize(Form navigationForm)
        {
            int parentFormHeight = _mainForm.Size.Height;
            
            navigationForm.Size = new Size(GetNavigationFormWidth() + 10, parentFormHeight);
        }
        
        private List<Control> GetAll(Control control)
        {
            var controls = control.Controls.Cast<Control>().ToList();
            return controls.SelectMany(GetAll).Concat(controls).ToList();
        }
    }
}