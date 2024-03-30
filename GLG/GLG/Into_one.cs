using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GLG
{
    public partial class Into_one : Form
    {
        private static FileSystemWatcher watcher = null;
        private string facturpath = null;
        private bool printDuplex = true;
        public Into_one()
        {
            InitializeComponent();
        }

        private void Into_one_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GetMainForm().Show();
        }

        private void Into_one_Load(object sender, EventArgs e)
        {
            int viewerWidth = (Width - panel1.Width) / 2 - 60;
            pdfDocumentViewer1.Size=new Size(viewerWidth,Height-110);
            pdfDocumentViewer2.Size=new Size(viewerWidth,Height-110);
            
            pdfDocumentViewer1.Location = new Point(panel1.Width + 30, 30);
            pdfDocumentViewer2.Location = new Point(panel1.Width + viewerWidth + 90, 30);
        }

        private void automatic_operation_chekbox_CheckedChanged(object sender, EventArgs e)
        {
            if (automatic_operation_chekbox.Checked)
            {
                watcher = CommonPart.StartWatcher(sender, e);
                if (watcher != null)
                {
                    watcher.Renamed += OnFileRenamed;
                    watcher.EnableRaisingEvents = true;
                    MessageBox.Show("Figyelő elindult.");
                }
            }
            else
            {
                if (watcher != null)
                {
                    watcher.EnableRaisingEvents = false;
                    MessageBox.Show("Figyelő leállítva.");
                }
            }
        }

        private void OnFileRenamed(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new System.Action(async () =>
            {
                    //folyatani
            }));
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            facturpath = CommonPart.Filedialogpath();
            string facturacontent = Retdata.pdfText(facturpath);
            List<string> products = CommonPart.ProductList(facturacontent);
            if(0 != products.Count)
            {
                MessageBox.Show("Factrua generalas");
                RegeneredFactura.createFactura(facturacontent,products);
            }
            else
            {
                MessageBox.Show("Factrua Nyomtatas");
            }
        }

        private void printing_button_Click(object sender, EventArgs e)
        {
           // CommonPart.printer(/*genealasi file utvonala*/, printDuplex);
        }

    }
}
