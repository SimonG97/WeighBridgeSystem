using equiscale.Data;
using equiscale.Reports;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormReport : Form
    {
        DataContext db = new DataContext();
        public FormReport()
        {
            InitializeComponent();
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Reports' table. You can move, or remove it, as needed.

            db.Reports.Load();
            dataGridView1.DataSource = db.Reports.Local.ToBindingList();
            SearchBtn_Click(sender, e);
          

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
            if (fromDate.Value.Date>toDate.Value.Date) {
                MessageBox.Show("From Date cannot be greater than To Date!!!", "Error"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
                var to = toDate.Value.Date;
                var from = fromDate.Value.Date;
                string item = (string)sortByComboBox.SelectedItem;
                var data = db.Reports.ToList().Where(x =>DateTime.Parse(x.LatestDate)>= from && DateTime.Parse(x.LatestDate) <= to).ToList();
       
                    if (String.IsNullOrEmpty(SlipNoTextBox.Text) && String.IsNullOrEmpty(item))
                    {
                        dataGridView1.DataSource = data;
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(SlipNoTextBox.Text) && String.IsNullOrEmpty(item))
                        {
                            MessageBox.Show("No sort by has been selected!!!", "Select sort by "
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!String.IsNullOrEmpty(item) && String.IsNullOrEmpty(SlipNoTextBox.Text))
                        {
                            MessageBox.Show("Enter data into search box!!!", "Empty Search box "
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            switch (item)
                            {
                                case "Material":
                                    var data2 = data.Where(x => x.Material.ToLower() == SlipNoTextBox.Text.ToLower()).ToList();
                                    if (data2.Count == 0)
                                    {
                                        MessageBox.Show($"{SlipNoTextBox.Text} is not present inside {item} for the dates!!!", "No entries Found"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        FormReport_Load(sender, e);
                                    }
                                    else
                                    {
                                        dataGridView1.DataSource = data2;
                                    }
                                    break;
                                case "Supplier":
                                    data2 = data.Where(x => x.Supplier.ToLower() == SlipNoTextBox.Text.ToLower()).ToList();
                                    if (data2.Count == 0)
                                    {
                                        MessageBox.Show($"{SlipNoTextBox.Text} is not present inside {item} for the dates!!!", "No entries Found"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        FormReport_Load(sender, e);
                                    }
                                    else
                                    {
                                        dataGridView1.DataSource = data2;
                                    }
                                    break;
                                case "Customer":
                                    data2 = data.Where(x => x.Customer.ToLower() == SlipNoTextBox.Text.ToLower()).ToList();
                                    if (data2.Count == 0)
                                    {
                                        MessageBox.Show($"{SlipNoTextBox.Text} is not present inside {item} for the dates !!!", "No entries Found"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        FormReport_Load(sender, e);
                                    }
                                    else
                                    {
                                        dataGridView1.DataSource = data2;
                                    }
                                    break;
                                case "VehicleType":
                                    data2 = data.Where(x => x.VehicleType.ToLower() == SlipNoTextBox.Text.ToLower()).ToList();
                                    if (data2.Count == 0)
                                    {
                                        MessageBox.Show($"{SlipNoTextBox.Text} is not present inside {item} for the dates!!!", "No entries Found"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        FormReport_Load(sender, e);
                                    }
                                    else
                                    {
                                        dataGridView1.DataSource = data2;
                                    }
                                    break;
                                case "VehicleRegn.No":
                                    data2 = data.Where(x => x.VehicleRegnNo.ToLower() == SlipNoTextBox.Text.ToLower()).ToList();
                                    if (data2.Count == 0)
                                    {
                                        MessageBox.Show($"{SlipNoTextBox.Text} is not present inside {item} for the dates!!!", "No entries Found"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        FormReport_Load(sender, e);
                                    }
                                    else
                                    {
                                        dataGridView1.DataSource = data2;
                                    }
                                    break;
                            }

                        }
                    }
                

            }
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                int slipNo = int.Parse(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString());
                DialogResult check = MessageBox.Show($"Are sure you want to delete SlipNo:{slipNo}?",
                    "Delete Slip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    var slip = db.Reports.FirstOrDefault(x => x.SlipNo == slipNo);
                    db.Reports.Remove(slip);
                    db.SaveChanges();
                    MessageBox.Show($"SlipNo:{slipNo} is successfully deleted", "Success", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);

                    FormReport_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Select the slip to be deleted!!!", "Slip not Selected"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {
            fromDate.CustomFormat = "dd/MM/yyyy";
        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {
            toDate.CustomFormat = "dd/MM/yyyy";
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            SlipNoTextBox.Text = "";
            sortByComboBox.SelectedIndex = -1;
            fromDate.ResetText();
            toDate.ResetText();
            FormReport_Load(sender, e);
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
      
            new FormPrintReport(dataGridView1,toDate, fromDate, SlipNoTextBox.Text.Trim(), (string)sortByComboBox.SelectedItem).ShowDialog();
        }
    }
}
