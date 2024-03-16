namespace GLG
{
    partial class FormSecondPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxLastsize = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tbxWhiteSpase = new System.Windows.Forms.TextBox();
            this.cbxTloc = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbxTsize = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.tbxLastsize);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.tbxWhiteSpase);
            this.panel1.Controls.Add(this.cbxTloc);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.tbxTsize);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(240, 2000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 767);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(0, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxLastsize
            // 
            this.tbxLastsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxLastsize.Location = new System.Drawing.Point(70, 339);
            this.tbxLastsize.Name = "tbxLastsize";
            this.tbxLastsize.Size = new System.Drawing.Size(97, 27);
            this.tbxLastsize.TabIndex = 9;
            this.tbxLastsize.Text = "10";
            this.tbxLastsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxLastsize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLastsize_KeyPress);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Red;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox7.Location = new System.Drawing.Point(4, 310);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(227, 23);
            this.textBox7.TabIndex = 8;
            this.textBox7.Text = "Utolsó mondat mérete";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxWhiteSpase
            // 
            this.tbxWhiteSpase.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxWhiteSpase.Location = new System.Drawing.Point(70, 277);
            this.tbxWhiteSpase.Name = "tbxWhiteSpase";
            this.tbxWhiteSpase.Size = new System.Drawing.Size(97, 27);
            this.tbxWhiteSpase.TabIndex = 7;
            this.tbxWhiteSpase.Text = "4";
            this.tbxWhiteSpase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxWhiteSpase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxWhiteSpase_KeyPress);
            // 
            // cbxTloc
            // 
            this.cbxTloc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxTloc.FormattingEnabled = true;
            this.cbxTloc.Items.AddRange(new object[] {
            "Közép",
            "Bal szél"});
            this.cbxTloc.Location = new System.Drawing.Point(70, 189);
            this.cbxTloc.Name = "cbxTloc";
            this.cbxTloc.Size = new System.Drawing.Size(97, 28);
            this.cbxTloc.TabIndex = 6;
            this.cbxTloc.Text = "Közép";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Red;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox6.Location = new System.Drawing.Point(4, 223);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(230, 58);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Bekezdések mérete kettőspont után pixelben megadva";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Red;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(4, 151);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(230, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Cím elhelyezése";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTsize
            // 
            this.tbxTsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbxTsize.Location = new System.Drawing.Point(70, 118);
            this.tbxTsize.Name = "tbxTsize";
            this.tbxTsize.Size = new System.Drawing.Size(97, 27);
            this.tbxTsize.TabIndex = 2;
            this.tbxTsize.Text = "10";
            this.tbxTsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxTsize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTsize_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Red;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(6, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(228, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Cím mérete";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(230, 72);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GLG.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(230, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(558, 1902);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(558, 1855);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Garancia feltételek";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.AutoScroll = true;
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer1.FormFillEnabled = false;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(934, 137);
            this.pdfDocumentViewer1.MultiPagesThreshold = 60;
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.OnRenderPageExceptionEvent = null;
            this.pdfDocumentViewer1.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous;
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(176, 299);
            this.pdfDocumentViewer1.TabIndex = 2;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage;
            this.pdfDocumentViewer1.ZoomFactor = 1F;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // FormSecondPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1248, 767);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSecondPage";
            this.Text = "FormSecondPage";
            this.Load += new System.EventHandler(this.FormSecondPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbxTsize;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbxTloc;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox tbxWhiteSpase;
        private System.Windows.Forms.TextBox tbxLastsize;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}