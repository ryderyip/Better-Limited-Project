using System.Windows.Forms;

namespace Better_Limited_Project.Tools
{
    public static class ToolTipGenerator
    {
        public static ToolTip Generate(int initialDelay = 1000, int remainPeriod = 5000, int reshowDelay = 500)
        {
            ToolTip toolTip = new();

            // Set up the delays for the ToolTip.
            toolTip.InitialDelay = initialDelay;
            toolTip.AutoPopDelay = remainPeriod;
            toolTip.ReshowDelay = reshowDelay;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            return toolTip;
        }
    }
}