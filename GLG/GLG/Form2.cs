using System;
using System.Drawing;
using System.Windows.Forms;

namespace GLG
{
    public partial class Form2 : Form
    {
        public event EventHandler Form2Closed;
        private Form activeForm;
        private Button currentButton;
        public static int desctopWidth;
        public static int desktopHeight;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Form2Closed?.Invoke(this, EventArgs.Empty);
        }

       

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null) 
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void ActivateButton (object btnSender) 
        { 
            if(btnSender != null) 
            {
                if(currentButton !=(Button) btnSender) 
                {   
                    DisableButton();
                    Color color = Color.Gray;
                    currentButton=(Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Red;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in MenuPanel.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.Red;
                    previousBtn.ForeColor = Color.SlateGray;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFirstPage(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormSecondPage(), sender);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            OpenChildForm(new FormFirstPage(), FirstPage);
            desctopWidth=DesktopPanel.Width;
            desktopHeight=DesktopPanel.Height;
        }

       
    }
}
