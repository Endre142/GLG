using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;


namespace GLG
{
    public partial class Form1 : Form
    {
        private string pdfContent = null;
        private int logo_image_number;
        private string psf = "";
        private string data = "";
        private string client = "";
        private List<string> products=new List<string>();
        private int pulsz = 4;
        private string wiever = null, facturapath = null;
        private string newPath = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "GLG pdf-ek");
        private int volt;
        private bool new_page = true;
        private int sor = 4;
        private Form2 form2;
        private static List<string> constdata;
        private FileSystemWatcher watcher = null;
        private static string[] filepaths = new string[]
        {
             "..//..//files//firstpage.pdf",
             "..//..//files//secondpage.pdf",
             "..//..//files//ConstData.txt",
             "..//..//files//clear.pdf"
        };
        private bool automaticalPrint = false;

        public Form1()
        {
            InitializeComponent();
        }
        public static string getfilepaths(int index)
        {
            return filepaths[index];
        }
        public static void setLogoImagenumber(int logo_image_number)
        {
            logo_image_number = logo_image_number;
        }
        private void Form2_FormClosed(object sender, EventArgs e)
        {
            this.Show();
        }
        public static void ConstDataReader()
        {
            int logonumber = 0;
            constdata = CommonPart.DataReader(filepaths[2],ref logonumber);
            setLogoImagenumber(logonumber);
            
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
            facturapath = CommonPart.Filedialogpath();
            bool printEvent=false;
            if(facturapath!=null)
            {
                Data_scanning(facturapath);
                if(automaticalPrint&&wiever!=null)
                {
                    button4_Click_1(sender,e);
                    printEvent=true;
                }
                if(products.Count==0 && !printEvent)
                {
                    pdfDocumentViewer1.LoadFromFile(facturapath);
                    if(automaticalPrint)
                    {
                        button4_Click_1(sender,e);
                    }

                }

            }
        }
        void Data_scanning(string filepath)
        {
            pdfContent = Retdata.pdfText(filepath);

            try
            {
                First3_Data();
                textBox5.Text = psf;
                textBox6.Text = data;
                textBox7.Text = client;

                products=CommonPart.ProductList(pdfContent);
                foreach (string product in products)
                {
                    listBox1.Items.Add(product);    
                }

                if (products.Count() != 0)
                {
                    Retdata.Generator(psf, data, client, newPath, products, pulsz, ref wiever, new_page, constdata, logo_image_number);
                    pdfDocumentViewer1.LoadFromFile(wiever);

                }
                else
                {
                    if (checkBox3.Checked)
                    {
                        throw new Exception("not found data");
                    }
                    finishclear();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("not found data"))
                {
                    throw ex;
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Hiba történt az adatok keresése során!", "Hiba", buttons);
                    finishclear();
                }

            }

        }
        private void First3_Data()
        {
            string psfPattern = @"PSF (\d+)";
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
            CommonPart.printer(facturapath, false);
            if (wiever != null)
            {
                CommonPart.printer(wiever, true);
                finishclear();
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Retdata.Generator(psf, data, client, newPath, products, sor, ref wiever, new_page, constdata, logo_image_number);
            }
            else
            { 
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
            if (checkBox3.Checked)
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
           
                if (Retdata.pdfText(e.FullPath) != string.Empty)
                {
                    task(sender, e);
                }
          
        }
        private void task(object sender, FileSystemEventArgs e)
        {
            this.Invoke(new System.Action(async () =>
            {
                try
                {
                    CommonPart.printer(e.FullPath, false);
                    Data_scanning(e.FullPath);
                    CommonPart.printer(wiever, true);
                    wiever = null;
                    finishclear();
                }
                catch (Exception ex)
                {
                    //empty doc
                    finishclear();
                }
            }));
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.GetMainForm().Show();
        }
        private void checkBox2_CheckedChanged(object sender,EventArgs e)
        {
            if(checkBox2.Checked)
            {
                automaticalPrint=true;
                MessageBox.Show("Atomatikus nyomtatás elindult.");
            }
            else
            {
                automaticalPrint = false;
                MessageBox.Show("Automatikus nyomtata leállítva.");
            }
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
