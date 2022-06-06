using System.Windows.Forms;

namespace Better_Limited_Project.Tools
{
    public partial class PopUpForm : Form
    {
        private readonly string _header;
        private readonly string _text;
        private readonly Timer _timer;
        private const double Duration = 2;

        public PopUpForm(string header, string text)
        {
            _timer = new Timer();
            _header = header;
            _text = text;
            InitializeComponent();
            // FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Load += (_, _) => SetThings();
        }

        private void SetThings()
        {
            Text = _header;
            tbMainText.Text = _text;
            _timer.Enabled = true;
            _timer.Interval = (int) (Duration * 1000);
            _timer.Start();
            _timer.Tick += (_, _) => Close();
        }
        private void PopUpForm_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void PopUpForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Escape)
                Close();
        }

        private void tbMainText_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
