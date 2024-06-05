using equiscale.Data;
using equiscale.Reports;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormPrint : Form
    {
        DataContext db = new DataContext();
        public FormPrint()
        {
            InitializeComponent();
        }

        private void FormPrint_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Reports' table. You can move, or remove it, as needed.

            dataGridView1.DataSource= db.Reports.ToList();

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SlipNoTextBox.Text))
            {
                try
                {
                    int slipNo = int.Parse(SlipNoTextBox.Text);
                    var data = db.Reports.Where(x => x.SlipNo == slipNo).ToList();
                    if (data.Count != 0)
                    {
                        dataGridView1.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("No entries found with the entered slip number!!!", "Invalid Slip Number!"
                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                { 
                     MessageBox.Show("Invalid slip number has been entered!!!", "Invalid Slip Number!"
                  , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
               

            }
            else
            {
                dataGridView1.DataSource = db.Reports.ToList();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex =dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex >=0)
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
                    dataGridView1.DataSource = db.Reports.ToList();

                }
            }
            else {
                MessageBox.Show("Select the  slip to be deleted!!!", "Slip not Selected"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedRowIndex >= 0)
            {
                int slipNo = int.Parse(dataGridView1.Rows[selectedRowIndex].Cells[0].Value.ToString());
                DialogResult check = MessageBox.Show($"Are sure you want to print SlipNo:{slipNo}?",
                    "Print Slip", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (check == DialogResult.Yes)
                {
                    var slip = db.Reports.FirstOrDefault(x => x.SlipNo == slipNo).SlipNo;
                    new FormPrintSlip((int)slip).ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Select slip to me printed!!!", "Slip not Selected"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SlipNoTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
