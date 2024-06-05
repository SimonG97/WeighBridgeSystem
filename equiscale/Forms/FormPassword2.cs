using equiscale.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormPassword2 : Form
    {
        DataContext db = new DataContext();
        private readonly DashBoard _dash;
        string _name;
        public FormPassword2(DashBoard dash, string name)
        {
            _dash = dash;
            _name = name;
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (db.InAppUsers.FirstOrDefault(x => x.Id == 1).Password == PasswordTextBox.Text)
            {
                this.Hide();
                if (_name.Equals("Report"))
                {
                   _dash.OpenChildForm(new FormReport());
                    
                }
                else {
                    _dash.OpenChildForm(new FormHouseKeeping());
                }


            }
            else
            {
                MessageBox.Show("Password is incorrect!!!", "Invalid Credentials"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void FormPassword2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _dash.Homebtn_Click(sender, e);
        }
    }
}
