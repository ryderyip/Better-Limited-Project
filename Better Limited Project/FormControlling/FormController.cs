using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Better_Limited_Project.FormControlling
{
    public class FormController
    {
        private readonly Form _parentForm;
        public Form ChildForm { get; private set; }
        private const double NavigatorWidthPercentage = 0.25;

        public FormController(Form parentForm)
        {
            _parentForm = parentForm;
            _parentForm.IsMdiContainer = true;
        }

        private int GetNavigationFormWidth()
        {
            return (int) Math.Ceiling(_parentForm.Size.Width * NavigatorWidthPercentage);
        }
        
        public void OpenForm(Form subform)
        {
            ChildForm = subform;
            SetSubformSize(ChildForm);
            SetSubformProperties(ChildForm, DockStyle.Right);
            // TODO Set theme
            
            ChildForm.Show();
        }

        public void OpenNavigationForm(Form navigationForm)
        {
            ChildForm = navigationForm;
            SetNavigationFormSize(ChildForm);
            SetSubformProperties(ChildForm, DockStyle.Left);
            ChildForm.Show();
        }

        private void SetSubformProperties(Form subform, DockStyle dockStyle)
        {
            subform.MdiParent = _parentForm;
            subform.Dock = dockStyle;
            subform.FormBorderStyle = FormBorderStyle.None;
        }

        private void SetSubformSize(Form subform)
        {
            int parentFormHeight = _parentForm.Size.Height;
            int parentFormWidth = _parentForm.Size.Width;
            int childFormWidth = parentFormWidth - GetNavigationFormWidth();
            subform.Size = new Size(childFormWidth, parentFormHeight);
        }

        private void SetNavigationFormSize(Form navigationForm)
        {
            int parentFormHeight = _parentForm.Size.Height;
            
            navigationForm.Size = new Size(GetNavigationFormWidth() + 10, parentFormHeight);
        }
        
        private List<Control> GetAll(Control control)
        {
            var controls = control.Controls.Cast<Control>().ToList();
            return controls.SelectMany(GetAll).Concat(controls).ToList();
        }
    }
}