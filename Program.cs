// See https://aka.ms/new-console-template for more information

using iText.Kernel.Pdf;
using iText.Layout;

string[] filesToMerge = Directory.GetFiles(@".\SamplePDFFiles", "*.pdf");


var writer = new PdfWriter(@".\Output\mergedFile.pdf");
var pdf = new PdfDocument(writer);

using (var destDocument = new Document(pdf))
{

    foreach (var file in filesToMerge)
    {
 
        Console.WriteLine($"Processing: {file}");

        using (PdfDocument origPdf = new PdfDocument(new PdfReader(file)))
        {
            var totalPages = origPdf.GetNumberOfPages();

            for (var i = 0; i < totalPages; i++)
            {
                origPdf.CopyPagesTo(1, totalPages, pdf);
            }
        }

    }

    destDocument.Close();
}