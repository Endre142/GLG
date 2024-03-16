namespace GLG
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.SecondPage = new System.Windows.Forms.Button();
            this.FirstPage = new System.Windows.Forms.Button();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Red;
            this.MenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MenuPanel.Controls.Add(this.SecondPage);
            this.MenuPanel.Controls.Add(this.FirstPage);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(800, 60);
            this.MenuPanel.TabIndex = 0;
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesktopPanel.AutoScroll = true;
            this.DesktopPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DesktopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DesktopPanel.ForeColor = System.Drawing.Color.Black;
            this.DesktopPanel.Location = new System.Drawing.Point(0, 60);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(800, 390);
            this.DesktopPanel.TabIndex = 1;
            // 
            // SecondPage
            // 
            this.SecondPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.SecondPage.FlatAppearance.BorderSize = 0;
            this.SecondPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecondPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SecondPage.ForeColor = System.Drawing.Color.SlateGray;
            this.SecondPage.Image = global::GLG.Properties.Resources.kicsi_2;
            this.SecondPage.Location = new System.Drawing.Point(220, 0);
            this.SecondPage.Name = "SecondPage";
            this.SecondPage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SecondPage.Size = new System.Drawing.Size(220, 58);
            this.SecondPage.TabIndex = 1;
            this.SecondPage.Text = "Második oldal ";
            this.SecondPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SecondPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SecondPage.UseVisualStyleBackColor = true;
            this.SecondPage.Click += new System.EventHandler(this.button2_Click);
            // 
            // FirstPage
            // 
            this.FirstPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FirstPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.FirstPage.FlatAppearance.BorderSize = 0;
            this.FirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstPage.ForeColor = System.Drawing.Color.SlateGray;
            this.FirstPage.Image = global::GLG.Properties.Resources.kicsi_1;
            this.FirstPage.Location = new System.Drawing.Point(0, 0);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.FirstPage.Size = new System.Drawing.Size(220, 58);
            this.FirstPage.TabIndex = 0;
            this.FirstPage.Text = "Első oldal ";
            this.FirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FirstPage.UseVisualStyleBackColor = true;
            this.FirstPage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.MenuPanel);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Szerkesztő";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed_1);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SecondPage;
        private System.Windows.Forms.Button FirstPage;
        private System.Windows.Forms.Panel DesktopPanel;
        public System.Windows.Forms.Panel MenuPanel;
    }
}