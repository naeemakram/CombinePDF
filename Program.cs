// See https://aka.ms/new-console-template for more information

////using Spire.Pdf;

//using PdfSharp.Pdf;
//using PdfSharp.Pdf.IO;




using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

string[] filesToMerge = Directory.GetFiles(@"C:\Users\Naeem Malik\source\repos\CombinePDF\bin\Debug\net6.0\pdffiles");

if (File.Exists("testFile.pdf")){
    File.Delete("testFile.pdf");
}

var writer = new PdfWriter("testFile.pdf");
var pdf = new PdfDocument(writer);
var document = new Document(pdf);
// Create a PdfFont
var font = PdfFontFactory.CreateFont();
// Add a Paragraph
document.Add(new Paragraph("iText is:").SetFont(font));
// Create a List
List list = new List()
    .SetSymbolIndent(12)
    .SetListSymbol("u2022")
    .SetFont(font);
// Add ListItem objects
list.Add(new ListItem("Never gonna give you up"))
    .Add(new ListItem("Never gonna let you down"))
    .Add(new ListItem("Never gonna run around and desert you"))
    .Add(new ListItem("Never gonna make you cry"))
    .Add(new ListItem("Never gonna say goodbye"))
    .Add(new ListItem("Never gonna tell a lie and hurt you"));
// Add the list
document.Add(list);
document.Close();