using iText.Layout.Element;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.Layout;
using iText.IO.Image;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace GLG
{
    public class Retdata
    {

        public static List<string> constdata = new List<string>();
        public static string pdfText(string path)
        {

            try
            {
                PdfDocument pdfDocument = new PdfDocument(new PdfReader(path));
                var page = pdfDocument.GetPage(1);
                var reader = new LocationTextExtractionStrategy();
                string text = string.Empty;
                text += PdfTextExtractor.GetTextFromPage(page, reader);
                pdfDocument.Close();
                return text;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Rossz a beolvassas");
                return string.Empty;
            }
        }

        public static void Generator(string psf,string data,string client,string pa,List<string> products,int plusz,ref string wiever,bool new_page,List<string> constdata, int logo_image_number){ 
            string last_path = pa;
            string pdf_nev = null;

            for(int i = 0, j = 0;i<client.Length;i++, j++)
            {
                if(client[i]>=48&&client[i]<=57||client[i]>=65&&client[i]<=90||client[i]==32||client[i]>=97&&client[i]<=122)    //NAGYBETUK
                {
                    pdf_nev+=client[i];
                }
            }
            last_path=pa+"\\"+psf+"_"+pdf_nev+".pdf";
            wiever=last_path;
            PdfWriter writer = new PdfWriter(last_path);
            iText.Kernel.Pdf.PdfDocument pdf = new iText.Kernel.Pdf.PdfDocument(writer);
            Document document = new Document(pdf);

            string fontPath2 = @"C:\Windows\Fonts\arial.ttf";

            try
            {
                PdfFont f = PdfFontFactory.CreateFont(fontPath2, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
                pdf.SetDefaultPageSize(PageSize.A4);
                int wi = (Convert.ToInt32(PageSize.A4.GetWidth()) - 2 * 20) / 3;
                string imagePath;
                if (Convert.ToBoolean(logo_image_number))
                {
                    imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "image", "con_log.jpg");
                }
                else
                {
                    imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "image", "kazandepo.png");
                }


                ImageData imageData = ImageDataFactory.Create(imagePath);
                iText.Layout.Element.Image image = new iText.Layout.Element.Image(imageData).ScaleAbsolute(fitWidth: 200, fitHeight: 60);
                document.Add(image);
                Paragraph header = new Paragraph(constdata[0] + " \n" + constdata[1]).SetFont(f)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .SetFontSize(15);

                document.Add(header);

                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);
                Paragraph newline = new Paragraph("\n");
                document.Add(newline);


                Text t1 = new Text(constdata[2]).SetFont(f).SetFontSize(10).SetBold();
                Text t2 = new Text(constdata[3]).SetFont(f).SetFontSize(10);
                Paragraph a = new Paragraph();
                a.Add(t1);
                a.Add(t2);
                document.Add(a);

                Text t3 = new Text(constdata[4]).SetFont(f).SetFontSize(10).SetBold();
                Text t4 = new Text(client).SetFont(f).SetFontSize(10);
                Paragraph b = new Paragraph();
                b.Add(t3);
                b.Add(t4);
                document.Add(b);

                Text t5 = new Text(constdata[5]).SetFont(f).SetFontSize(10).SetBold();
                Text t6 = new Text(" PSF" + psf + ", " + data).SetFont(f).SetFontSize(10);
                Paragraph c = new Paragraph();
                c.Add(t5);
                c.Add(t6);
                document.Add(c);

                Text t7 = new Text(constdata[6] + "\n" + constdata[7]).SetFont(f).SetFontSize(10).SetBold();
                Text t8 = new Text(constdata[8]).SetFont(f).SetFontSize(10);
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

                for (int i = 0; i < products.Count(); i++)
                {

                    Cell celli = new Cell(1, 1)
                    .SetWidth(siz - 385)
                   .SetTextAlignment(TextAlignment.CENTER)
                   .Add(new Paragraph(Convert.ToString(i + 1)).SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(8));

                    table2.AddCell(celli);

                    Cell celli2 = new Cell(1, 1)
                        .SetWidth(siz * 2)
                       .SetTextAlignment(TextAlignment.CENTER)
                       .Add(new Paragraph("" + products[i]).SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(8));

                    table2.AddCell(celli2);

                    Cell celli3 = new Cell(1, 1)
                        .SetWidth(siz + 385)
                      .SetTextAlignment(TextAlignment.CENTER)
                      .Add(new Paragraph(" ").SetTextAlignment(TextAlignment.CENTER).SetFont(f).SetFontSize(8));
                    table2.AddCell(celli3);

                }
                document.Add(table2);
                document.Add(newline);

                Paragraph e = new Paragraph("Reparații în garanție").SetFont(f).SetFontSize(10);
                document.Add(e);

                LineSeparator l = new LineSeparator(new SolidLine());



                Paragraph g = new Paragraph();
                for (int i = 0; i < plusz; i++)
                {
                    g.Add(l.SetWidth(PageSize.A4.GetWidth() - 72));
                }

                document.Add(g); // new line if don t good format

                Paragraph foother = new Paragraph(constdata[9] + "\n" + constdata[10] + "\n" + constdata[11] + "\n" + constdata[12] + "\n" + constdata[13]).SetFont(f)
                 .SetTextAlignment(TextAlignment.CENTER)
                  .SetFontSize(9);
                document.Add(foother);
                if (new_page)
                {
                    document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE)); // NEXT PAGE    
                }
                else
                {
                    document.Add(newline);
                }
                Paragraph last_page = new Paragraph();
                Paragraph title = new Paragraph();
                Text n_1 = new Text(constdata[20] + "\n").SetFont(f).SetFontSize(Convert.ToInt32(constdata[16])).SetBold();

                if (constdata[17] == "Közép")
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
                for (k = 21; k < (constdata.Count() - 1); k++)
                {

                    string current = constdata[k];
                    if (current[0] == '-')
                    {
                        Paragraph indent = new Paragraph();
                        indent.SetMargin(0);
                        indent.SetMarginLeft(Convert.ToInt32(constdata[18]));
                        while (current[0] == '-' || current[0] == '-')
                        {
                            n_2 = new Text(constdata[k] + "\n").SetFont(f).SetFontSize(9);
                            indent.Add(n_2);
                            k++;
                            current = constdata[k];
                        }
                        last_page.Add(indent);
                        last_page.Add("\n");
                        k--;
                    }
                    else
                    {
                        n_2 = new Text(constdata[k] + "\n").SetFont(f).SetFontSize(9);
                        last_page.Add(n_2);
                    }

                }
                last_page.Add("\n");
                Text n_3 = new Text(constdata[k]).SetFont(f).SetFontSize(Convert.ToInt32(constdata[19])).SetBold();
                last_page.Add(n_3);
                document.Add(last_page);
                document.Close();
                pdf.Close();
                writer.Close();
            }
                catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}






