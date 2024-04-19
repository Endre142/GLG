using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;



namespace GLG
{
    internal class AddConditie
    {
        public static string Create(List<string> productList)
        {
           
            string pdfpath = "factura.pdf";
            using(PdfWriter writer = new PdfWriter(pdfpath))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf,PageSize.A4);
                document.SetMargins(30f,30f,30f,30f);
                string fontPath2 = @"C:\Windows\Fonts\arial.ttf";
                PdfFont f = PdfFontFactory.CreateFont(fontPath2,PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);

                Text te1 = new Text("CERTIFICAT DE GARANȚIE\r\n").SetFontSize(11).SetFont(f).SetTextAlignment(TextAlignment.CENTER).SetBold();
                Text te2 = new Text("echipamente electrice și electronice").SetFontSize(9).SetFont(f);
                Paragraph titelPara = new Paragraph().Add(te1).SetTextAlignment(TextAlignment.CENTER).Add(te2).SetTextAlignment(TextAlignment.CENTER);
                document.Add(titelPara);
                float tableWidth = PageSize.A4.GetWidth()-60;

                Table PersoanaAutData = new Table(2).SetWidth(tableWidth).SetHeight(50);
                Cell persoanT = new Cell().SetHeight(23).SetWidth(140).Add(new Paragraph().Add(new Text("Persoana autorizată(electrician)\r\ncare a montat echipamentului ").SetFontSize(8).SetFont(f).SetBold()));
                Cell reparatiT = new Cell(2,1).Add(new Paragraph().Add(new Text("Reparații în garanție:").SetFontSize(8).SetFont(f).SetBold()));
                Cell datapersT = new Cell();
                PersoanaAutData.AddCell(persoanT).AddCell(reparatiT).AddCell(datapersT);
                document.Add(PersoanaAutData);

                /********************************************************Productstabel*************************************************************/
                //productList=>list string
                if(productList.Count()<=12)
                {
                    //tabelheader;
                    Table productTable = new Table(2).SetWidth(tableWidth).SetMarginTop(7).SetBorder(Border.NO_BORDER);
                    Table productTable2 = new Table(3).SetWidth(tableWidth).SetMarginTop(7);
                    Cell nr1 = new Cell().SetWidth(20).Add(new Paragraph().Add(new Text("Nr.").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                    Cell produs1 = new Cell().SetWidth(120).Add(new Paragraph().Add(new Text("Denumire produs ").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                    Cell serie1 = new Cell().Add(new Paragraph().Add(new Text("Nr. Serie").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                    Cell nr2 = new Cell().SetBorderLeft(Border.NO_BORDER).SetWidth(20).Add(new Paragraph().Add(new Text("Nr.").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                    Cell produs2 = new Cell().SetWidth(120).Add(new Paragraph().Add(new Text("Denumire produs").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                    Cell serie2 = new Cell().Add(new Paragraph().Add(new Text("Nr. Serie").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                    Table firstTable = new Table(3).SetPadding(0).SetMargins(0,0,0,0).SetWidth(tableWidth/2.0f);
                    Table secondTable = new Table(3).SetPadding(0).SetMargins(0,0,0,0).SetWidth(tableWidth/2.0f);
                    int listsfert = productList.Count()/2;
                    if(listsfert<2)
                    {
                        Cell nr = new Cell().Add(new Paragraph().Add(new Text("Nr.").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                        Cell produs = new Cell().Add(new Paragraph().Add(new Text("Denumire produs ").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);
                        Cell serie = new Cell().SetWidth(170).Add(new Paragraph().Add(new Text("Nr. Serie").SetFontSize(10).SetFont(f).SetBold())).SetTextAlignment(TextAlignment.CENTER);

                        productTable2.AddCell(nr).AddCell(produs).AddCell(serie).SetTextAlignment(TextAlignment.CENTER);

                        for(int i = 0;i<productList.Count();i++)
                        {
                            Cell n = new Cell().Add(new Paragraph().Add(new Text(Convert.ToString((i+1))).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            Cell p = new Cell().Add(new Paragraph().Add(new Text(productList[i]).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            Cell s = new Cell();

                            productTable2.AddCell(n)
                                .AddCell(p)
                                .AddCell(s);
                        }
                        document.Add(productTable2);
                    }
                    else
                    {
                        firstTable.AddCell(nr1).AddCell(produs1).AddCell(serie1).SetTextAlignment(TextAlignment.CENTER);
                        secondTable.AddCell(nr2).AddCell(produs2).AddCell(serie2).SetTextAlignment(TextAlignment.CENTER);
                        int ind;
                        if(productList.Count()%2==1)
                        {
                            ind=listsfert+2;
                        }
                        else
                        {
                            ind=listsfert+1;
                        }
              
                        for(int i = 0, j = listsfert;i<listsfert;i++, j++, ind++)
                        {
                            Cell n = new Cell().Add(new Paragraph().Add(new Text(Convert.ToString((i+1))).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            Cell s = new Cell();
                            Cell n1 = new Cell().SetBorderLeft(Border.NO_BORDER).Add(new Paragraph().Add(new Text(Convert.ToString(ind)).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            Cell s1 = new Cell().SetBorderLeft(Border.NO_BORDER);
                            Cell p;
                            Cell p1;

                            if(productList[i].Length>23)
                            {
                                p=new Cell().SetHeight(28.5f).Add(new Paragraph().Add(new Text(productList[i]).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            }
                            else
                            {
                                p=new Cell().Add(new Paragraph().Add(new Text(productList[i]).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            }
                            if(productList[j].Length>23)
                            {
                                p1=new Cell().SetHeight(28.5f).SetBorderLeft(Border.NO_BORDER).Add(new Paragraph().Add(new Text(productList[j]).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);

                            }
                            else
                            {
                                p1=new Cell().SetBorderLeft(Border.NO_BORDER).Add(new Paragraph().Add(new Text(productList[j]).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            }


                            firstTable.AddCell(n)
                                .AddCell(p)
                                .AddCell(s);
                            secondTable.AddCell(n1)
                                .AddCell(p1)
                                .AddCell(s1);
                        }

                        if(productList.Count()%2==1)
                        {
                            Cell n = new Cell().Add(new Paragraph().Add(new Text(Convert.ToString(listsfert+1)).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            Cell p = new Cell().Add(new Paragraph().Add(new Text(productList[productList.Count()-1]).SetFontSize(8).SetFont(f))).SetTextAlignment(TextAlignment.CENTER);
                            Cell s = new Cell();
                            firstTable.AddCell(n)
                               .AddCell(p)
                               .AddCell(s);
                        }
                        
                        productTable.AddCell(new Cell().SetPadding(0).SetMargins(0,0,0,0).SetBorder(Border.NO_BORDER).Add(firstTable));
                        productTable.AddCell(new Cell().SetPadding(0).SetMargins(0,0,0,0).SetBorder(Border.NO_BORDER).Add(secondTable));
                        document.Add(productTable);
                    }
                }
                else
                {
                    Paragraph p = new Paragraph().Add(new Text(Convert.ToString("Produse conform anexă.\r\n")).SetFontSize(10).SetFont(f));
                    document.Add(p);
                }

                /****************************************BIGTEXT*************************************************************************************/
                Paragraph last_page = new Paragraph();
                List<string> constdata = new List<string>();
                constdata.Clear();
                int seged = 0;
                constdata=CommonPart.DataReader("Resources//SourcesFiles//ConstData.txt",ref seged);


                Text n_2 = new Text("");
                int k;
                for(k=21;k<(constdata.Count()-1);k++)
                {

                    string current = constdata[k];
                    if(current[0]=='-')
                    {
                        Paragraph indent = new Paragraph();
                        indent.SetMargin(0);
                        indent.SetMarginLeft(Convert.ToInt32(constdata[18])).SetFontSize(8);
                        while(current[0]=='-'||current[0]=='-')
                        {
                            n_2=new Text(constdata[k]+"\n").SetFont(f).SetFontSize(8);
                            indent.Add(n_2);
                            k++;
                            current=constdata[k];
                        }
                        last_page.Add(indent);
                        last_page.Add("\n");
                        k--;
                    }
                    else
                    {
                        n_2=new Text(constdata[k]+"\n").SetFont(f).SetFontSize(8);
                        last_page.Add(n_2);
                    }

                }
                Text n_3 = new Text(constdata[k]).SetFont(f).SetFontSize(9).SetBold();
                last_page.Add(n_3);
                document.Add(last_page);
                document.Close();
                pdf.Close();
                writer.Close();

            }
            return pdfpath;
        }

        public static string magePdf(string firstpdf,string secondpdf)
        {
            string outputFilePath = "mergedpdf.pdf";

            try
            {
                PdfDocument newPdfDocument = new PdfDocument(new PdfWriter(outputFilePath));

                PdfDocument firstPdfDocument = new PdfDocument(new PdfReader(firstpdf));
                PdfDocument secondPdfDocument = new PdfDocument(new PdfReader(secondpdf));

                for(int i = 1;i<=firstPdfDocument.GetNumberOfPages();i++)
                {
                    PdfPage page = firstPdfDocument.GetPage(i);
                    newPdfDocument.AddPage(page.CopyTo(newPdfDocument));
                }

                for(int i = 1;i<=secondPdfDocument.GetNumberOfPages();i++)
                {
                    PdfPage page = secondPdfDocument.GetPage(i);
                    newPdfDocument.AddPage(page.CopyTo(newPdfDocument));
                }

                newPdfDocument.Close();
                firstPdfDocument.Close();
                secondPdfDocument.Close();


            }
            catch(Exception ex)
            {
                return null;
            }
            return outputFilePath;
        }
    }
}
