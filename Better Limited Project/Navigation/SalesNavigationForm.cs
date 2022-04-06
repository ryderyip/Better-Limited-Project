using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Better_Limited_Project.Navigation
{
    public partial class SalesNavigationForm : Form
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler ProfileClicked;
        public event ButtonClickedEventHandler PlaceOrderClicked;
        public event ButtonClickedEventHandler SalesOrderClicked;
        public event ButtonClickedEventHandler ProductListClicked;
        public event ButtonClickedEventHandler SettingsClicked;
        
        /*private static readonly object ProfileClickedEventKey = new object();
        private static readonly object PlaceOrderClickedEventKey = new object();
        private static readonly object SalesOrderClickedEventKey = new object();
        private static readonly object ProductListClickedEventKey = new object();
        private static readonly object SettingsClickedEventKey = new object();*/
        // public new EventHandlerList Events = new EventHandlerList();

        public SalesNavigationForm()
        {
            InitializeComponent();
        }
    }
}