using iText;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire;
using System.Drawing;
using System.Text.RegularExpressions;
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
            string downloadFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            try
            {
                if (Directory.Exists(downloadFolderPath))
                {
                    FileSystemWatcher watcher = new FileSystemWatcher(downloadFolderPath);
                    watcher.Filter = "*.pdf";
                    watcher.NotifyFilter = NotifyFilters.FileName;
                    watcher.Error += OnError;
                    return watcher;
                }
                else
                {
                    throw new DirectoryNotFoundException("A letöltési mappa nem található.");
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
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
        public static List<string> ProductList(string pdfContent) {
            List<string> product = new List<string>();

            string pattern = @"(\d+)\s([A-Za-z].*?),.*?([bB][uU][cC]\s(\d+))";
            MatchCollection matches = Regex.Matches(pdfContent, pattern);

            foreach (Match match in matches)
            {
                if (!Regex.IsMatch((match.Groups[2].Value), @"(Reducere|SENZOR|Aprinder|aprindere|APRINDERE|Condensator|CONDENSATOR|condensator|Termostat|TERMOSTAT|termostat|Discount)"))
                {
                    int product_number = Convert.ToInt32(match.Groups[3].Value.Substring(3));
                    for (int i = 0; i < product_number; i++)
                    {
                        product.Add(match.Groups[2].Value);
                        
                    }
                }
            }

            return product;
        }
    }
}
