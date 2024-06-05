using equiscale.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace equiscale
{
    public partial class LoginForm : Form
    {
        DataContext db = new DataContext(); 
        public LoginForm()
        {
            this.AcceptButton = logInButton;
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (userFeild.Text == "Admin_EISolutions" && passwordField.Text == "EI$olutions@2021")
            {
                this.Hide();
                Admin ad = new Admin();
                ad.Show();
            }
            else if (db.Users.FirstOrDefault(x => x.UserID == userFeild.Text)!= null 
                && db.Users.FirstOrDefault(x => x.UserID == userFeild.Text).Password.Equals(passwordField.Text))
            {
                string date = db.Users.First(x => x.UserID == userFeild.Text).validityDate;
                if (DateTime.Parse(date)<DateTime.Now.Date) {
                    MessageBox.Show("Your license validity has expired!!!", "Please Contact administrator"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    DialogResult check = MessageBox.Show($"Is it {DateTime.Now:dddd, dd MMMM yyyy hh:mm tt} just now?",
                        "Check Date and Time", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //applying condition for date and time
                    if (check == DialogResult.Yes)
                    {
                        this.Hide();
                        DashBoard dashBoard = new DashBoard();
                        dashBoard.Show();
                    }
                    else if (check == DialogResult.No)
                    {
                        MessageBox.Show("Please change the date and time in the computer to correct date" +
                            " and time to log in again.", "Change system's Date and Time", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                MessageBox.Show("User ID or Password is incorrect!!!","Invalid Credentials"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

       
    }
}
