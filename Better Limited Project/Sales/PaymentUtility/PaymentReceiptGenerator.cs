using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Properties;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.SettingsUtility;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using BorderStyle = MigraDoc.DocumentObjectModel.BorderStyle;
using TabAlignment = MigraDoc.DocumentObjectModel.TabAlignment;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public class PaymentReceiptGenerator
    {
        private const string FileName = "payment receipt.pdf";
        private readonly string _location;
        private readonly SalesOrder _salesOrder;
        private readonly List<SalesOrderProduct> _salesOrderProducts;

        public PaymentReceiptGenerator(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            _salesOrderProducts = salesOrder.GetSalesOrderProducts()
                .Where(sop => sop.GetPaymentStatus() is SalesOrderProductPaymentStatus.FullyPaid).ToList();
            _location = UserSettings.GetSettings().DocumentGenerationDirectoryPath;
        }

        public void GenerateAndOpen()
        {
            var doc = Generate();
            var path = Path.Combine(_location, FileName);

            const bool unicode = false;
            PdfDocumentRenderer pdfRenderer = new(unicode);
            pdfRenderer.Document = doc;
            pdfRenderer.RenderDocument(); // Layout and render document to PDF

            try
            {
                pdfRenderer.PdfDocument.Save(path);
            }
            catch (IOException)
            {
                MessageBox.Show(PaymentStringResources.FileBeingUsedByAnotherProcess);
            }

            Process.Start(path);
        }

        public void GenerateAndPrint()
        {
            Generate();
            var path = Path.Combine(_location, FileName);

            var process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                Verb = "print",
                FileName = path
            };
            process.Start();
        }

        private Document Generate()
        {
            var doc = new Document();
            doc.Info.Title = "Payment Receipt";

            SetStyle(doc);
            CreatePage(doc);

            return doc;
        }

        private void CreatePage(Document doc)
        {
            Section section = doc.AddSection();

            // Put a logo in the header
            var path = Path.GetTempPath() + nameof(Resources.BL_Logo_Square);
            Resources.BL_Logo_Square.Save(path);
            var image = section.Headers.Primary.AddImage(path);
            image.Height = "2cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
            image.WrapFormat.Style = WrapStyle.Through;

            // Put Header Text
            TextFrame headerText = section.Headers.Primary.AddTextFrame();
            headerText.Top = ShapePosition.Bottom;
            headerText.Left = ShapePosition.Left;
            headerText.Width = "10cm";
            headerText.Height = image.Height;
            var paymentReceiptParagraph = headerText.AddParagraph("Payment Receipt");
            paymentReceiptParagraph.Format.Font = new Font("Arial", 24);

            // Add the print date field
            var text = section.Headers.Primary.AddTextFrame();
            text.Width = "8cm";
            var paragraph = text.AddParagraph();
            paragraph.Format.Font = new Font("Helvetica", 9);
            paragraph.AddText($"Sales Order Placed On: {_salesOrder.CreatedOn.ToShortDateString()}" +
                              $" : {_salesOrder.CreatedOn.ToShortTimeString()}");

            // Create footer
            paragraph = section.Footers.Primary.AddParagraph();
            paragraph.AddText("Better Limited · Sample Building · Sample Street 42 · Hong Kong");
            paragraph.Format.Font.Size = 9;
            paragraph.Format.Alignment = ParagraphAlignment.Center;

            // Create Sender frame
            var addressFrame = section.AddTextFrame();
            addressFrame.Height = "3.0cm";
            addressFrame.Width = "7.0cm";
            addressFrame.Left = ShapePosition.Left;
            addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            addressFrame.Top = "5.0cm";
            addressFrame.RelativeVertical = RelativeVertical.Page;

            paragraph = addressFrame.AddParagraph();
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 9;
            paragraph.Format.SpaceAfter = 3;
            paragraph.AddFormattedText("From:", TextFormat.Bold);

            paragraph = addressFrame.AddParagraph($"Name: {_salesOrder.RetailStore.Name}\n" +
                                                  $"Address: {_salesOrder.RetailStore.Address}");
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 9;
            paragraph.Format.SpaceAfter = 3;

            if (_salesOrder.Customer != null)
            {
                // Create Receiver Frame
                addressFrame = section.AddTextFrame();
                addressFrame.Height = "3.0cm";
                addressFrame.Width = "7.0cm";
                addressFrame.Left = ShapePosition.Right;
                addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
                addressFrame.Top = "5.0cm";
                addressFrame.RelativeVertical = RelativeVertical.Page;

                paragraph = addressFrame.AddParagraph();
                paragraph.Format.Font.Name = "Times New Roman";
                paragraph.Format.Font.Size = 9;
                paragraph.Format.SpaceAfter = 3;
                paragraph.AddFormattedText("To:", TextFormat.Bold);

                paragraph = addressFrame.AddParagraph($"Name: {_salesOrder.Customer.Name}\n" +
                                                      $"Address 1: {_salesOrder.Customer.Address.Address1}\n" +
                                                      $"Address 2: {_salesOrder.Customer.Address.Address2}\n" +
                                                      $"Phone No.: {_salesOrder.Customer.Phone}\n" +
                                                      $"Email Address: {_salesOrder.Customer.Email ?? "-"}");
                paragraph.Format.Font = new Font("Times New Roman", 9);
                paragraph.Format.SpaceAfter = 3;
            }

            // Add the print date field
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "8cm";

            // Create the item table
            var table = section.AddTable();
            table.Style = "Table";
            table.Borders.Color = Colors.Gray;
            table.Borders.Width = 0.25;
            table.Borders.Left.Width = 0.5;
            table.Borders.Right.Width = 0.5;
            table.Rows.LeftIndent = 0;

            // Before you can add a row, you must define the columns
            Column column = table.AddColumn("1cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            column = table.AddColumn("8cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2.5cm");
            column.Format.Alignment = ParagraphAlignment.Center;

            // Create the header of the table
            var tableShadingColor = Colors.Aqua;

            Row row = table.AddRow();
            row.HeadingFormat = true;
            row.Format.Alignment = ParagraphAlignment.Center;
            row.Format.Font.Bold = true;
            row.Shading.Color = tableShadingColor;
            row.Cells[0].AddParagraph("Item");
            row.Cells[0].Format.Font.Bold = false;
            row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[0].VerticalAlignment = VerticalAlignment.Bottom;
            row.Cells[1].AddParagraph("Product Name");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[2].AddParagraph("Price");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[3].AddParagraph("Quantity");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[4].AddParagraph("Subtotal");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[4].VerticalAlignment = VerticalAlignment.Bottom;

            table.SetEdge(0, 0, 4, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

            int rowCount = 0;
            foreach (var salesOrderProduct in _salesOrderProducts)
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Cells[0].AddParagraph((++rowCount).ToString());
                row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph(salesOrderProduct.GetProduct().Name);
                row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[2].AddParagraph(salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")));
                row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[3].AddParagraph(salesOrderProduct.Quantity.ToString());
                row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[4]
                    .AddParagraph(
                        (salesOrderProduct.Price * salesOrderProduct.Quantity).ToString("C", new CultureInfo("zh-HK")));
                row.Cells[4].Format.Alignment = ParagraphAlignment.Left;
            }

            row = table.AddRow();
            row.Cells[0].MergeRight = table.Columns.Count - 1;
            decimal total = _salesOrderProducts.Sum(sop => sop.Price * sop.Quantity);
            row.Cells[0].AddParagraph($"Total: {total.ToString("C", new CultureInfo("zh-HK"))}");
            row.Format.Alignment = ParagraphAlignment.Right;
        }

        private void SetStyle(Document document)
        {
            Style style = document.Styles["Normal"];
            // Because all styles are derived from Normal, the next line changes the 
            // font of the whole document. Or, more exactly, it changes the font of
            // all styles and paragraphs that do not redefine the font.
            style.Font.Name = "Verdana";

            style = document.Styles[StyleNames.Header];
            style.ParagraphFormat.AddTabStop("16cm", TabAlignment.Right);

            style = document.Styles[StyleNames.Footer];
            style.ParagraphFormat.AddTabStop("8cm", TabAlignment.Center);

            // Create a new style called Table based on style Normal
            style = document.Styles.AddStyle("Table", "Normal");
            style.Font.Name = "Verdana";
            style.Font.Name = "Times New Roman";
            style.Font.Size = 9;

            // Create a new style called Reference based on style Normal
            style = document.Styles.AddStyle("Reference", "Normal");
            style.ParagraphFormat.SpaceBefore = "5mm";
            style.ParagraphFormat.SpaceAfter = "5mm";
            style.ParagraphFormat.TabStops.AddTabStop("16cm", TabAlignment.Right);
        }
    }
}