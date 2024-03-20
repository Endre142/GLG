using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GLG
{
    public partial class Into_one : Form
    {
        private static FileSystemWatcher watcher = null;
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
                string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");

                try
                {
                    if (Directory.Exists(downloadFolderPath))
                    {
                        watcher = new FileSystemWatcher(downloadFolderPath);
                        watcher.Filter = "*.pdf";
                        watcher.Renamed += OnFileRenamed;
                        watcher.Error += OnError;
                        watcher.EnableRaisingEvents = true;
                        MessageBox.Show("Figyelő elindult.");
                    }
                    else
                    {
                        throw new DirectoryNotFoundException("A letöltési mappa nem található.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba történt: " + ex.Message); ///atirni 
                }
            }
            else
            {
                watcher.EnableRaisingEvents = true;
                MessageBox.Show("Figyelő leállítva.");
            }
        }

        private void OnFileRenamed(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new System.Action(async () =>
            {
                    //folyatani
            }));
        }
        private static void OnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("Hiba: Figyelő leállt!");
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }

        private void printing_button_Click(object sender, EventArgs e)
        {

        }

        private void Editor_Click(object sender, EventArgs e)
        {

        }
    }
}
