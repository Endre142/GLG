
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GLG
{
    public partial class Form1 : Form
    {
        public static string pdfContent = null;
        public static int logo_image_number;
        public static string psf = "";
        public static string data = "";
        public static string client = "";
        public static List<string> products = new List<string>(); // products list;
        public static string newPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "GLG pdf-ek");
        int pulsz = 4; // URES SOROK Reparati alatt
        public string wiever = null, dokumentpath = null;
        public static int volt;
        public bool new_page = true;
        public int sor = 4;
        public bool run = false;
        public bool printDuplex = true;
        private Form2 form2;
        public static List<string> constdata = new List<string>();
        public static string fullDownloadsPath;
        public static FileSystemWatcher watcher = null;
        public static string[] filepaths = new string[]
        {
             "..//..//files//firstpage.pdf",
             "..//..//files//secondpage.pdf",
             "..//..//files//ConstData.txt",
             "..//..//files//clear.pdf"
        };
       

        public Form1()
        {
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        public static void ConstDataReader() 
        {
            if (constdata.Count != 0)
            {
                constdata.Clear();
            }

            if (File.Exists(filepaths[2]))
            {
                using (StreamReader reader = new StreamReader(filepaths[2]))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        constdata.Add(line);
                    }
                    reader.Close();
                }
                logo_image_number = Convert.ToInt16(constdata[15]);

            }
            else
            {
                MessageBox.Show("Elso olvasa meghiusult form1");
                logo_image_number = 0;
            }
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            volt = Convert.ToInt16(numericUpDown1.Value);
            textBox8.Text = "Üres sorok száma:";

            panel1.Height = Height;
            panel3.Height = Height;

            pdfDocumentViewer1.Top = 50;
            pdfDocumentViewer1.Left = panel1.Width + panel3.Width + 50;
            pdfDocumentViewer1.Width = (Width - (panel1.Width + panel3.Width + 50)) - 50;
            pdfDocumentViewer1.Height = Height - 100;
            ConstDataReader();
            if (logo_image_number == 1)
            {
                comboBox1.Text = "CONTROLER";
            }
            else
            {
                comboBox1.Text = "KAZANDEPO";
            }

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
              form2 = new Form2();
              form2.Form2Closed += Form2_FormClosed;
            }

            this.Hide();
            form2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            finishclear();
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "pdf files (*.pdf)|*.pdf";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Data_scanning(openFileDialog.FileName);
                }
            }
        }
        void Data_scanning(string filepath)
        {
            pdfContent = Retdata.pdfText(filepath);

            try
            {
                First3_Data();
                textBox5.Text += psf;
                textBox6.Text += data;
                textBox7.Text += client;

                string pattern = @"(\d+)\s([A-Za-z].*?),.*?([bB][uU][cC]\s(\d+))";
                MatchCollection matches = Regex.Matches(pdfContent, pattern);

                foreach (Match match in matches)
                {
                    if (!Regex.IsMatch((match.Groups[2].Value), @"(Reducere|SENZOR|Aprinder|aprindere|APRINDERE|Condensator|CONDENSATOR|condensator|Termostat|TERMOSTAT|termostat|Discount)"))
                    {
                        int product_number = Convert.ToInt32(match.Groups[3].Value.Substring(3));
                        for (int i = 0; i < product_number; i++)
                        {
                            products.Add(match.Groups[2].Value);
                            listBox1.Items.Add(match.Groups[2].Value);
                        }
                    }
                }
                if (products.Count() != 0)
                {
                    Retdata.Generator(psf, data, client, newPath, products, pulsz, ref wiever, new_page, constdata, logo_image_number);
                    dokumentpath = wiever;
                    pdfDocumentViewer1.LoadFromFile(wiever);

                }
                else
                {
                    if (run)
                    {
                        throw new Exception("not found data");
                    }
                    finishclear();
                }
            }
            catch (Exception ex)
            { 
                if(ex.Message.Equals("not found data"))
                {
                    throw ex;
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Hiba történt az adatok keresése során!", "Hiba",buttons);
                    finishclear();
                }
               
            }
            
        }
        private void First3_Data()
        {
            string psfPattern = @"Factura PSF (\d+)";
            string issueDatePattern = @"Data emiterii: (\d{2}.\d{2}.\d{4})";
            string clientNamePattern = @"POLTHERM SYSTEM SRL\s*([^\n]+)";

            psf = ExtractUsingRegex(psfPattern, pdfContent);

            data = ExtractUsingRegex(issueDatePattern, pdfContent);
            client = ExtractUsingRegex(clientNamePattern, pdfContent);
            if (psf == null || data == null || client == null)
            {
                throw new Exception("Pdf is empty");
            }

        }
        static string ExtractUsingRegex(string pattern, string source)
        {
            Match match = Regex.Match(source, pattern);
            return match.Success ? match.Groups[1].Value.Trim() : null;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            if (dokumentpath != null)
            {
                Spire.Pdf.PdfDocument doc = new Spire.Pdf.PdfDocument();
                doc.LoadFromFile(wiever);
                bool canDuplex = doc.PrintSettings.CanDuplex;
                if (canDuplex && printDuplex)
                {
                    doc.PrintSettings.Duplex = System.Drawing.Printing.Duplex.Vertical;
                }

                doc.Print();
                finishclear();
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (new_page)
            {
                new_page = false;
                Retdata.Generator(psf, data, client, newPath, products, sor, ref wiever, new_page, constdata, logo_image_number);
            }
            else
            {
                new_page = true;
                Retdata.Generator(psf, data, client, newPath, products, sor, ref wiever, new_page, constdata, logo_image_number);
            }
            pdfDocumentViewer1.LoadFromFile(wiever);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CONTROLER")
            {
                logo_image_number = 1;
                constdata[15] = "1";
            }
            else
            {
                logo_image_number = 0;
                constdata[15] = "0";
            }
            string filePath = Form1.filepaths[2];
            string newListText = string.Join(Environment.NewLine, constdata);
            File.WriteAllText(filePath, newListText);
        }
        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(numericUpDown1.Value);
            if (x > volt)
            {
                Retdata.Generator(psf, data, client, newPath, products, ++sor, ref wiever, new_page, constdata, logo_image_number);
            }
            else
            {
                Retdata.Generator(psf, data, client, newPath, products, --sor, ref wiever, new_page, constdata, logo_image_number);
            }
            pdfDocumentViewer1.LoadFromFile(wiever);
            volt = Convert.ToInt32(numericUpDown1.Value);
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (run)
            {
                run = false;
                watcher.EnableRaisingEvents = false;
                MessageBox.Show("Figyelő leállítva.");
            }
            else
            {
                fullDownloadsPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
                watcher = new FileSystemWatcher(fullDownloadsPath);
                watcher.Filter = "*.pdf";
                watcher.NotifyFilter = NotifyFilters.FileName;
                watcher.Renamed += OnFileRenamed;
                watcher.Error += OnError;
                watcher.EnableRaisingEvents = true;
                MessageBox.Show("Figyelő elindult.");
                run = true;
            }
        }
        private void OnFileRenamed(object sender, FileSystemEventArgs e)
        {
            if (System.IO.Path.GetExtension(e.FullPath).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                if (Retdata.pdfText(e.FullPath)!=string.Empty)
                {
                    task(sender, e);
                }
            }
        }
        private void task(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new System.Action(async () =>
            {
                try
                {
                    wiever = dokumentpath = e.FullPath;
                    printDuplex = false;
                    button4_Click_1(sender, e);
                    printDuplex = true;
                    finishclear();
                    Data_scanning(e.FullPath);
                    button4_Click_1(sender, e);
                    dokumentpath = null;
                }catch (Exception ex)
                {
                    //empty doc
                    finishclear();
                }    
            }));
        }

        private static void OnError(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("Hiba: Figyelő leállt!");
        }
        private void finishclear()
        {
            pdfDocumentViewer1.LoadFromFile(filepaths[3]);
            numericUpDown1.Value = 4;
            sor = 4;
            products.Clear();
            listBox1.Items.Clear();
            psf = "";
            data = "";
            client = "";
            textBox7.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
