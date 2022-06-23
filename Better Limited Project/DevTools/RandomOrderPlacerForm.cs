using System;
using System.Windows.Forms;
using Better_Limited_Project.DatabaseUtility;
using MySql.Data.MySqlClient;

namespace Better_Limited_Project.DevTools
{
    public partial class RandomOrderPlacerForm : Form
    {
        public int InputtedNumber { get; private set; }
        public int MaxNumber { get; set; } = 100;
        public int MinNumber { get; set; } = 1;

        public RandomOrderPlacerForm()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
            btnOk.Click += btnOk_Click;
        }

        private void Initialize()
        {
            numericUpDown1.Maximum = MaxNumber;
            numericUpDown1.Minimum = MinNumber;
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            InputtedNumber = (int) numericUpDown1.Value;
            var autoDog = new RandomOrderPlacer();
            var progress = new Progress<double>();
            progress.ProgressChanged += (_, i) =>
            {
                progressBar1.Value = (int) i;
            };
            
            await autoDog.PlaceOrdersAsync(InputtedNumber, progress);
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("You sure?", "Sure?", MessageBoxButtons.YesNo);
            if (result is not DialogResult.Yes)
                return;
            var command = new MySqlCommand(@"call clear_sales_orders();");
            DataTableRepository.ExecuteNonQuery(command);
        }
    }
}