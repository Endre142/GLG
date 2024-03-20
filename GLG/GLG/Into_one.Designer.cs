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
            this.Editor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pdfDocumentViewer1 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.pdfDocumentViewer2 = new Spire.PdfViewer.Forms.PdfDocumentViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.printing_button);
            this.panel1.Controls.Add(this.search_button);
            this.panel1.Controls.Add(this.automatic_operation_chekbox);
            this.panel1.Controls.Add(this.Editor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 450);
            this.panel1.TabIndex = 0;
            // 
            // printing_button
            // 
            this.printing_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printing_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.printing_button.FlatAppearance.BorderSize = 0;
            this.printing_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printing_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printing_button.Location = new System.Drawing.Point(0, 316);
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
            this.search_button.Location = new System.Drawing.Point(0, 240);
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
            this.automatic_operation_chekbox.Location = new System.Drawing.Point(0, 165);
            this.automatic_operation_chekbox.Name = "automatic_operation_chekbox";
            this.automatic_operation_chekbox.Size = new System.Drawing.Size(232, 75);
            this.automatic_operation_chekbox.TabIndex = 2;
            this.automatic_operation_chekbox.Text = "Auto. működés";
            this.automatic_operation_chekbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.automatic_operation_chekbox.UseVisualStyleBackColor = true;
            this.automatic_operation_chekbox.CheckedChanged += new System.EventHandler(this.automatic_operation_chekbox_CheckedChanged);
            // 
            // Editor
            // 
            this.Editor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Editor.Dock = System.Windows.Forms.DockStyle.Top;
            this.Editor.FlatAppearance.BorderSize = 0;
            this.Editor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editor.Location = new System.Drawing.Point(0, 89);
            this.Editor.Name = "Editor";
            this.Editor.Size = new System.Drawing.Size(232, 76);
            this.Editor.TabIndex = 1;
            this.Editor.Text = "Szerkesztő";
            this.Editor.UseVisualStyleBackColor = false;
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GLG.Properties.Resources.icon1;
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
            // pdfDocumentViewer2
            // 
            this.pdfDocumentViewer2.AutoScroll = true;
            this.pdfDocumentViewer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.pdfDocumentViewer2.FormFillEnabled = false;
            this.pdfDocumentViewer2.Location = new System.Drawing.Point(596, 127);
            this.pdfDocumentViewer2.MultiPagesThreshold = 60;
            this.pdfDocumentViewer2.Name = "pdfDocumentViewer2";
            this.pdfDocumentViewer2.OnRenderPageExceptionEvent = null;
            this.pdfDocumentViewer2.PageLayoutMode = Spire.PdfViewer.Forms.PageLayoutMode.SinglePageContinuous;
            this.pdfDocumentViewer2.Size = new System.Drawing.Size(177, 197);
            this.pdfDocumentViewer2.TabIndex = 2;
            this.pdfDocumentViewer2.Text = "pdfDocumentViewer2";
            this.pdfDocumentViewer2.Threshold = 60;
            this.pdfDocumentViewer2.ViewerMode = Spire.PdfViewer.Forms.PdfViewerMode.PdfViewerMode.MultiPage;
            this.pdfDocumentViewer2.ZoomFactor = 1F;
            this.pdfDocumentViewer2.ZoomMode = Spire.PdfViewer.Forms.ZoomMode.Default;
            // 
            // Into_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pdfDocumentViewer2);
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
        private System.Windows.Forms.Button Editor;
        private System.Windows.Forms.CheckBox automatic_operation_chekbox;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer1;
        private Spire.PdfViewer.Forms.PdfDocumentViewer pdfDocumentViewer2;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button printing_button;
    }
}