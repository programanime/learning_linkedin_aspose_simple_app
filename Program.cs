using Aspose;
// See https://aka.ms/new-console-template for more information
namespace app
{
    class Program
    {
        public static void wordToHtml(){
            var wrdf = new Aspose.Words.Document("activities.docx");
            wrdf.Save("output.html", Aspose.Words.SaveFormat.Html);
        }

        public static void pdfToImage(){
            // Load PDF file to be converted
            var wrdf = new Aspose.Words.Document("template.pdf");

            // Convert PDF to JPG
            wrdf.Save("template_output.jpeg", Aspose.Words.SaveFormat.Jpeg);
        }

        public static void wordToPdf(){
            // Load DOCX file to be converted
            var wrdf = new Aspose.Words.Document("activities.docx");

            // Convert DOCX to PDF
            wrdf.Save("activities.pdf", Aspose.Words.SaveFormat.Pdf);
            
        }

        public static void Main()
        {
            wordToPdf();
        }
    }
}
