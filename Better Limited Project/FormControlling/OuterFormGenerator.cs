using System.Drawing;
using System.Windows.Forms;

namespace Better_Limited_Project.FormControlling
{
    public static class OuterFormGenerator
    {
        private const int Width = 1280;
        private const int Height = 720;

        public static Form Generate()
        {
            var form = new Form();
            form.Size = new Size(Width, Height);
            return form;
        }

        public static Form Generate(Size size)
        {
            var form = new Form();
            form.Size = size;
            return form;
        }
    }
}