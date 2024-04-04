using System.Text.RegularExpressions;
using System.Collections.Generic;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Geom;
using iText.IO.Image;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using System.Linq;
using System;
using iText.Layout.Renderer;
using iText.Layout.Layout;







namespace GLG
{
    internal class RegeneredFactura
    {
        private const int necessaryDatesNumber = 4;
        private static readonly string[] TeklaData = { "Reg. com.:"
                                        ," J19/223/2012",
                                        "CIF:",
                                         " RO30188241",
                                        "Adresa:",
                                        " STR. ZORILOR, NR.18, MUN. MIERCUREA",
                                        "CIUC,",
                                        " HARGHITA",
                                        "IBAN (RON):",
                                        " RO07BACX0000001112425000",
                                        "IBAN (RON):",
                                        " RO31TREZ3515069XXX005240",
                                        "Tel.:",
                                        " 0757701048",
                                        "Email:",
                                        " info@poltherm.ro",
                                        "Website:",
                                        " www.poltherm.ro",
                                        "Capital social:",
                                        " 200",
                                        "Website:",
                                        " www.centraletekla.ro / www.controler-e.ro"
        };
        public static void createFactura(string facturacontent, List<string> productList)
        {
            string cliensData = facturacontent.Substring(facturacontent.IndexOf("POLTHERM SYSTEM SRL ") + 19);
            CliensDataTabel data = new CliensDataTabel(ExtractTabelData(cliensdata(cliensData.Substring(0, cliensData.IndexOf("Pret unitar Valoare TVA")))));
            string[] necessaryDatas = necessaryDateSearch(facturacontent.Substring(0, facturacontent.IndexOf("Furnizor:")));
            int firstPozitionProdTable = facturacontent.IndexOf("(RON) (RON)") + 11;
            string lastPozitionProdTable;
            if (facturacontent.IndexOf("Marfa")!=-1)
            {
                lastPozitionProdTable = "Marfa";
                
            }
            else
            {
                lastPozitionProdTable = "Intocmit";
            }
            string tabelData = facturacontent.Substring(firstPozitionProdTable, facturacontent.IndexOf(lastPozitionProdTable) - firstPozitionProdTable);
            List<string> pruductTableData = productsElemet(tabelData);
            /**************************************/
            float vertycalLastPozition = 0;
            /**************************************/
            /****************************************Create factura pdf *********************************************************/
            string pdfpath = "factura.pdf";
            using (PdfWriter writer = new PdfWriter(pdfpath))
            { 
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf, PageSize.A4);
                document.SetMargins(30f, 30f, 30f, 30f);
                string fontPath2 = @"C:\Windows\Fonts\arial.ttf";
                PdfFont f = PdfFontFactory.CreateFont(fontPath2, PdfFontFactory.EmbeddingStrategy.PREFER_EMBEDDED);
        /*************************************************** Title and logo *********************************************************/
                Table mainTable = new Table(2);
                float tableHeight = 80;
                vertycalLastPozition += tableHeight;

                float tableWidth = PageSize.A4.GetWidth() - 60;
                mainTable.SetWidth(tableWidth);
                mainTable.SetHeight(tableHeight);
                Image image = new Image(ImageDataFactory.Create("../../Resources/image/poltherm_logo.png"));
                Cell cell1 = new Cell().SetWidth(tableWidth / 2.0f - 50).SetBorder(Border.NO_BORDER);
                cell1.Add(image.SetAutoScale(true));
                mainTable.AddCell(cell1);

                Table secondTable = new Table(1);
                secondTable.SetWidth(tableWidth / 2.0f + 45);
                secondTable.SetHeight(tableHeight);
                secondTable.SetBorderCollapse(BorderCollapsePropertyValue.COLLAPSE);
                int font = 15;
                Text factura = new Text("FACTURA").SetFontColor(DeviceRgb.WHITE).SetBold().SetFont(f).SetFontSize(font);
                Text Pfs = new Text("PSF" + necessaryDatas[0]).SetFontColor(DeviceRgb.WHITE).SetBold().SetFont(f).SetFontSize(font);


                Table tab2 = new Table(2);
                tab2.SetWidth(secondTable.GetWidth().GetValue() - 5);
                Cell facturas = new Cell().Add(new Paragraph(factura).SetTextAlignment(TextAlignment.LEFT)).SetBorder(Border.NO_BORDER);
                tab2.AddCell(facturas);
                Cell pfs = new Cell().Add(new Paragraph(Pfs).SetTextAlignment(TextAlignment.RIGHT)).SetBorder(Border.NO_BORDER);
                tab2.AddCell(pfs);

                Cell cell2_1 = new Cell().Add(tab2)
                                          .SetHeight(tableHeight / 2 - 15);

                cell2_1.SetBorder(Border.NO_BORDER);
                cell2_1.SetBackgroundColor(DeviceRgb.RED).SetBorder(Border.NO_BORDER);
                secondTable.AddCell(cell2_1);
                int k = 10;
                Text t1 = new Text("Data emiterii: ").SetBold().SetFont(f).SetFontSize(k);
                Text t2 = new Text(necessaryDatas[1]).SetFontSize(k);
                Text t3 = new Text(" TVA la incasare ").SetBold().SetFont(f).SetFontSize(k);
                Text t4 = new Text("(" + necessaryDatas[2] + ")").SetFontSize(k);
                Text t5 = new Text("Termen plata: ").SetBold().SetFont(f).SetFontSize(k);
                Text t6 = new Text(necessaryDatas[3]).SetFontSize(k);

                Paragraph a = new Paragraph().Add(t1)
                                              .Add(t2)
                                              .Add(t3)
                                              .Add(t4);
                Paragraph b = new Paragraph().Add(t5)
                                              .Add(t6);



                Cell cell2_2 = new Cell().Add(a).Add(b);
                cell2_2.SetBorder(Border.NO_BORDER);
                cell2_2.SetHeight(tableHeight / 2 + 15);

                secondTable.AddCell(cell2_2);

                Cell cell2 = new Cell().Add(secondTable);
                cell2.SetBorder(Border.NO_BORDER);
                mainTable.AddCell(cell2);
                document.Add(mainTable);


        /*************************************************** buyer and seller data *********************************************************/
                Table bstable = new Table(2);
                bstable.SetWidth(tableWidth);
                bstable.SetHeight(180); // buyer and seller TABLE HEIGHT
                vertycalLastPozition += 180;
                Text fur = new Text("Furnizor: ").SetBold().SetFont(f).SetFontSize(8);
                Text name = new Text("POLTHERM SYSTEM SRL").SetBold().SetFont(f).SetFontSize(10);
                Paragraph furname = new Paragraph().Add(fur);
                Paragraph namePar = new Paragraph().Add(name);
                Cell seller = new Cell().Add(furname)
                                        .Add(namePar)
                                        .SetWidth(bstable.GetWidth().GetValue() / 2f)
                                        .SetBorder(Border.NO_BORDER);
                Text client = new Text("Client: ").SetBold().SetFont(f).SetFontSize(8);
                Text clientname = new Text(data.Name).SetBold().SetFont(f).SetFontSize(10);
                Paragraph clie = new Paragraph().Add(client);
                Paragraph nameClien = new Paragraph().Add(clientname);
                Cell buyer = new Cell().Add(clie)
                                        .Add(nameClien)
                                        .SetBorder(Border.NO_BORDER);

        /*************************************************** seller table *********************************************************/
                Table selerData = new Table(2);
                selerData.SetWidth(bstable.GetWidth().GetValue() / 2.0f).SetBorder(Border.NO_BORDER);

                Cell listed = new Cell().SetWidth(TeklaData[18].Length + 40).SetBorder(Border.NO_BORDER);
                for (int i = 0; i < TeklaData.Length - 1; i += 2)
                {
                    if (i == 6)
                    {

                        listed.Add(new Paragraph().Add(new Text("\n").SetBold().SetFont(f).SetFontSize(8)));
                    }
                    else if (i != 20)
                    {
                        listed.Add(new Paragraph(TeklaData[i]).SetBold().SetFont(f).SetFontSize(8));
                    }
                    else
                    {
                        listed.Add(new Paragraph(TeklaData[i]).SetFont(f).SetFontSize(8));
                    }

                }

                Cell teklaData = new Cell().SetBorder(Border.NO_BORDER);
                for (int i = 1; i < TeklaData.Length; i += 2)
                {
                    if (i == 5)
                    {

                        teklaData.Add(new Paragraph(TeklaData[i] + " " + TeklaData[i + 1]).SetFont(f).SetFontSize(8));
                    }
                    else
                    {
                        teklaData.Add(new Paragraph(TeklaData[i]).SetFont(f).SetFontSize(8));
                    }

                }

                selerData.AddCell(listed)
                         .AddCell(teklaData);
                Cell sellerDate = new Cell().Add(selerData).SetBorder(Border.NO_BORDER);

        /*************************************************** Buyer table *********************************************************/
                Table buyerData = new Table(2);
                buyerData.SetWidth(bstable.GetWidth().GetValue() / 2.0f - 8).SetKeepTogether(true)
                    .SetWidth(bstable.GetWidth().GetValue() / 2.0f - 8)
                    .SetMarginBottom(0)
                    .SetMarginTop(0)
                    .SetMarginRight(0)
                    .SetMarginLeft(0)
                    .SetPadding(0)
                    .SetBorder(Border.NO_BORDER);

                int cellcount = (data.CountNonEmptyFields() - 1) * 2;
                List<Cell> cells = new List<Cell>();
                for (int i = 0; i < cellcount; i++)
                {
                    if (0 == i % 2)
                    {
                        cells.Add(new Cell().SetBorder(Border.NO_BORDER).SetWidth(50).SetMarginTop(0)
                                                                        .SetMarginBottom(0)
                                                                        .SetPaddingTop(0)
                                                                        .SetPaddingBottom(0));
                    }
                    else
                    {
                        cells.Add(new Cell().SetBorder(Border.NO_BORDER).SetMarginTop(0)
                                                .SetMarginBottom(0)
                                                .SetPaddingTop(0)
                                                .SetPaddingBottom(0));
                    }

                }
                List<string> list = data.GetNonEmptyFields();
                for (int i = 0, j = 2; i < cellcount; i++, j++)
                {
                    if ((i & 1) == 0)
                    {
                        cells[i].Add(new Paragraph().Add(new Text(list[j]).SetBold().SetFont(f).SetFontSize(8)));
                    }
                    else
                    {
                        cells[i].Add(new Paragraph(list[j]).SetFont(f).SetFontSize(8));
                    }

                }
                foreach (Cell cell in cells)
                {
                    buyerData.AddCell(cell);
                }
                Cell buyerDate = new Cell().Add(buyerData).SetBorder(Border.NO_BORDER);

                bstable.SetWidth(tableWidth)
                        .AddCell(seller)
                        .AddCell(buyer)
                        .AddCell(sellerDate)
                        .AddCell(buyerDate);


                document.Add(bstable);

                /****************************************************Products Tabel*********************************************************************************/
                Table productstable = new Table(7);

                productstable.SetWidth(tableWidth);


                /**********************************Titel Rows Product Table****************************************************************************************/
                int sizep = 10;
                Cell cellp1 = new Cell().Add(new Paragraph(" Nr. ").SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetFont(f).SetFontSize(sizep).SetBold().SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER);
                Cell cellp2 = new Cell().Add(new Paragraph("Denumire produs/serviciu").SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetFont(f).SetFontSize(sizep).SetBold().SetTextAlignment(TextAlignment.LEFT).SetBorder(Border.NO_BORDER);
                Cell cellp3 = new Cell().Add(new Paragraph(" U.M. ").SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetFont(f).SetFontSize(sizep).SetBold().SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER);
                Cell cellp4 = new Cell().Add(new Paragraph(" Cant. ").SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetFont(f).SetFontSize(sizep).SetBold().SetTextAlignment(TextAlignment.CENTER).SetBorder(Border.NO_BORDER);
                Text t11 = new Text(" Pret unitar\r\n ").SetFont(f).SetFontSize(sizep).SetBold();
                Text t21 = new Text(" (RON fara TVA) ").SetFont(f).SetFontSize(8).SetBold();
                Cell cellp5 = new Cell().SetWidth(60).Add(new Paragraph().Add(t11).Add(t21).SetTextAlignment(TextAlignment.RIGHT).SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetBorder(Border.NO_BORDER);
                Text t111 = new Text("Valoare\r\n ").SetFont(f).SetFontSize(sizep).SetBold();
                Text t211 = new Text(" (RON) ").SetFont(f).SetFontSize(8).SetBold();
                Cell cellp6 = new Cell().Add(new Paragraph().Add(t111).Add(t211).SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetFont(f).SetFontSize(sizep).SetBold().SetTextAlignment(TextAlignment.RIGHT).SetBorder(Border.NO_BORDER);
                Text t60 = new Text("TVA \r\n").SetFont(f).SetFontSize(sizep).SetBold();
                Text t61 = new Text(" (RON) ").SetFont(f).SetFontSize(8).SetBold();
                Cell cellp7 = new Cell().Add(new Paragraph().Add(t60).Add(t61).SetFontColor(DeviceRgb.WHITE)).SetBackgroundColor(DeviceRgb.RED).SetFont(f).SetFontSize(sizep).SetBold().SetTextAlignment(TextAlignment.RIGHT).SetBorder(Border.NO_BORDER);
                productstable.AddCell(cellp1)
                             .AddCell(cellp2)
                             .AddCell(cellp3)
                             .AddCell(cellp4)
                             .AddCell(cellp5)
                             .AddCell(cellp6)
                             .AddCell(cellp7);

                /***********************************Products Rows Genered Tabel********************************************************************************************/
                for(int i = 0;i<pruductTableData.Count()-2;i++)
                {
                    string[] s = pruductTableData[i].Split('*');
                    for(int j = 0;j<s.Length-1;j++)
                    {
                        switch(j)
                        {
                            case 0:
                            case 2:
                            case 3:
                                Cell cellCenter = new Cell()
                                    .Add(new Paragraph(s[j]).SetFont(f).SetFontSize(8))
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                                    .SetBorder(Border.NO_BORDER);
                                productstable.AddCell(cellCenter);
                                break;
                            case 1:
                                Cell cellCenterWidth = new Cell()
                                    .Add(new Paragraph(s[j]).SetFont(f).SetFontSize(8))
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                                   .SetBorder(Border.NO_BORDER)
                                   ;
                                productstable.AddCell(cellCenterWidth);
                                break;
                            default:
                                Cell cellRight = new Cell()
                                    .Add(new Paragraph(s[j]).SetFont(f).SetFontSize(8))
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                                   .SetBorder(Border.NO_BORDER);
                                productstable.AddCell(cellRight);
                                break;
                        }
                    }
                }
                string[] subTotal = pruductTableData[pruductTableData.Count()-2].Split('*');
                Cell subtotal = new Cell().Add(new Paragraph(subTotal[0]+':').SetFont(f).SetFontSize(10))
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetBorder(Border.NO_BORDER);
                Cell subtotalValue1 = new Cell().Add(new Paragraph(subTotal[1]).SetFont(f).SetFontSize(8))
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT).SetBorder(Border.NO_BORDER);
                Cell subtotalValue2 = new Cell().Add(new Paragraph(subTotal[2]).SetFont(f).SetFontSize(8))
                                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT).SetBorder(Border.NO_BORDER);
                productstable.AddCell(new Cell(1,4).SetBorder(Border.NO_BORDER));
                productstable.AddCell(subtotal);
                productstable.AddCell(subtotalValue1);
                productstable.AddCell(subtotalValue2);
                string[] totalV= pruductTableData[pruductTableData.Count()-1].Split('*');

                Cell total = new Cell().Add(new Paragraph(totalV[0]+':').SetFont(f).SetFontSize(11))
                                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                                            .SetBold()
                                            .SetBorder(Border.NO_BORDER)
                                            ;
                Cell totalValue= new Cell(1,2).Add(new Paragraph(totalV[1]).SetFont(f).SetFontSize(11))
                                            .SetBold()
                                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.RIGHT)
                                            .SetBorder(Border.NO_BORDER)
                                            ;
                productstable.AddCell(new Cell(1,4).SetBorder(Border.NO_BORDER));
                productstable.AddCell(total);
                productstable.AddCell(totalValue);
                document.Add(productstable).SetBorder(Border.NO_BORDER);
                LayoutResult result = productstable.CreateRendererSubTree().SetParent(document.GetRenderer()).Layout(
                new LayoutContext(new LayoutArea(1,new Rectangle(0,0,400,1e4f))));
                vertycalLastPozition+=(int)result.GetOccupiedArea().GetBBox().GetHeight()+1;
                /************************************************************Marfa ramane********************************************************/
                if(lastPozitionProdTable.Equals("Marfa"))
                {
                    string marfa = "Marfa ramane in proprietatea Furnizorului pana la achitarea integrala a contravalorii Facturii. Firma POLTHERM SYSTEM SRL aplica prevederile cf. L227/2015, privind Codul fiscal - articolul 319, alineatul 29, conform caruia semnarea si stampilarea facturilor nu sunt obligatorii.";
                    Text marfaText = new Text(marfa).SetFont(f).SetFontSize(8);
                    Paragraph marfaParagraph = new Paragraph(marfaText);
                    document.Add(marfaParagraph);
                    LayoutResult paragrafsize = marfaParagraph.CreateRendererSubTree().SetParent(document.GetRenderer()).Layout(new LayoutContext(new LayoutArea(1,new Rectangle(1000,1000))));
                    vertycalLastPozition+=(int)result.GetOccupiedArea().GetBBox().GetHeight()+1;
                }
                float paddingValue = 10f;
                Table lastFacturaTabel = new Table(3)
                                            .SetPadding(paddingValue)
                                            .SetBorder(new SolidBorder(DeviceRgb.RED,1.5F))
                                            .SetWidth(tableWidth);
                

                Cell cell19 = new Cell()
                                .Add(new Paragraph("Intocmit de:").SetFontSize(9).SetFont(f).SetBold())
                                .Add(new Paragraph("-\nCNP: -").SetFontSize(9).SetFont(f))
                                .SetBorder(Border.NO_BORDER);
                lastFacturaTabel.AddCell(cell19);

                Cell cell29 = new Cell()
                    .Add(new Paragraph("Date privind expeditia:").SetFontSize(9).SetFont(f).SetBold())
                    .Add(new Paragraph("Numele delegatului: ONLINE - controler-e.ro, CI: -. -. Expediere la data de .........., ora ....").SetFontSize(9).SetFont(f))
                    .SetBorder(Border.NO_BORDER);
                lastFacturaTabel.AddCell(cell29);

                Cell cell3 = new Cell()
                    .Add(new Paragraph("Semnatura de primire:").SetFontSize(9).SetFont(f).SetBold())
                    .SetBorder(Border.NO_BORDER);
                lastFacturaTabel.AddCell(cell3);
                
                document.Add(lastFacturaTabel);

                /*************************************************** Pdfclosing********************************************************************************************/
                pdf.Close();
            }
        }
        private static string cliensdata(string text)
        {
            for (int i = 0; i < TeklaData.Length - 1; i += 2)
            {
                text = text.Replace(TeklaData[i] + TeklaData[i + 1], "");
            }
            return text;
        }
        private static CliensDataTabel ExtractTabelData(string text)
        {
            CliensDataTabel data = new CliensDataTabel();
            int lastIndexName = text.IndexOf("\n");
            text = text.Replace("\n", " ");
            data.Name = text.Substring(0, lastIndexName);
            text = RemoveExtraSpaces(text);
            string input = text.Substring(lastIndexName).Trim();
            string[] words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == "Reg." || words[i] == "Reg. com.:" || words[i] == "Reg.com.:")
                {
                    if (words[i] == "Reg.")
                    {
                        data.RegNumber = words[i + 2];
                    }
                    else
                    {
                        data.RegNumber = words[i + 1];
                    }


                }
                else if (words[i] == "CIF:")
                {
                    data.CIF = words[i + 1];
                }
                else if (words[i] == "Adresa:")
                {
                    string address = "";
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[j].EndsWith(":"))
                        {
                            break;
                        }
                        address += words[j] + " ";
                    }
                    data.Address = address.Trim();
                }
                else if (words[i] == "IBAN:")
                {
                    data.IBan1 = words[i + 1];
                }
                else if (words[i] == "Tel.:")
                {
                    data.Tel = words[i + 1];
                }
                else if (words[i] == "Email:")
                {
                    data.Email = words[i + 1];
                }
                else if (words[i] == "Website:")
                {
                    data.Website = words[i + 1];
                }
                else if (words[i] == "Banca:")
                {
                    data.Banka = words[i + 1];
                }
                else if (words[i] == "Tara:")
                {
                    data.Tara = words[i + 1];
                }
                else if (words[i] == "Judet:")
                {
                    string judet = "";
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[j].EndsWith(":"))
                        {
                            break;
                        }
                        judet += words[j] + " ";
                    }
                    data.Judet = judet.Trim();
                }
            }

            return data;
        }
        private static string RemoveExtraSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ");
        }
        private static string[] necessaryDateSearch(string text)
        {
            string[] dates = new string[necessaryDatesNumber];
            string[] regexExpression = {
                                        @"Factura PSF (\d+)",
                                        @"Data emiterii: (\d{2}.\d{2}.\d{4})",
                                        @"TVA la incasare \(([^)]+)\)",
                                        @"Termen plata: (.+)"
            };
            for (int i = 0; i < necessaryDatesNumber; i++)
            {
                dates[i] = ExtractUsingRegex(regexExpression[i], text);
            }
            return dates;
        }
        private static string ExtractUsingRegex(string regex, string sources)
        {
            Match match = Regex.Match(sources, regex);
            return match.Success ? match.Groups[1].Value.Trim() : null;
        }
        private static List<string> productsElemet(string text)
        {
            List<string> productList = new List<string>();
            List<string> a = text.Split('\n').Select(s=>s.Trim()).ToList();
            a.RemoveAll(s => string.IsNullOrWhiteSpace(s));
            Regex minta = new Regex(@"^\d+\s\w+");
           
            for (int i = 0; i < a.Count - 2; i++)
            {
                if (minta.IsMatch(a[i]) && !minta.IsMatch(a[i+1]) && !a[i+1].Contains("Subtotal"))
                { int bucIndex= a[i].IndexOf("BUC");
                    if (bucIndex == -1)
                    {
                        bucIndex = a[i].IndexOf("buc");
                    }
                    string second = a[i].Substring(bucIndex);
                    string first = a[i].Substring(0, bucIndex);
                    
                    while (!minta.IsMatch(a[i+1]))
                    {
                        first += a[i+1];
                      
                        i++;
                    }
                      
                       productList.Add(addAsterisks(first+" "+second));
                    
                }
                else if(minta.IsMatch(a[i]))
                {
                    productList.Add(addAsterisks(a[i]));
                }
            }
            productList.Add(a[a.Count - 2].Replace(" ","*"));
            productList.Add(a[a.Count - 1].Replace("plata","plata*"));
            
            return productList;
        }
        private static string addAsterisks(string input)
        {
            string felezo=null;
            if(input.Contains("BUC"))
            {
                felezo="BUC";
            }else if(input.Contains("buc"))
            {
                felezo="buc";
            }else if(input.Contains("ML"))
            {
                felezo="ML";
            }
            string pattern = @"(\d+ )";
            string help = input.Substring(0,5);
            string help2 = input.Substring(5);
            string result = Regex.Replace(help,pattern,"$1*");
            result+=help2;

            result=result.Replace(felezo,"*"+felezo+"*");
            int indexbux=result.IndexOf(felezo);
            if(indexbux==-1)
            {
                indexbux=result.IndexOf(felezo);
            }
            string subBUC = result.Substring(indexbux);
            subBUC=Regex.Replace(subBUC,@"(\d+\.?\d*)\s*","$1*");
            result=result.Substring(0,indexbux)+subBUC;
            return result;
        }
    }
} 