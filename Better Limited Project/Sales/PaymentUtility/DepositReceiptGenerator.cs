using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using Better_Limited_Project.ProductUtility.Entity;
using Better_Limited_Project.Sales.OrderPlacing.Entity;
using Better_Limited_Project.Sales.PaymentUtility.Repository;
using Better_Limited_Project.SettingsUtility;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;

namespace Better_Limited_Project.Sales.PaymentUtility
{
    public class DepositReceiptGenerator
    {
        private readonly SalesOrder _salesOrder;
        private const string FileName = "deposit receipt.pdf";
        private readonly string _location;

        public DepositReceiptGenerator(SalesOrder salesOrder)
        {
            _salesOrder = salesOrder;
            if (salesOrder.Customer == null)
                throw new ArgumentException("Deposit receipt need customer's information.");
            _location = UserSettings.GetSettings().DefaultDocumentGenerationDirectoryPath;
        }

        public void GenerateAndOpen()
        {
            var doc = Generate();
            var path = Path.Combine(_location, FileName);

            const bool unicode = false;
            PdfDocumentRenderer pdfRenderer = new(unicode);
            pdfRenderer.Document = doc;
            pdfRenderer.RenderDocument(); // Layout and render document to PDF
            pdfRenderer.PdfDocument.Save(path);

            Process.Start(path);
        }

        private Document Generate()
        {
            var doc = new Document();
            doc.Info.Title = "Deposit Receipt";

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
            headerText.Height = "10cm";
            var paragraph = headerText.AddParagraph();
            paragraph.Format.Font = new Font("Arial", 24);
            paragraph.AddFormattedText("Deposit Receipt", TextFormat.Bold);

            // Add the print date field
            paragraph = section.AddParagraph();
            paragraph.Format.Font = new Font("Helvetica", 9);
            paragraph.AddText($"Date: {DateTime.Today.ToShortDateString()}");
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 10;
            paragraph.Format.SpaceAfter = 3;

            // Deposit statement

            var statement = section.AddParagraph();
            var method = PaymentRepository
                .FindById(_salesOrder.SalesOrderProducts.First().Payments.First().PaymentId).PaymentMethod;
            string methodText = method is PaymentMethod.CreditCard ? "Credit Card" : method.ToString();
            decimal remainingFund = _salesOrder.GetTotalAmount() - _salesOrder.GetAmountPaid();
            string statementText = $"The receipt is for a product deposit for out of stock items in the amount of " +
                                   $"{_salesOrder.GetDepositAmount().ToString("C", new CultureInfo("zh-HK"))} " +
                                   $"in the form of {methodText}.\n\n" +
                                   $"The products will be reserved for 30 days once the stocks are replenished. " +
                                   $"Buyer must pay the remaining {remainingFund.ToString("C", new CultureInfo("zh-HK"))} " +
                                   $"within the period or else the non-refundable deposit will be forfeited.";
            statement.Format.SpaceBefore = "1cm";
            statement.AddText(statementText);

            // Add the print date field
            paragraph = section.AddParagraph();
            paragraph.Format.SpaceBefore = "1cm";
            paragraph.Format.Font = new Font("Arial", 16);
            paragraph.AddText("Deposit Item Information");

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

            column = table.AddColumn("6.5cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("2cm");
            column.Format.Alignment = ParagraphAlignment.Right;

            column = table.AddColumn("3cm");
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
            row.Cells[2].AddParagraph("Selling Price");
            row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[3].AddParagraph("Deposit Amount");
            row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[4].AddParagraph("Quantity");
            row.Cells[4].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].AddParagraph("Subtotal Deposit Amount");
            row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            row.Cells[5].VerticalAlignment = VerticalAlignment.Bottom;

            table.SetEdge(0, 0, 4, 1, Edge.Box, BorderStyle.Single, 0.75, Color.Empty);

            int rowCount = 0;
            foreach (var salesOrderProduct in _salesOrder.SalesOrderProducts.Where(sop => sop.Payments.Any(sopp => sopp.IsDeposit)))
            {
                row = table.AddRow();
                row.Format.Alignment = ParagraphAlignment.Center;
                row.Cells[0].AddParagraph((++rowCount).ToString());
                row.Cells[0].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[1].AddParagraph(salesOrderProduct.Product.Name);
                row.Cells[1].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[2].AddParagraph(salesOrderProduct.Price.ToString("C", new CultureInfo("zh-HK")));
                row.Cells[2].Format.Alignment = ParagraphAlignment.Left;
                decimal depositAmount = salesOrderProduct.Price * Product.DepositPricePercentage;
                row.Cells[3].AddParagraph(depositAmount.ToString("C", new CultureInfo("zh-HK")));
                row.Cells[3].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[4].AddParagraph(salesOrderProduct.Quantity.ToString());
                row.Cells[4].Format.Alignment = ParagraphAlignment.Left;
                row.Cells[5]
                    .AddParagraph((depositAmount * salesOrderProduct.Quantity).ToString("C", new CultureInfo("zh-HK")));
                row.Cells[5].Format.Alignment = ParagraphAlignment.Left;
            }

            row = table.AddRow();
            row.Cells[0].MergeRight = table.Columns.Count - 1;
            decimal totalDeposit =
                _salesOrder.SalesOrderProducts.Sum(sop => sop.Price * sop.Quantity * Product.DepositPricePercentage);
            row.Cells[0].AddParagraph($"Total: {totalDeposit.ToString("C", new CultureInfo("zh-HK"))}");
            row.Format.Alignment = ParagraphAlignment.Right;
            
            
            // Create Sender frame
            var addressFrame = section.AddTextFrame();
            addressFrame.Height = "3.0cm";
            addressFrame.Width = "7.0cm";
            addressFrame.Left = ShapePosition.Left;
            addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            addressFrame.Top = "10cm";
            addressFrame.RelativeVertical = RelativeVertical.Page;

            paragraph = addressFrame.AddParagraph();
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 9;
            paragraph.Format.SpaceAfter = 3;

            // Create Receiver Frame
            addressFrame = section.AddTextFrame();
            addressFrame.Height = "3.0cm";
            addressFrame.Width = "7.0cm";
            addressFrame.Top = "10cm";
            addressFrame.Left = ShapePosition.Left;
            addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            addressFrame.RelativeVertical = RelativeVertical.Page;

            string signatureUnderscore = "____________________";

            paragraph = addressFrame.AddParagraph();
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 9;
            paragraph.Format.SpaceBefore = 10;
            paragraph.AddFormattedText("Seller:", TextFormat.Bold);
            paragraph = addressFrame.AddParagraph($"Name: {_salesOrder.RetailStore.Name}\n" +
                                                  $"Address: {_salesOrder.RetailStore.Address}\n" +
                                                  $"Signature: {signatureUnderscore}");
            paragraph.Format.Font = new Font("Times New Roman", 9);
            paragraph.Format.SpaceAfter = 3;

            addressFrame = section.AddTextFrame();
            addressFrame.Height = "3.0cm";
            addressFrame.Width = "7.0cm";
            addressFrame.Top = "10cm";
            addressFrame.Left = ShapePosition.Right;
            addressFrame.RelativeHorizontal = RelativeHorizontal.Margin;
            addressFrame.RelativeVertical = RelativeVertical.Page;

            paragraph = addressFrame.AddParagraph();
            paragraph.Format.Font.Name = "Times New Roman";
            paragraph.Format.Font.Size = 9;
            paragraph.Format.SpaceBefore = 10;
            paragraph.AddFormattedText("Buyer:", TextFormat.Bold);
            paragraph = addressFrame.AddParagraph($"Name: {_salesOrder.Customer!.Name}\n" +
                                                  $"Address 1: {_salesOrder.Customer.Address.Address1}\n" +
                                                  $"Address 2: {_salesOrder.Customer.Address.Address2}\n" +
                                                  $"Signature {signatureUnderscore}");
            paragraph.Format.Font = new Font("Times New Roman", 9);
            paragraph.Format.SpaceAfter = 3;
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