using iText;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire;
namespace GLG
{
    internal class CommonPart
    {
        public static string Filedialogpath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return null;
                }
            }
        }

        public static FileSystemWatcher StartWatcher(object sender, EventArgs e)
        {
            FileSystemWatcher watcher = new FileSystemWatcher(System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"));
            watcher.Filter = "*.pdf";
            watcher.NotifyFilter = NotifyFilters.FileName;
            watcher.Error += OnError;
            return watcher;

        }
        private static void OnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("Hiba: Figyelő leállt!");
        }

        public static void printer(string filepath,bool printDuplex)
        { 
            Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
            doc.LoadFromFile(filepath);
            bool canDuplex = doc.PrintSettings.CanDuplex;
            if (canDuplex && printDuplex)
            {
                doc.PrintSettings.Duplex = System.Drawing.Printing.Duplex.Vertical;
            }
            doc.Print();
        }

    }
}
