using iTextSharp.text.pdf;
using iTextSharp.text;
using NorthHealthFormApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace NorthHealthFormApp.Helper
{
    internal class PDFGenerator
    {
        public static Document GenerateInvoicePDF(InvoicePDF invoicePDF)
        {
            // Créer un document PDF
            Document document = new Document();

            if (!Directory.Exists(@"C:\north_health\compte_rendu\"))
            {
                Directory.CreateDirectory(@"C:\north_health\compte_rendu\");
            }
            // Ouvrir le document
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(@"C:\north_health\compte_rendu\compte_rendu_" + invoicePDF.IdDossier+".pdf", FileMode.Create));
            document.Open();

            // Ajouter du contenu au document
            // Ajouter un titre centré
            Paragraph title = new Paragraph("Compte Rendu du RDV", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 25));
            title.Alignment = Element.ALIGN_CENTER;
            
            document.Add(title);

            document.Add(new Paragraph("Description", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)));
            document.Add(new Paragraph());

            // Récupérer les attributs de la classe
            var properties = typeof(InvoicePDF).GetProperties();

            // Afficher les attributs dans le rapport
            foreach (var property in properties)
            {
                document.Add(new Paragraph(property.Name + " : " + property.GetValue(invoicePDF)));
            }

            // Fermer le document
            document.Close();

            return document;
        }
    }
}
