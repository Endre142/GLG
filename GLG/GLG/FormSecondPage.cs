using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;


namespace GLG
{   
    public partial class FormSecondPage : Form
    {    
        List<string>constData = new List<string>();
        List<string> newData = new List<string>();
        public static int secondPagePozocion = 0;
        public FormSecondPage()
        {
            InitializeComponent();
        }

        private void FormSecondPage_Load(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            pdfDocumentViewer1.Top = 50;
            pdfDocumentViewer1.Left = panel1.Width+panel2.Width + 50;
            pdfDocumentViewer1.Width = (Width - (panel1.Width +panel2.Width+ 50)) - 50;
            pdfDocumentViewer1.Height = Height - 100;

            secondPagePozocion = ConstDataReader(ref constData);
            tbxTsize.Text = constData[secondPagePozocion+1];
            cbxTloc.Text = constData[secondPagePozocion+2];
            tbxWhiteSpase.Text = constData[secondPagePozocion+3];
            tbxLastsize.Text = constData[secondPagePozocion+4];
            panel2.Height = Form2.desktopHeight;           
            for(int i = secondPagePozocion+5;i<constData.Count;i++)
            {
                textBox1.Text+= constData[i]+"\r\n";
            }
            
            
        }

        private int ConstDataReader(ref List<string> constdata)
        {
            string filePath =Form1.filepaths[2];
            int secondPagePoz = 0;
            int i=0;
            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        constdata.Add(line);
                        if (line == "***")
                        {
                            secondPagePoz = i+1;
                        }
                        i++;
                    }
                }
            }
            return secondPagePoz;
        }

        private void ConstDataWhriter( ref List<string> constdata)
        {
            string filePath = Form1.filepaths[2];
            string newListText = string.Join(Environment.NewLine, constData);
            File.WriteAllText(filePath, newListText);
        }

        private void modify()
        {   newData.Clear();
            string[] lines = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            newData.AddRange(lines);


            PdfWriter writer = new PdfWriter(Form1.filepaths[1]);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            PdfFont f = PdfFontFactory.CreateFont("C:/Windows/Fonts/Arial.ttf", PdfEncodings.IDENTITY_H);
            pdf.SetDefaultPageSize(PageSize.A4);

            Paragraph last_page = new Paragraph();
            Paragraph title = new Paragraph();
            Text n_1 = new Text(newData[0] + "\n").SetFont(f).SetFontSize(Convert.ToInt32(tbxTsize.Text)).SetBold();

            if (cbxTloc.Text == "Közép")
            {
                title.Add(n_1).SetTextAlignment(TextAlignment.CENTER);
            }
            else
            {
                title.Add(n_1);
            }

            document.Add(title);
            Text n_2 = new Text("");
            int k;
            for (k = 1; k < (newData.Count() - 1); k++)
            {

                string current = newData[k];
                if (current[0] == '-')
                {
                    Paragraph indent = new Paragraph();
                    indent.SetMargin(0);
                    indent.SetMarginLeft(Convert.ToInt32(tbxWhiteSpase.Text));
                    while (current[0] == '-' || current[0] == '-')
                    {
                        n_2 = new Text(newData[k] + "\n").SetFont(f).SetFontSize(9);
                        indent.Add(n_2);
                        k++;
                        current = newData[k];
                    }
                    last_page.Add(indent);
                    last_page.Add("\n");
                    k--;
                }
                else
                {
                    n_2 = new Text(newData[k] + "\n").SetFont(f).SetFontSize(9);
                    last_page.Add(n_2);
                }

            }
            last_page.Add("\n");
            Text n_3 = new Text(newData[k]).SetFont(f).SetFontSize(Convert.ToInt32(tbxLastsize.Text)).SetBold();
            last_page.Add(n_3);
            document.Add(last_page);
            document.Close();
            pdf.Close();
            writer.Close();
            pdfDocumentViewer1.LoadFromFile(Form1.filepaths[1]);
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            modify(); 
            constData.RemoveRange(secondPagePozocion+1,constData.Count-(secondPagePozocion+1));
            constData.Add(tbxTsize.Text);
            constData.Add(cbxTloc.Text);
            constData.Add(tbxWhiteSpase.Text);
            constData.Add(tbxLastsize.Text);
            for(int i = 0; i < newData.Count; i++)
            {
                constData.Add(newData[i]);
            }
            ConstDataWhriter( ref constData);
            Form1.ConstDataReader();
        }

        private void tbxTsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            isnumber(e);
        }

        private void tbxWhiteSpase_KeyPress(object sender, KeyPressEventArgs e)
        {
            isnumber(e);
        }

        private void tbxLastsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            isnumber(e);
        }

        private void isnumber( KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

                if (e.KeyChar != '\b' && e.KeyChar != '\u007F') 
                {
                    MessageBox.Show("Csak számokat lehet beírni!");
                }
            }
        }
    }
}
