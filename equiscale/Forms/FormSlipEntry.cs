using equiscale.Data;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormSlipEntry : Form
    {
        private readonly FormWeigh _form;
        private readonly DataContext db = new DataContext();
        public FormSlipEntry(FormWeigh form)
        {
            _form = form;
            InitializeComponent();
        }

        private void FormSlipEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Reports' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = db.Reports.Where(x => x.NetWeight == null).ToList();
            
        }

     

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SlipNoTextBox.Text)) {
                try
                {
                    int slipNo = int.Parse(SlipNoTextBox.Text);
                    var data = db.Reports.Where(x => x.SlipNo == slipNo && x.NetWeight == null).ToList();
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
            else{
                dataGridView1.DataSource = db.Reports.Where(x => x.NetWeight == null).ToList();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _form.SlipNo = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            _form.VehicleNo = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            _form.VehicleType = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            _form.Supplier = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            _form.Customer = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            _form.Material = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            _form.Remarks = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            _form.Charges = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            this.Hide();
            int slipNo = int.Parse(_form.SlipNo);
            if (db.Reports.FirstOrDefault(x => x.SlipNo == slipNo).TareWeight != null)
            {
                _form.RadioGross = true;

            }
            else {
                _form.RadioTare = true;
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
                    dataGridView1.DataSource = db.Reports.Where(x => x.NetWeight == null).ToList();

                }
            }
            else
            {
                MessageBox.Show("Select the slip to be deleted!!!", "Row not Selected"
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

        private void FormSlipEntry_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.RadioFirstBtn = true;
            
        }
    }
}
