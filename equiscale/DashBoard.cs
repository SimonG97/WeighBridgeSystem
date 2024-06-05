using equiscale.Data;
using equiscale.Forms;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace equiscale
{
    public partial class DashBoard : Form
    {
        private IconButton currentBtn;
        private readonly Panel leftBorderBtn;
        private Form currentChildForm;
      
        public DashBoard()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
           
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //structs
        public struct RGBColors 
        { 
            public static Color color1 = Color.FromArgb(172,126,241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5= Color.FromArgb(249, 88, 155);
            
        }

        private void DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void ActivateButton(object senderBtn, Color color) 
        {
            if (senderBtn !=null) {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
               
                

            }

        }

        private void DisableButton()
        {
            if (currentBtn!=null) 
            {
                currentBtn.BackColor = Color.FromArgb(31,30,68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        public void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            tableLayoutPanel1.Hide();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleChildForm.Text = childForm.Text;
        }

        private void Weighbtn_Click(object sender, System.EventArgs e)
        {
            
            ActivateButton(sender,RGBColors.color1);
            OpenChildForm(new FormWeigh());
        }

        private void Printbtn_Click(object sender, System.EventArgs e)
        {
            
            ActivateButton(sender, RGBColors.color2);
            
            OpenChildForm(new FormPrint());
        }

        private void Reportbtn_Click(object sender, System.EventArgs e)
        {
            
            string name = "Report";
            ActivateButton(sender, RGBColors.color3);
            new FormPassword2(this,name).ShowDialog();
            
        }

        private void Housebtn_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            string name = "House";
            new FormPassword2(this, name).ShowDialog();
        }

        private void Settingbtn_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new FormSettings());
        }

        public void Homebtn_Click(object sender, System.EventArgs e)
        {
            DataContext db = new DataContext();
            var data = db.HouseKeepings.FirstOrDefault(x=>x.Id==1);
            if (data != null)
            {
                this.company.Text = data.Company;
                this.Address1.Text = data.Address1;
                this.Address2.Text = data.Address2;
            }
            tableLayoutPanel1.Show();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            TitleChildForm.Text = "Home";

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        public void ClosedPasswordBox() {
            OpenChildForm(new FormWeigh());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Date.Text= DateTime.Now.ToString("dd/MM/yyyy");
            this.Time.Text= DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {
            DataContext db = new DataContext();
            var data = db.HouseKeepings.Find(1);
            if (data != null)
            {
                this.company.Text = data.Company;
                this.Address1.Text = data.Address1;
                this.Address2.Text = data.Address2;
            }
            timer1.Start();
        }

    }
}
