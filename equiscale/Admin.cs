using equiscale.Data;
using equiscale.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace equiscale
{
    public partial class Admin : Form
    {
        private readonly DataContext db = new DataContext();
        private readonly User user = new User();
        private readonly InAppUser appUser = new InAppUser();
   
        public Admin()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userFeild.Text) || String.IsNullOrEmpty(passwordFeild.Text))
            {
                MessageBox.Show("Please fill in all the feilds!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                
                user.UserID = userFeild.Text.Trim();
                user.Password = passwordFeild.Text.Trim();
                user.validityDate = dateTimePicker1.Value.Date.ToShortDateString();
                var userApp = db.InAppUsers.Find(1);
                if (userApp!=null) {
                    userApp.Password = passwordFeild.Text.Trim();
                    db.Entry(userApp).State = EntityState.Modified;
                }
                else{
                    appUser.Password = passwordFeild.Text.Trim();
                    _ = db.InAppUsers.Add(appUser);
                }
                
                db.Users.Add(user);
                var result = db.SaveChanges();
                if (result == 2||result==1)
                {
                    MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
