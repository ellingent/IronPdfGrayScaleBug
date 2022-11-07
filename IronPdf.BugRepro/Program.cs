using System.Text;
using System;
using IronPdf;

class Program
{
    static void Main(string[] args)
    {
        GeneratePDF();
    }
    static void GeneratePDF()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(@"<HTML><BODY style='color: blue;'>Hello World</BODY></HTML>");
        var Renderer = new ChromePdfRenderer();
        Renderer.RenderingOptions.PaperSize = IronPdf.Rendering.PdfPaperSize.Letter;
        Renderer.RenderingOptions.GrayScale = true;
        PdfDocument PDF = Renderer.RenderHtmlAsPdf(sb.ToString());
        PDF.SaveAs(@$"{Environment.CurrentDirectory}\{Guid.NewGuid()}.pdf");
    }
}