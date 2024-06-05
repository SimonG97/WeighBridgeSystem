using equiscale.Data;
using equiscale.Model;
using System;
using System.Data.Entity;
using System.IO.Ports;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormSettings : Form
    {
        DataContext db = new DataContext();
        Settings settings = new Settings();
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            foreach (var portName in portNames)
            {
                comboBox1.Items.Add(portName);

            }
            if (!string.IsNullOrEmpty(comboBox1.Text))
            {
                comboBox1.SelectedIndex = 0;

            }
            BaudeRatecomboBox2.SelectedIndex = 0;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Com Port not selected!!!", "Please Select Com Port"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (BaudeRatecomboBox2.SelectedIndex < 0)
            {
                MessageBox.Show("Baude rate Not selected!!!", "Please Select Baude Rate"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var data = db.Setting.Find(1);
                if (data != null)
                {
                    data.ComPort = comboBox1.SelectedItem.ToString();
                    data.BaudeRate = int.Parse(BaudeRatecomboBox2.SelectedItem.ToString());
                    db.Entry(data).State = EntityState.Modified;
                }
                else { 
                    settings.ComPort= comboBox1.SelectedItem.ToString();
                    settings.BaudeRate= int.Parse(BaudeRatecomboBox2.SelectedItem.ToString());
                    db.Setting.Add(settings);
                }
                db.SaveChanges();
                MessageBox.Show("Record saved successfully", "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }

        }
    }
}
