using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace CinemaPathe
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btpdf_Click(object sender, EventArgs e)
        {
            //Pour utiliser le modèle objet de itextsharp : télécharger sur internet itextsharp.dll
            //Puis menu Projet/Ajouter une référence/Parcourir/itextsharp.dll
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("Projection.pdf", FileMode.Create));
            doc.Open();
            PdfPTable table = new PdfPTable(6);
            table.TotalWidth = 450;
            table.LockedWidth = true;


            table.AddCell("Titre");
            table.AddCell("Date de Projection");
            table.AddCell("Heure de projection");
            table.AddCell("Salle de projection");
            table.AddCell("info projection");
            table.AddCell("Affiche");


            OdbcConnection cnn = new OdbcConnection();
            OdbcCommand cmd = new OdbcCommand();
            OdbcDataReader drr;
            Boolean existenreg;
            cnn.ConnectionString = "Driver={MySQL ODBC 8.0 ANSI Driver};SERVER=localhost;Database=bdcinedesousamartins_delachapelle;uid=root;pwd=";
            cnn.Open();
            cmd.CommandText = "select nosalle, dateproj, heureproj, titre, infoproj, imgaffiche from film inner join projeter on projeter.nofilm = film.nofilm inner join projection on projection.noproj=projeter.noproj";
            cmd.Connection = cnn;
            drr = cmd.ExecuteReader();
            existenreg = drr.Read();
            while (existenreg == true)
            {
                if (Convert.ToDateTime(drr["dateproj"]).Day==dateTimePicker1.Value.Day && Convert.ToDateTime(drr["dateproj"]).Month == dateTimePicker1.Value.Month)
                { 
                    table.AddCell(Convert.ToString(drr["titre"]));

                    DateTime dtproj = Convert.ToDateTime(drr["dateproj"]);
                    table.AddCell(Convert.ToString(dtproj.ToString("dd/MM/yyyy")));

                    TimeSpan hproj = (TimeSpan)drr["heureproj"];
                    table.AddCell(Convert.ToString(hproj.ToString(@"h\:mm")));

                    table.AddCell(Convert.ToString(drr["nosalle"]));

                    table.AddCell(Convert.ToString(drr["infoproj"]));

                    iTextSharp.text.Image image2 = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\images\\" + drr["imgaffiche"]);
                    image2.ScaleToFit(120, 98);
                    image2.Alignment = Element.ALIGN_CENTER;
                    PdfPCell cellImage = new PdfPCell(image2);
                    cellImage.PaddingTop = 5f;
                    cellImage.PaddingBottom = 5f;
                    cellImage.PaddingLeft =1f;
                    cellImage.PaddingRight = 10f;
                    table.AddCell(cellImage);

                }
                existenreg = drr.Read();


            }
            drr.Close();
            cnn.Close();


            //L’image à afficher 01001.png doit être présente dans le dossier bin/debug du projet
            iTextSharp.text.Image image1 = iTextSharp.text.Image.GetInstance(Application.StartupPath + "\\logo1.png");
            image1.ScaleToFit(300,240);
            image1.Alignment = Element.ALIGN_CENTER;
            doc.Add(image1);
            doc.Add(table);

            doc.Close();

            //Ouverture de l'application système par défaut associée à un pdf
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo = new System.Diagnostics.ProcessStartInfo("Projection.pdf");
            p.Start();
            p.Dispose();
        }
    }
}