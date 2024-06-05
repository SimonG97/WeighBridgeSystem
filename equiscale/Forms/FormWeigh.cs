using equiscale.Data;
using equiscale.Model;
using System;
using System.Data.Entity;
using System.IO.Ports;
using System.Windows.Forms;

namespace equiscale.Forms
{
    public partial class FormWeigh : Form
    {
        private SerialPort _serialPort;
        private readonly DataContext db = new DataContext();
        private readonly Report report = new Report();
        public int Weight { get; set; }
        public FormWeigh()
        {
            
            InitializeComponent();
            RadioAuto.Checked = true;
           
        }

        private void ManualRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (ManualRadio.Checked)
            {
                OpenForm(new FormPassword(this));

            }
            ScaleDisplay.ReadOnly = false;
            ScaleDisplay.Text = "0";

        }

        private void RadioAuto_CheckedChanged(object sender, EventArgs e)
        {
            ScaleDisplay.ReadOnly = true;
            ScaleDisplay.Text = "0";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (!FirstRadio.Checked && !SecondRadio.Checked)
            {
                MessageBox.Show("Select between first or second weight.", "Please select weight!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!TareRadio.Checked && !GrossRadio.Checked)
            {
                MessageBox.Show("Select between Tare or Gross weight.", "Please select weight type!"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (ManualRadio.Checked)
                {
                    Weight = int.Parse(ScaleDisplay.Text);
                    DateTextBox.Text = DateTime.Now.ToShortDateString();
                    TimeTextBox.Text = DateTime.Now.ToString("hh:mm tt");
                }
                else {
                    var setting = db.Setting.Find(1);
                    if (setting == null)
                    {
                        MessageBox.Show("Please configure the settings in settings tab!", "No settings configured!"
                                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else {
                        int baudRate = (int)setting.BaudeRate;
                        int dataBits;
                        if (baudRate == 9600)
                        {
                            dataBits = 8;
                        }
                        else
                        {
                            dataBits = 7;
                        }
                        if (_serialPort != null && _serialPort.IsOpen)
                            _serialPort.Close();
                        if (_serialPort != null)
                            _serialPort.Dispose();
                        _serialPort = new SerialPort(setting.ComPort, baudRate, Parity.None, dataBits, StopBits.One);
                        _serialPort.DataReceived += SerialPortOnDataReceived;
                        try
                        {
                            _serialPort.Open();
                        }
                        catch {
                            MessageBox.Show("Device is not connected to the computer", "Please connect device!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        Weight = int.Parse(ScaleDisplay.Text);
                        DateTextBox.Text = DateTime.Now.ToShortDateString();
                        TimeTextBox.Text = DateTime.Now.ToString("hh:mm tt");
                    }
                }
            }
        }

        private void ScaleDisplay_KeyPress(object sender, KeyPressEventArgs e)
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            if (Weight == 0)
            {
                MessageBox.Show("Please capture weight before saving the record!", "No weight captured"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else if (VehicleTextBox.Text.Length==0)
            {

                MessageBox.Show("Please enter the vehicle registration number!", "Empty Required field"
                   , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                report.Customer = CustomerTextBox.Text.Trim();
                report.Charges = String.IsNullOrEmpty(ChargesTextBox.Text) ? decimal.Parse("0.0") : decimal.Parse(ChargesTextBox.Text.Trim());
                report.Material = MaterialTextBox.Text.Trim();
                report.Remarks = String.IsNullOrEmpty(RemarkTextBox.Text.Trim())?"-Na-":RemarkTextBox.Text.Trim();
                report.Supplier = SupplierTextBox.Text.Trim();
                report.VehicleRegnNo = VehicleTextBox.Text.Trim();
                report.VehicleType = VehicleTypeTextBox.Text.Trim();
                //checking is tare radio is checked and apply weights to it
                if (TareRadio.Checked)
                {
                    report.TareWeight = Weight;
                    report.TareDate = DateTextBox.Text.Trim();
                    report.TareTime = TimeTextBox.Text.Trim();
                    report.LatestDate = DateTextBox.Text.Trim();
                }
                //for the gross weight
                else {
                    report.GrossWeight = Weight;
                    report.GrossDate =DateTextBox.Text.Trim();
                    report.GrossTime = TimeTextBox.Text.Trim();
                    report.LatestDate = DateTextBox.Text.Trim();
                    if (ManualRadio.Checked) {
                        report.WeightType = "Manual";
                    }
                }
                if (SecondRadio.Checked)
                {
                    int slipNo = int.Parse(SlipNoTextBox.Text);
                    var slip = db.Reports.Find(slipNo);
                    var tare = slip.TareWeight;
                    var gross = slip.GrossWeight;
                    if (ManualRadio.Checked)
                    {
                        slip.WeightType = "Manual";
                    }
                    //checking if anyone of weights are present
                    if (tare == null) {
                        slip.NetWeight = gross - Weight;
                        slip.TareWeight = Weight;
                        slip.TareDate= DateTextBox.Text.Trim();
                        slip.TareTime= TimeTextBox.Text.Trim();
                        slip.LatestDate= DateTextBox.Text.Trim();
                    }
                    else
                    {
                        slip.NetWeight = Weight - tare;
                        slip.GrossWeight = Weight;
                        slip.GrossDate = DateTextBox.Text.Trim();
                        slip.GrossTime = TimeTextBox.Text.Trim();
                        slip.LatestDate = DateTextBox.Text.Trim();
                    }
                    try
                    {
                        slip.Charges = String.IsNullOrEmpty(ChargesTextBox.Text) ? decimal.Parse("0.0") : decimal.Parse(ChargesTextBox.Text.Trim());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("The charges should be in numbers!", "Invalid data type for charges"
                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                     
                    slip.Remarks = String.IsNullOrEmpty(RemarkTextBox.Text.Trim()) ? "-Na-" : RemarkTextBox.Text.Trim();
                    db.Entry(slip).State = EntityState.Modified;
                }
                else {
                    db.Reports.Add(report);
                    
                }
                db.SaveChanges();
                SlipNoTextBox.Text=String.IsNullOrEmpty(SlipNoTextBox.Text)?report.SlipNo.ToString():SlipNoTextBox.Text;
                MessageBox.Show("Slip saved successfully", "Success", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
            }
        }
        

        private void OpenForm(Form form)
        {
            form.BringToFront();
            form.ShowDialog();
        }
        public bool RadioManualBtn
        {
            get { return ManualRadio.Checked; }
            set { ManualRadio.Checked = value; }
        }
        public bool RadioAutoBtn
        {
            get { return RadioAuto.Checked; }
            set { RadioAuto.Checked = value; }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FirstRadio.Checked = true;
            Helper.ClearFormControls(this);
            ScaleDisplay.Text = "0";
            ChargesTextBox.Text = "0.0";
            RemarkTextBox.Text = "-Na-";
            Weight = 0;
        }

        private void SecondRadio_CheckedChanged(object sender, EventArgs e)
        {
            
            if (SecondRadio.Checked)
            {
                Helper.ClearFormControls(this);
                ScaleDisplay.Text = "0";
                ChargesTextBox.Text = "0.0";
                RemarkTextBox.Text = "-Na-";
                OpenForm(new FormSlipEntry(this));
                if (SecondRadio.Checked) {
                    Helper.ReadOnly(this);
                    ChargesTextBox.Enabled = true;
                    RemarkTextBox.Enabled = true;
                    ScaleDisplay.Enabled = true;
                    WeightTypePanel.Enabled = false;
                }
                
            }
            else
            {
               ClearBtn_Click(sender, e);
               Helper.Open(this);
               SlipNoTextBox.Enabled = false;
               TimeTextBox.Enabled = false;
               DateTextBox.Enabled = false;
               WeightTypePanel.Enabled = true;
               TareRadio.Checked = false;
               GrossRadio.Checked = false;
            }
          
        }

        public string SlipNo
        {
            get { return SlipNoTextBox.Text; }
            set { SlipNoTextBox.Text = value; }
        }
        public bool RadioFirstBtn
        {
            get { return FirstRadio.Checked; }
            set { FirstRadio.Checked = value; }
        }
        public string VehicleNo
        {
            get { return VehicleTextBox.Text; }
            set { VehicleTextBox.Text= value; }
        }
        public string VehicleType
        {
            get { return VehicleTypeTextBox.Text; }
            set { VehicleTypeTextBox.Text = value; }
        }
        public string Supplier
        {
            get { return SupplierTextBox.Text; }
            set { SupplierTextBox.Text = value; }
        }
        public string Customer
        {
            get { return CustomerTextBox.Text; }
            set { CustomerTextBox.Text = value; }
        }

        public string Material
        {
            get { return MaterialTextBox.Text; }
            set { MaterialTextBox.Text = value; }
        }
        public string Remarks
        {
            get { return RemarkTextBox.Text; }
            set { RemarkTextBox.Text = value; }
        }
        public string Charges
        {
            get { return ChargesTextBox.Text; }
            set { ChargesTextBox.Text = value; }
        }
        public bool RadioTare
        {
            get { return TareRadio.Checked; }
            set { TareRadio.Checked = value; }
        }
        public bool RadioGross
        {
            get { return GrossRadio.Checked; }
            set { GrossRadio.Checked = value; }
        }

        private void ChargesTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private delegate void Closure();
        private void SerialPortOnDataReceived(object sender, SerialDataReceivedEventArgs serialDataReceivedEventArgs)
        {
            if (InvokeRequired)     //<-- Makes sure the function is invoked to work properly in the UI-Thread
                BeginInvoke(new Closure(() => { SerialPortOnDataReceived(sender, serialDataReceivedEventArgs); }));     //<-- Function invokes itself
            else
            {
                int dataLength = _serialPort.BytesToRead;
                byte[] data = new byte[dataLength];
                int nbrDataRead = _serialPort.Read(data, 0, dataLength);
                if (nbrDataRead == 0)
                    return;
                string str = System.Text.Encoding.UTF8.GetString(data);
                ScaleDisplay.Text = str.ToString();
            }
        }


    }
}
