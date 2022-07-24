using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;


namespace OnePage_Exporter
{
    public partial class Form1 : Form
    {
        string PDF_Path = "";
        int Pages_count = 0;
        public Form1()
        {
           
            InitializeComponent();
            export_button.Visible = false;
        }

        public void MergePDFs(string targetPath, string pdfs,int pagenumber)
        {
            using (var targetDoc = new PdfDocument())
            {
                    using (var pdfDoc = PdfReader.Open(pdfs, PdfDocumentOpenMode.Import))
                    {
                    Pages_count = pdfDoc.PageCount;
                    if (pagenumber > Pages_count || pagenumber <0 || PDF_Path == "" || Pages_count < 0)
                    {
                        MessageBox.Show("Nem jó oldalszám, vagy nem jó a pdf elérési útvonal.");
                        return;
                    }
                    {
                        
                        targetDoc.AddPage(pdfDoc.Pages[pagenumber]);
                    }

                    }

                targetDoc.Save(targetPath);
                string message = "Export elkészült.\n" +
                    "Megnyitja a mentési helyet?";
                string title = "Értesítés";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    Process.Start("explorer.exe", Directory.GetCurrentDirectory());
                }
                


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "Pdf Files|*.pdf";

            this.openFileDialog1.Title = "My PDF Browser";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                string file_name = openFileDialog1.FileName;

                    // Create a PictureBox.
                try
                {
                    //pdfs.Add(file);
                    label1.Text = "Filename: "+ openFileDialog1.SafeFileName;
                    PDF_Path = file_name;
                    export_button.Visible = true;
                }
                catch (SecurityException ex)
                {
                    // The user lacks appropriate permissions to read files, discover paths, etc.
                    MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                        "Error message: " + ex.Message + "\n\n" +
                        "Details (send to Support):\n\n" + ex.StackTrace
                    );
                }
                catch (Exception ex)
                {
                    // Could not load the image - probably related to Windows file system permissions.
                    MessageBox.Show("Cannot open the pdf: " + file_name.Substring(file_name.LastIndexOf('\\'))
                        + ". You may not have permission to read the file, or " +
                        "it may be corrupt.\n\nReported error: " + ex.Message);
                }
            }
            
        }

        private void export_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(pagenumber.Text);
            MergePDFs("Export_"+ number + "_oldal.pdf",PDF_Path, number-1);
        }

        private void pizsx69_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Pizsx69");
        }
    }
}
