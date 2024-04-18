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
        private bool printAutomat = false;
        private string mergedpdfPath=null;

        public Into_one()
        {
            InitializeComponent();
        }
        private void Into_one_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GetMainForm().Show();
        }
        private void Into_one_Load(object sender,EventArgs e)
        {
            pdfDocumentViewer1.Size=new Size(Width-panel1.Width-100,Height-110);
            pdfDocumentViewer1.Location=new Point(panel1.Width+50,30);
           
        }
        private void automatic_operation_chekbox_CheckedChanged(object sender, EventArgs e)
        {
            if (automatic_operation_chekbox.Checked)
            {
                watcher = CommonPart.StartWatcher(sender, e);
                if (watcher != null)
                {
                    watcher.Renamed += OnFileRenamed;
                    watcher.EnableRaisingEvents =true;
                    MessageBox.Show("Figyelő elindult.");
                    printAutomat = true;
                }
            }
            else
            {
                if(watcher!=null)
                {
                    watcher.EnableRaisingEvents=false;
                    MessageBox.Show("Figyelő leállítva.");
                }
                printAutomat=false;
            }
        }
        private void OnFileRenamed(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new System.Action(async () =>
            {
                searchTask(e.FullPath);
            }));
        }
        private void search_button_Click(object sender, EventArgs e)
        {
            pdfDocumentViewer1.LoadFromFile("../../files/clear.pdf");
            mergedpdfPath=null;
            searchTask(CommonPart.Filedialogpath());    
        }
        private void printing_button_Click(object sender, EventArgs e)
        {
            if(mergedpdfPath!=null)
            {
                CommonPart.printer(mergedpdfPath,printDuplex);
            } 
        }
        private void autoPrint_CheckedChanged(object sender,EventArgs e)
        {
            if(autoPrint.Checked)
            {
                printAutomat=true;
            }
            else
            {
                printAutomat=false;
            }
        }
        private void saveButtom_Click(object sender,EventArgs e)
        {
            if(mergedpdfPath!=null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter="PDF fájlok (*.pdf)|*.pdf|Összes fájl (*.*)|*.*";
                saveFileDialog1.FilterIndex=1;
                saveFileDialog1.RestoreDirectory=true;

                DialogResult result = saveFileDialog1.ShowDialog();

                if(result==DialogResult.OK)
                {

                    string filePath = saveFileDialog1.FileName;

                    try
                    {
                        File.Copy(mergedpdfPath,filePath,true);

                        MessageBox.Show("A fájl sikeresen mentve lett ide: "+filePath);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Hiba történt a fájl mentése közben: "+ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("A mentés megszakítva.");
                }
                pdfDocumentViewer1.LoadFromFile("../../files/clear.pdf");
                mergedpdfPath=null;
            }
            else
            {
                MessageBox.Show("Nem hoztál létre új fájlt.");
            }
           
        }
        private void searchTask(string facturapath)
        {
            

            if(facturapath!=null)
            {
                string facturacontent = Retdata.pdfText(facturapath);
                List<string> products = CommonPart.ProductList(facturacontent);
                if(0!=products.Count)
                {
                    //RegeneredFactura.createFactura(facturacontent, products);
                    string conditiePath = AddConditie.Create(products);
                    mergedpdfPath=AddConditie.magePdf(facturapath,conditiePath);
                    pdfDocumentViewer1.LoadFromFile(mergedpdfPath);
                    if(printAutomat&&mergedpdfPath!=null)
                    {
                        CommonPart.printer(mergedpdfPath,printDuplex);
                    }
                }
                else
                {
                    mergedpdfPath=facturapath;
                    if(printAutomat&&mergedpdfPath!=null)
                    {
                        CommonPart.printer(mergedpdfPath,false);
                    }
                    pdfDocumentViewer1.LoadFromFile(mergedpdfPath);
                }
            }
        }
    }
}
