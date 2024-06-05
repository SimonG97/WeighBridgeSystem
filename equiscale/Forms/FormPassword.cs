using equiscale.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormPassword : Form
    {
        private readonly DataContext db = new DataContext();
        private readonly FormWeigh anyForm;
        
        public FormPassword(Form form)
        {
            if (form.Text == "Weigh")
            {
                anyForm = form as FormWeigh;
            }
            InitializeComponent();
            
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if (db.InAppUsers.FirstOrDefault(x => x.Id == 1).Password == PasswordTextBox.Text)
            {
                this.Hide();
                this.anyForm.RadioManualBtn =true;
        
                
            }
            else
            {
                MessageBox.Show("Password is incorrect!!!", "Invalid Credentials"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void FormPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.anyForm.RadioAutoBtn = true;
        }
    }
}
