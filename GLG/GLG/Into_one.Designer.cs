namespace GLG
{
    partial class Into_one
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Into_one));
            this.panel1 = new System.Windows.Forms.Panel();
            this.printing_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.automatic_operation_chekbox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.autoPrint = new System.Windows.Forms.CheckBox();
            this.saveButtom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.saveButtom);
            this.panel1.Controls.Add(this.autoPrint);
            this.panel1.Controls.Add(this.printing_button);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.automatic_operation_chekbox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 572);
            this.panel1.TabIndex = 0;
            // 
            // printing_button
            // 
            this.printing_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printing_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.printing_button.FlatAppearance.BorderSize = 0;
            this.printing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printing_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printing_button.Location = new System.Drawing.Point(0, 240);
            this.printing_button.Name = "printing_button";
            this.printing_button.Size = new System.Drawing.Size(232, 76);
            this.printing_button.TabIndex = 4;
            this.printing_button.Text = "Nyomtatás";
            this.printing_button.UseVisualStyleBackColor = false;
            this.printing_button.Click += new System.EventHandler(this.printing_button_Click);
            // 
            // search_button
            // 
            this.search_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_button.FlatAppearance.BorderSize = 0;
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Location = new System.Drawing.Point(0, 164);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(232, 76);
            this.search_button.TabIndex = 3;
            this.search_button.Text = "Keresés";
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // automatic_operation_chekbox
            // 
            this.automatic_operation_chekbox.Appearance = System.Windows.Forms.Appearance.Button;
            this.automatic_operation_chekbox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.automatic_operation_chekbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.automatic_operation_chekbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.automatic_operation_chekbox.FlatAppearance.BorderSize = 0;
            this.automatic_operation_chekbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.automatic_operation_chekbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automatic_operation_chekbox.Location = new System.Drawing.Point(0, 89);
            this.automatic_operation_chekbox.Name = "automatic_operation_chekbox";
            this.automatic_operation_chekbox.Size = new System.Drawing.Size(232, 75);
            this.automatic_operation_chekbox.TabIndex = 2;
            this.automatic_operation_chekbox.Text = "Auto. működés";
            this.automatic_operation_chekbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.automatic_operation_chekbox.UseVisualStyleBackColor = true;
            this.automatic_operation_chekbox.CheckedChanged += new System.EventHandler(this.automatic_operation_chekbox_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GLG.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 89);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pdfDocumentViewer1
            // 
            this.pdfDocumentViewer1.AutoScroll = true;
            this.pdfDocumentViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer1.FormFillEnabled = false;
            this.pdfDocumentViewer1.Location = new System.Drawing.Point(352, 127);
            this.pdfDocumentViewer1.MultiPagesThreshold = 60;
            this.pdfDocumentViewer1.Name = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.OnRenderPageExceptionEvent = null;
            this.pdfDocumentViewer1.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous;
            this.pdfDocumentViewer1.Size = new System.Drawing.Size(188, 216);
            this.pdfDocumentViewer1.TabIndex = 1;
            this.pdfDocumentViewer1.Text = "pdfDocumentViewer1";
            this.pdfDocumentViewer1.Threshold = 60;
            this.pdfDocumentViewer1.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage;
            this.pdfDocumentViewer1.ZoomFactor = 1F;
            this.pdfDocumentViewer1.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // autoPrint
            // 
            this.autoPrint.Appearance = System.Windows.Forms.Appearance.Button;
            this.autoPrint.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.autoPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.autoPrint.FlatAppearance.BorderSize = 0;
            this.autoPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoPrint.Location = new System.Drawing.Point(0, 316);
            this.autoPrint.Name = "autoPrint";
            this.autoPrint.Size = new System.Drawing.Size(232, 75);
            this.autoPrint.TabIndex = 5;
            this.autoPrint.Text = "Auto. Nyomtatás";
            this.autoPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.autoPrint.UseVisualStyleBackColor = true;
            this.autoPrint.CheckedChanged += new System.EventHandler(this.autoPrint_CheckedChanged);
            // 
            // saveButtom
            // 
            this.saveButtom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButtom.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveButtom.FlatAppearance.BorderSize = 0;
            this.saveButtom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButtom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButtom.Location = new System.Drawing.Point(0, 391);
            this.saveButtom.Name = "saveButtom";
            this.saveButtom.Size = new System.Drawing.Size(232, 76);
            this.saveButtom.TabIndex = 6;
            this.saveButtom.Text = "Mentés";
            this.saveButtom.UseVisualStyleBackColor = false;
            this.saveButtom.Click += new System.EventHandler(this.saveButtom_Click);
            // 
            // Into_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.pdfDocumentViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Into_one";
            this.Text = " GLG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Into_one_FormClosed);
            this.Load += new System.EventHandler(this.Into_one_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox automatic_operation_chekbox;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button printing_button;
        private System.Windows.Forms.CheckBox autoPrint;
        private System.Windows.Forms.Button saveButtom;
    }
}