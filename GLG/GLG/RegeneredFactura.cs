using Org.BouncyCastle.Asn1.X500;
using System;
using static QuestPDF.Helpers.Colors;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using static iText.Kernel.Pdf.Colorspace.PdfSpecialCs;
using static Org.BouncyCastle.Utilities.Test.FixedSecureRandom;

namespace GLG
{
    internal class RegeneredFactura
    {
        private const int necessaryDatesNumber=4;   
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
            string cliensData = facturacontent.Substring(facturacontent.IndexOf("POLTHERM SYSTEM SRL ") +19);
            CliensDataTabel data = new CliensDataTabel( ExtractTabelData(cliensdata(cliensData.Substring(0, cliensData.IndexOf("Pret unitar Valoare TVA")))));
            string[] necessaryDatas = necessaryDateSearch(facturacontent.Substring(0, facturacontent.IndexOf("Furnizor:")));
            

        }

        private static string cliensdata(string text)
        {
            for (int i = 0; i < TeklaData.Length-1;i+=2 )
            {
                text=text.Replace(TeklaData[i] + TeklaData[i + 1], "");
            }
            return text;
        }
       private static CliensDataTabel ExtractTabelData(string text)
        {
            CliensDataTabel data = new CliensDataTabel();
            int lastIndexName = text.IndexOf("\n");
            text = text.Replace("\n", " ");
            data.Name = text.Substring(0, lastIndexName);
            text=RemoveExtraSpaces(text);
            string input =text.Substring(lastIndexName).Trim();
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
                }else if (words[i] == "Tara:")
                {
                    data.Tara = words[i + 1];
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
            Match match = Regex.Match(sources,regex);
            return match.Success ? match.Groups[1].Value.Trim() : null;
        }
    }
}