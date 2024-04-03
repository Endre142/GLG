namespace GLG
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.into_one = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.separately = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(462, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 66);
            this.label2.TabIndex = 7;
            this.label2.Text = "Egyben a számla és a garancialevél";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.UseMnemonic = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(112, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Külön a számla és garncialevél";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseMnemonic = false;
            // 
            // into_one
            // 
            this.into_one.BackColor = System.Drawing.Color.White;
            this.into_one.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.into_one.Cursor = System.Windows.Forms.Cursors.Hand;
            this.into_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.into_one.Image = global::GLG.Properties.Resources.kicsi_1_1_;
            this.into_one.Location = new System.Drawing.Point(516, 250);
            this.into_one.Name = "into_one";
            this.into_one.Size = new System.Drawing.Size(129, 166);
            this.into_one.TabIndex = 3;
            this.into_one.UseVisualStyleBackColor = false;
            this.into_one.Click += new System.EventHandler(this.into_one_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GLG.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(367, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 70);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // separately
            // 
            this.separately.BackColor = System.Drawing.Color.White;
            this.separately.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.separately.Cursor = System.Windows.Forms.Cursors.Hand;
            this.separately.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.separately.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separately.Image = global::GLG.Properties.Resources.kicsi_2_1_;
            this.separately.Location = new System.Drawing.Point(167, 250);
            this.separately.Name = "separately";
            this.separately.Size = new System.Drawing.Size(129, 166);
            this.separately.TabIndex = 2;
            this.separately.Text = " ";
            this.separately.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.separately.UseVisualStyleBackColor = false;
            this.separately.Click += new System.EventHandler(this.separately_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.into_one);
            this.Controls.Add(this.separately);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Főoldal";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button separately;
        private System.Windows.Forms.Button into_one;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}