using System;
using System.Drawing;
using System.Windows.Forms;

namespace Better_Limited_Project.FormControlling
{
    public static class FormPropertyController
    {
        private const double NavigationBarWidthFactor = 0.25;
        private const int NavigationBarWidthOffset = 12;

        public static void SetInnerFormProperty(Form parentForm, Form subform, DockStyle dockStyle)
        {
            subform.MdiParent = parentForm;
            subform.Dock = dockStyle;
            subform.FormBorderStyle = FormBorderStyle.None;
        }

        public static Size GetNavigationBarSize(Size parentFormSize)
        {
            var height = parentFormSize.Height;
            var width = GetNavigationBarWidth(parentFormSize.Width) + NavigationBarWidthOffset;
            return new Size(width, height);
        }

        public static Size GetChildFormSize(Size parentFormSize)
        {
            var height = parentFormSize.Height;
            var width = parentFormSize.Width - GetNavigationBarWidth(parentFormSize.Width);
            return new Size(width, height);
        }

        private static int GetNavigationBarWidth(int parentFormWidth)
        {
            return (int) Math.Ceiling(parentFormWidth * NavigationBarWidthFactor);
        }
    }
}