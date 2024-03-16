
using System.Windows.Forms;

namespace GLG
{
    partial class FormFirstPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBxTitle = new System.Windows.Forms.TextBox();
            this.tBxSubTit = new System.Windows.Forms.TextBox();
            this.tBxFirst = new System.Windows.Forms.TextBox();
            this.tBxSecond = new System.Windows.Forms.TextBox();
            this.tBxThird = new System.Windows.Forms.TextBox();
            this.tBxFive_four = new System.Windows.Forms.TextBox();
            this.tBxFootSecond = new System.Windows.Forms.TextBox();
            this.tBxFootThird = new System.Windows.Forms.TextBox();
            this.tBxFootFourth = new System.Windows.Forms.TextBox();
            this.tBxFootLast = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.tBxFootnote = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.AutoScroll = true;
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer1.FormFillEnabled = false;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(804, 23);
            this.pdfDocumentViewer1.MultiPagesThreshold = 60;
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.OnRenderPageExceptionEvent = null;
            this.pdfDocumentViewer1.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous;
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(358, 514);
            this.pdfDocumentViewer1.TabIndex = 13;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage;
            this.pdfDocumentViewer1.ZoomFactor = 1F;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 720);
            this.panel2.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(0, 558);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(294, 46);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Mentés";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(0, 514);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(294, 44);
            this.label12.TabIndex = 11;
            this.label12.Text = "Utolsó sor";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(0, 470);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(294, 44);
            this.label11.TabIndex = 10;
            this.label11.Text = "Negyedik sor";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Red;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(0, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(294, 44);
            this.label10.TabIndex = 9;
            this.label10.Text = "Harmadik sor";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Red;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 44);
            this.label9.TabIndex = 8;
            this.label9.Text = "Második sor";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Red;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(0, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(294, 44);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lábjegyzet első sor";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(294, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "Negyedik és ötödik sor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Harmadik sor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 44);
            this.label4.TabIndex = 3;
            this.label4.Text = "Második sor";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vonal alatti első sor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alcím";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cím";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Red;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 74);
            this.panel3.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GLG.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 74);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.textBox1.Location = new System.Drawing.Point(337, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(402, 56);
            this.textBox1.TabIndex = 14;
            // 
            // tBxTitle
            // 
            this.tBxTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxTitle.Location = new System.Drawing.Point(294, 74);
            this.tBxTitle.Multiline = true;
            this.tBxTitle.Name = "tBxTitle";
            this.tBxTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxTitle.Size = new System.Drawing.Size(448, 45);
            this.tBxTitle.TabIndex = 15;
            // 
            // tBxSubTit
            // 
            this.tBxSubTit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxSubTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxSubTit.Location = new System.Drawing.Point(294, 119);
            this.tBxSubTit.Multiline = true;
            this.tBxSubTit.Name = "tBxSubTit";
            this.tBxSubTit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxSubTit.Size = new System.Drawing.Size(448, 45);
            this.tBxSubTit.TabIndex = 16;
            // 
            // tBxFirst
            // 
            this.tBxFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFirst.Location = new System.Drawing.Point(294, 164);
            this.tBxFirst.Multiline = true;
            this.tBxFirst.Name = "tBxFirst";
            this.tBxFirst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFirst.Size = new System.Drawing.Size(448, 45);
            this.tBxFirst.TabIndex = 17;
            // 
            // tBxSecond
            // 
            this.tBxSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxSecond.Location = new System.Drawing.Point(294, 209);
            this.tBxSecond.Multiline = true;
            this.tBxSecond.Name = "tBxSecond";
            this.tBxSecond.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxSecond.Size = new System.Drawing.Size(448, 45);
            this.tBxSecond.TabIndex = 18;
            // 
            // tBxThird
            // 
            this.tBxThird.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxThird.Location = new System.Drawing.Point(294, 254);
            this.tBxThird.Multiline = true;
            this.tBxThird.Name = "tBxThird";
            this.tBxThird.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxThird.Size = new System.Drawing.Size(448, 45);
            this.tBxThird.TabIndex = 19;
            // 
            // tBxFive_four
            // 
            this.tBxFive_four.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFive_four.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFive_four.Location = new System.Drawing.Point(294, 299);
            this.tBxFive_four.Multiline = true;
            this.tBxFive_four.Name = "tBxFive_four";
            this.tBxFive_four.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFive_four.Size = new System.Drawing.Size(448, 45);
            this.tBxFive_four.TabIndex = 20;
            // 
            // tBxFootSecond
            // 
            this.tBxFootSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFootSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFootSecond.Location = new System.Drawing.Point(294, 389);
            this.tBxFootSecond.Multiline = true;
            this.tBxFootSecond.Name = "tBxFootSecond";
            this.tBxFootSecond.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFootSecond.Size = new System.Drawing.Size(448, 45);
            this.tBxFootSecond.TabIndex = 21;
            // 
            // tBxFootThird
            // 
            this.tBxFootThird.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFootThird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFootThird.Location = new System.Drawing.Point(294, 434);
            this.tBxFootThird.Multiline = true;
            this.tBxFootThird.Name = "tBxFootThird";
            this.tBxFootThird.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFootThird.Size = new System.Drawing.Size(448, 45);
            this.tBxFootThird.TabIndex = 22;
            // 
            // tBxFootFourth
            // 
            this.tBxFootFourth.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFootFourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFootFourth.Location = new System.Drawing.Point(294, 479);
            this.tBxFootFourth.Multiline = true;
            this.tBxFootFourth.Name = "tBxFootFourth";
            this.tBxFootFourth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFootFourth.Size = new System.Drawing.Size(448, 45);
            this.tBxFootFourth.TabIndex = 23;
            // 
            // tBxFootLast
            // 
            this.tBxFootLast.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFootLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFootLast.Location = new System.Drawing.Point(294, 524);
            this.tBxFootLast.Multiline = true;
            this.tBxFootLast.Name = "tBxFootLast";
            this.tBxFootLast.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFootLast.Size = new System.Drawing.Size(448, 45);
            this.tBxFootLast.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tBxFootLast);
            this.panel1.Controls.Add(this.tBxFootFourth);
            this.panel1.Controls.Add(this.tBxFootThird);
            this.panel1.Controls.Add(this.tBxFootSecond);
            this.panel1.Controls.Add(this.tBxFootnote);
            this.panel1.Controls.Add(this.tBxFive_four);
            this.panel1.Controls.Add(this.tBxThird);
            this.panel1.Controls.Add(this.tBxSecond);
            this.panel1.Controls.Add(this.tBxFirst);
            this.panel1.Controls.Add(this.tBxSubTit);
            this.panel1.Controls.Add(this.tBxTitle);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(742, 720);
            this.panel1.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(294, 569);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(448, 46);
            this.label13.TabIndex = 27;
            this.label13.Text = "Fontos!! Csak a meglévő sorok szerkesztése lehetséges, új sor hozzáadása hibát ok" +
    "ozhat a programban!!!";
            // 
            // tBxFootnote
            // 
            this.tBxFootnote.Dock = System.Windows.Forms.DockStyle.Top;
            this.tBxFootnote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.tBxFootnote.Location = new System.Drawing.Point(294, 344);
            this.tBxFootnote.Multiline = true;
            this.tBxFootnote.Name = "tBxFootnote";
            this.tBxFootnote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBxFootnote.Size = new System.Drawing.Size(448, 45);
            this.tBxFootnote.TabIndex = 26;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(294, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(448, 74);
            this.panel5.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 74);
            this.label7.TabIndex = 0;
            this.label7.Text = "Módosítható adatok";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1403, 720);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "FormFirstPage";
            this.Text = "FormFirstpage";
            this.Load += new System.EventHandler(this.FormFirstPage_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private Panel panel2;
        private Button btnSave;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private TextBox tBxTitle;
        private TextBox tBxSubTit;
        private TextBox tBxFirst;
        private TextBox tBxSecond;
        private TextBox tBxThird;
        private TextBox tBxFive_four;
        private TextBox tBxFootSecond;
        private TextBox tBxFootThird;
        private TextBox tBxFootFourth;
        private TextBox tBxFootLast;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel5;
        private TextBox tBxFootnote;
        private Label label7;
        private Label label13;
    }
}