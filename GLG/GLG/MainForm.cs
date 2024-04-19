using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GLG
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender,EventArgs e)
        {
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;


            pictureBox1.Location=new Point((formWidth-pictureBox1.Width)/2,30);

            label1.Size=label2.Size;
            label1.Location=new Point(formWidth/4-label1.Width/2,pictureBox1.Bottom+35);
            label2.Location=new Point(formWidth/4*3-label2.Width/2,label1.Top);

            separately.Size=into_one.Size;
            int buttonTop = label1.Bottom+5;
            separately.Location=new Point(label1.Left+label1.Width/2-separately.Width/2,buttonTop);
            into_one.Location=new Point(label2.Left+label2.Width/2-separately.Width/2,buttonTop);

            string filePath = @"Resources\\SourcesFiles\\ConstData.txt";
            string filePath1 = @"Resources\\SourcesFiles\\firstpage.pdf";
            string filePath2 = @"Resources\\SourcesFiles\\secondpage.pdf";
            string filePath3 = @".//Resources\\SourcesFiles\\clear.pdf";

            try
            {
                // Ellenőrizzük, hogy a fájl létezik-e
                if(File.Exists(filePath)&&File.Exists(filePath1)&&File.Exists(filePath2)&&File.Exists(filePath3))
                {
                    // Az összes engedély hozzáadása a fájlhoz
                    File.SetAttributes(filePath,File.GetAttributes(filePath)&~FileAttributes.ReadOnly);
                    File.SetAttributes(filePath1,File.GetAttributes(filePath1)&~FileAttributes.ReadOnly);
                    File.SetAttributes(filePath2,File.GetAttributes(filePath2)&~FileAttributes.ReadOnly);
                    File.SetAttributes(filePath3,File.GetAttributes(filePath3)&~FileAttributes.ReadOnly);
                }
                else
                {
                    MessageBox.Show("A fájl nem létezik.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Hiba történt: {ex.Message}");
            }

        }

        private void separately_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void into_one_Click(object sender, EventArgs e)
        {
            Hide();
            Into_one into_One = new Into_one();
            into_One.Show();
        }
    }
}
