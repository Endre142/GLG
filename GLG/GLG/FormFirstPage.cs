using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iText.IO.Image;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;


namespace GLG
{
    public partial class FormFirstPage : Form
    {
        List<string> constData = new List<string>();
        List<string> newData = new List<string>();
        List<string> textboxName = new List<string>
        {
            "Title",
            "SubTit",
            "First",
            "Second",
            "Third",
            "Five_four",
            "Footnote",
            "FootSecond",
            "FootThird",
            "FootFourth",
            "FootLast"
        };
        private int firstPageLastpoz = 0;

        public FormFirstPage()
        {
            InitializeComponent();
        }


    

        private int ConstDataReader(ref List<string> constdata)
        {
            string filePath = Form1.filepaths[2];
            int firstPageLastPoz = 0;
            int i = 0;
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
                            firstPageLastPoz = i;
                        }
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Elso olda olvasas meghiusult");
            }
            return firstPageLastPoz;
        }

        private void ConstDataWhriter(ref List<string> constdata)
        {
            string filePath = Form1.filepaths[2];
            string newListText = string.Join(Environment.NewLine, constData);
            File.WriteAllText(filePath, newListText);
        }

        private void modify()
        {
            newData.Clear();
            string[] lines = textBox1.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            newData.AddRange(lines);

            PdfWriter writer = new PdfWriter(Form1.filepaths[0]);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            PdfFont f = PdfFontFactory.CreateFont("C:/Windows/Fonts/Arial Black.ttf", PdfEncodings.IDENTITY_H);
            pdf.SetDefaultPageSize(PageSize.A4);

            int wi = (Convert.ToInt32(PageSize.A4.GetWidth()) - 2 * 20) / 3;

            string imagePath;

            if (Convert.ToBoolean(Convert.ToInt16(constData[15])))
            {
                imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "image", "con_log.jpg");
            }
            else
            {
                imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "image", "kazandepo.png");
            }
            ImageData imageData = ImageDataFactory.Create(imagePath);
            iText.Layout.Element.Image image = new iText.Layout.Element.Image(imageData).ScaleAbsolute(fitWidth: 200, fitHeight: 60);
            document.Add(image);

            Paragraph header = new Paragraph(constData[0] + "\n" + constData[1]).SetFont(f)
               .SetTextAlignment(TextAlignment.CENTER)
               .SetFontSize(15);

            document.Add(header);

            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);
            Paragraph newline = new Paragraph("\n");
            document.Add(newline);


            Text t1 = new Text(constData[2]).SetFont(f).SetFontSize(10).SetBold();
            Text t2 = new Text(constData[3]).SetFont(f).SetFontSize(10);
            Paragraph a = new Paragraph();
            a.Add(t1);
            a.Add(t2);
            document.Add(a);

            Text t3 = new Text(constData[4]).SetFont(f).SetFontSize(10).SetBold();
            Text t4 = new Text("\"kliens\"").SetFont(f).SetFontSize(10);
            Paragraph b = new Paragraph();
            b.Add(t3);
            b.Add(t4);
            document.Add(b);

            Text t5 = new Text(constData[5]).SetFont(f).SetFontSize(10).SetBold();
            Text t6 = new Text(" PSF" + "\"pfs szám 4521\"" + ", " + "\"dátum\"").SetFont(f).SetFontSize(10);
            Paragraph c = new Paragraph();
            c.Add(t5);
            c.Add(t6);
            document.Add(c);

            Text t7 = new Text(constData[6] + "\n" + constData[7]).SetFont(f).SetFontSize(10).SetBold();
            Text t8 = new Text(constData[8]).SetFont(f).SetFontSize(10);
            Paragraph d = new Paragraph();
            d.Add(t7);
            d.Add(t8);
            document.Add(d);


            Paragraph line = new Paragraph("\n");
            document.Add(line);
            Table table1 = new Table(3, false);
            Cell cell11 = new Cell(1, 1)
                .SetWidth(wi)

               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Vânzător").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(10))
               .Add(new Paragraph("(semnătura/ștampilă)").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(7));


            Cell cell12 = new Cell(1, 1)
                .SetWidth(wi)

               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Electrician").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(10))
               .Add(new Paragraph("(semnătura/ștampilă)").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(7));


            Cell cell13 = new Cell(1, 1)
               .SetWidth(wi)

               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Cumpărător").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(10))
               .Add(new Paragraph("(semnătura/ștampilă)").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(7));


            Cell cell21 = new Cell(1, 1).SetHeight(70);
            Cell cell22 = new Cell(1, 1).SetHeight(70);
            Cell cell23 = new Cell(1, 1).SetHeight(70);

            table1.AddCell(cell11);
            table1.AddCell(cell12);
            table1.AddCell(cell13);
            table1.AddCell(cell21);
            table1.AddCell(cell22);
            table1.AddCell(cell23);

            document.Add(table1);
            document.Add(newline);
            // products table
            int siz = (Convert.ToInt32(PageSize.A4.GetWidth()) - 2 * 20) / 4;
            Table table2 = new Table(3, false);
            Cell cell31 = new Cell(1, 1)
                .SetWidth(siz - 385)

               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Nr.").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(10).SetBold());

            Cell cell32 = new Cell(1, 1)
                .SetWidth(siz * 2)

               .SetTextAlignment(TextAlignment.CENTER)
               .Add(new Paragraph("Denumire produs").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(10).SetBold());

            Cell cell33 = new Cell(1, 1)
                .SetWidth(siz + 385)

              .SetTextAlignment(TextAlignment.CENTER)
              .Add(new Paragraph("Nr. Serie").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(10).SetBold());
            table2.AddCell(cell31);
            table2.AddCell(cell32);
            table2.AddCell(cell33);
            document.Add(table2);
            document.Add(newline);

            LineSeparator l = new LineSeparator(new SolidLine());
            Paragraph e = new Paragraph("Reparații în garanție").SetFont(f).SetFontSize(10);
            Paragraph g = new Paragraph();
            document.Add(e);
            for (int i = 0; i < 4; i++)
            {
                g.Add(l.SetWidth(PageSize.A4.GetWidth() - 72));
            }
            document.Add(g);
            Paragraph foother = new Paragraph(constData[9] + "\n" + constData[10] + "\n" + constData[11] + "\n" + constData[12] + "\n" + constData[13]).SetFont(f)
             .SetTextAlignment(TextAlignment.CENTER)
              .SetFontSize(9);
            document.Add(foother);
            document.Close();
            pdf.Close();
            writer.Close();
            pdfDocumentViewer1.LoadFromFile(Form1.filepaths[0]);
        }

        private void FormFirstPage_Load_1(object sender, EventArgs e)
        {
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            pdfDocumentViewer1.Top = 50;
            pdfDocumentViewer1.Left = panel1.Width + 50;
            pdfDocumentViewer1.Width = (Width - (panel1.Width + 50)) - 50;
            pdfDocumentViewer1.Height = Height - 100;
            firstPageLastpoz = ConstDataReader(ref constData);

            for (int i = 0, j = 0; j < 11; i++, j++)
            {
                TextBox textBox = Controls.Find("tBx" + textboxName[j], true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    if (i != 2)
                    {
                        textBox.Text = constData[i];
                    }
                    else
                    {
                        textBox.Text = (constData[i] + "\r\n" + constData[i + 1]);
                        i++;
                    }
                    if (i == 6)
                    {
                        textBox.Text = (constData[i] + "\r\n" + constData[i + 1] + "\r\n" + constData[i + 2]);
                        i += 2;
                    }

                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0, j = 0; j < 11; i++, j++)
            {
                TextBox textBox = Controls.Find("tBx" + textboxName[j], true).FirstOrDefault() as TextBox;

                if (textBox != null)
                {
                    if (i != 2)
                    {
                        constData[i] = textBox.Text;
                    }
                    else
                    {
                        List<string> linesList = textBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        constData[i] = linesList[0];
                        constData[i + 1] = linesList[1];
                        i++;
                    }
                    if (i == 6)
                    {
                        List<string> linesList = textBox.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                        constData[i] = linesList[0];
                        constData[i + 1] = linesList[1];
                        constData[i + 2] = linesList[2];
                        i += 2;
                    }

                }
            }
            modify();
            ConstDataWhriter(ref constData);
            Form1.ConstDataReader();
        }
    }
}
