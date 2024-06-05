using equiscale.Data;
using equiscale.Model;
using System;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormHouseKeeping : Form
    {
        DataContext db = new DataContext();
        HouseKeeping house = new HouseKeeping();
        public FormHouseKeeping()
        {
            InitializeComponent();
        }

        private void CompanySaveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(CompanyTextBox.Text) || String.IsNullOrEmpty(address1TextBox.Text) || String.IsNullOrEmpty(address2TextBox.Text)||String.IsNullOrEmpty(teleTxtBox.Text))
            {
                MessageBox.Show("Please all the required fields to save the record!", "Empty fields"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                var data = db.HouseKeepings.FirstOrDefault(x => x.Id == 1);
                if (data != null)
                {
                    data.Company = CompanyTextBox.Text.Trim();
                    data.Address1 = address1TextBox.Text.Trim();
                    data.Address2 = address2TextBox.Text.Trim();
                    data.TelephoneNo = int.Parse(teleTxtBox.Text.Trim());
                    db.Entry(data).State = EntityState.Modified;
                }
                else {
                    house.Company = CompanyTextBox.Text.Trim();
                    house.Address1 = address1TextBox.Text.Trim();
                    house.Address2 = address2TextBox.Text.Trim();
                    house.TelephoneNo = int.Parse(teleTxtBox.Text.Trim());
                    db.HouseKeepings.Add(house);
                }
                db.SaveChanges();
                MessageBox.Show("Company set up saved succesfully", "Success", MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
            }
            
        }

        private void passChangeBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(oldpassTxtBox.Text) || String.IsNullOrEmpty(newPassTxtBox.Text) || String.IsNullOrEmpty(confirmPassTxtBox.Text))
            {
                MessageBox.Show("Please all the required fields to save the record!", "Empty fields"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var data = db.InAppUsers.FirstOrDefault(x=>x.Id==1);
                if (data.Password.Equals(oldpassTxtBox.Text))
                {
                    if (newPassTxtBox.Text.Equals(confirmPassTxtBox.Text))
                    {
                        data.Password = newPassTxtBox.Text.Trim();
                        db.Entry(data).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Password Changed succesfully", "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The new password and confirm password should match!", "Passwords do not match"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The old password is incorrect!", "Wrong Password"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void teleTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            string pickDatabaseFrom = Environment.CurrentDirectory;
            var databaseName = "DataDB.db";

            using (var fbd= new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    var backupDatabaseTo = fbd.SelectedPath + "\\" + (Path.GetFileNameWithoutExtension(databaseName) + ".db");
                    Helper.BackUpDb(pickDatabaseFrom, databaseName, backupDatabaseTo);
                    MessageBox.Show("Success");
                }
            }
        }

        private void RestoreBtn_Click(object sender, EventArgs e)
        {
            string restoreDatabaseFrom = string.Empty;
            var databaseName = "DataDB.db";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog()==DialogResult.OK) {
                
                restoreDatabaseFrom = Path.GetDirectoryName(openFileDialog.FileName);
                var restoreDatabaseTo = Environment.CurrentDirectory + "\\" + databaseName;
                Helper.RestoreDB(restoreDatabaseFrom, databaseName, restoreDatabaseTo, true);
                MessageBox.Show("Restore Succesfully");
            }
        }
    }
}
