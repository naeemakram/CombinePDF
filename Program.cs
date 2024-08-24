// See https://aka.ms/new-console-template for more information

////using Spire.Pdf;

//using PdfSharp.Pdf;
//using PdfSharp.Pdf.IO;




using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

string[] filesToMerge = Directory.GetFiles(@"C:\Users\Naeem Malik\source\repos\CombinePDF\bin\Debug\net6.0\pdffiles");
////Specify the output folder
//string outputFolder = @"C:\Users\Naeem Malik\source\repos\CombinePDF\bin\Debug\net6.0\pdffiles\merged";
////Create a new document
//PdfDocumentBase? newPdf = null;

//newPdf = PdfDocument.MergeFiles(filesToMerge);
////Save the document to a different PDF file
//newPdf?.Save($"{outputFolder}\\Output-merged.pdf", FileFormat.PDF);


//using (PdfDocument outPDF = new PdfDocument()) {
//    foreach (string file in filesToMerge)
//    {
//        using(var PDFFile = File.Open(file, FileMode.Open)){

//            PdfDocument current = PdfReader.Open(PDFFile, PdfDocumentOpenMode.Import);            
//            CopyPages(current, outPDF);

//        }
//    }
//    outPDF.Save(".\\merged.pdf");
//}


//void CopyPages(PdfDocument from, PdfDocument to)
//{
//    for (int i = 0; i < from.PageCount; i++)
//    {
//        to.AddPage(from.Pages[i]);
//    }
//}

if (File.Exists("testFile.pdf")){
    File.Delete("testFile.pdf");
}

var writer = new PdfWriter("testFile.pdf");
var pdf = new PdfDocument(writer);
var document = new Document(pdf);
document.Add(new Paragraph("Hello World!"));
document.Close();

