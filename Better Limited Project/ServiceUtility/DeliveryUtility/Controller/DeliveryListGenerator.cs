using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Sales.PaymentUtility;
using Better_Limited_Project.ServiceUtility.DeliveryUtility.Entity;
using Better_Limited_Project.SettingsUtility;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using BorderStyle = MigraDoc.DocumentObjectModel.BorderStyle;
using TabAlignment = MigraDoc.DocumentObjectModel.TabAlignment;

namespace Better_Limited_Project.ServiceUtility.DeliveryUtility.Controller
{
    public class DeliveryListGenerator
    {
        private readonly List<Delivery> _deliveries;
        private readonly string _fileName;
        private readonly string _location;

        public DeliveryListGenerator(IEnumerable<Delivery> deliveries)
        {
            _deliveries = deliveries.ToList();
            if (_deliveries.Count == 0)
                throw new ArgumentException("Cannot create a delivery list with 0 deliveries");

            var date = _deliveries.First().ScheduledOn.ToString("yy-MMM-dd ddd");
            _fileName = $"daily delivery list ({date}).pdf";
            _location = UserSettings.GetSettings().DocumentGenerationDirectoryPath;
        }

        public void GenerateAndOpen()
        {
            var doc = Generate();
            var path = Path.Combine(_location, _fileName);

            RenderFile(doc, path);

            Process.Start(path);
        }

        private static void RenderFile(Document? doc, string? path)
        {
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
        }

        public void GenerateAndPrint()
        {
            var doc = Generate();
            var path = Path.Combine(_location, _fileName);

            RenderFile(doc, path);

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
            doc.Info.Title = "Daily Deliveries";

            SetStyle(doc);
            CreatePage(doc);

            return doc;
        }

        private void CreatePage(Document doc)
        {
            Section section = doc.AddSection();

            // Put Header Text
            TextFrame headerText = section.Headers.Primary.AddTextFrame();
            headerText.Top = ShapePosition.Bottom;
            headerText.Left = ShapePosition.Left;
            headerText.Width = "10cm";
            var paymentReceiptParagraph = headerText.AddParagraph("Daily Delivery List");
            paymentReceiptParagraph.Format.Font = new Font("Arial", 24);

            // Add the print date field
            var dateTextFrame = section.AddTextFrame();
            dateTextFrame.Height = "2cm";
            dateTextFrame.Width = "6cm";
            var paragraph = dateTextFrame.AddParagraph();
            paragraph.Format.SpaceAfter = "1cm";
            paragraph.Format.Font = new Font("Arial", 9);
            string date = _deliveries.First().ScheduledOn.ToString("D");
            string couriers = string.Join(", ", _deliveries.First().GetCouriers().Select(c => c.Name));
            paragraph.AddText($"Date: {date}\n"
                              + $"Courier(s): {couriers}");

            // Create the delivery table
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

            column = table.AddColumn("5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("3.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("3cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("4cm");
            column.Format.Alignment = ParagraphAlignment.Right;

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
            row.Cells[1].AddParagraph("Order Number");
            row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[2].AddParagraph("Customer Name");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[3].AddParagraph("Customer Phone No.");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[4].AddParagraph("Scheduled Delivery Time");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Left;

            table.SetEdge(0, 0, 4, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

            var rowCount = 0;
            foreach (var delivery in _deliveries)
            {
                var order = delivery.GetSalesOrder();
                if (order.Customer == null)
                    throw new ArgumentException(
                        $"Order with order number \"{order.OrderNumber}\" does not have customer information.");
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Cells[0].AddParagraph((++rowCount).ToString());
                row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph(order.OrderNumber);
                row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[2].AddParagraph(order.Customer.Name);
                row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[3].AddParagraph(order.Customer.Phone);
                row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[4].AddParagraph(delivery.ScheduledOn.ToString("t"));
                row.Cells[4].Format.Alignment = ParagraphAlignment.Left;
            }

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