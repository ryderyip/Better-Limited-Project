using System.Windows.Forms;

namespace Better_Limited_Project.Sales.OrderPlacing.Controller.SalesOrderPager
{
    public class PlaceOrderItemControlCollection
    {
        public PlaceOrderItemControlCollection(Label name, Label price, Label quantity, PictureBox picture,
            Button addButton, Panel panel)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Picture = picture;
            AddButton = addButton;
            Panel = panel;
        }

        public Label Name { get; set; }
        public Label Price { get; set; }
        public Label Quantity { get; set; }
        public PictureBox Picture { get; set; }
        public Button AddButton { get; set; }
        public Panel Panel { get; set; }
    }
}