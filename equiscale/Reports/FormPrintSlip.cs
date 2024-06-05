using equiscale.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Reports
{
    public partial class FormPrintSlip : Form
    {
        DataContext db = new DataContext();
        int _slipNo;
        public FormPrintSlip(int slipNo)
        {
            _slipNo = slipNo;
            InitializeComponent();
        }

        private void FormPrintSlip_Load(object sender, EventArgs e)
        {
            var data = db.Reports.Where(x => x.SlipNo == _slipNo).ToList();
            ReportDataSource datasource = new ReportDataSource("DataSet1",data);
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportParameter[] parameters= new ReportParameter[5];
            if (db.HouseKeepings.Find(1)!=null) {
                parameters[0] = new ReportParameter("Company", db.HouseKeepings.First(x => x.Id == 1).Company, true);
                parameters[1] = new ReportParameter("Address1", db.HouseKeepings.First(x => x.Id == 1).Address1, true);
                parameters[2] = new ReportParameter("Address2", db.HouseKeepings.First(x => x.Id == 1).Address2, true);
                parameters[3] = new ReportParameter("Telephone", db.HouseKeepings.First(x => x.Id == 1).TelephoneNo.ToString(), true);
                if (data.Where(x => x.WeightType.Equals("Manual"))!=null)
                {
                    parameters[4] = new ReportParameter("Disclamer","Please note that the weight was entered manually!!", true);
                }
                
                this.reportViewer1.LocalReport.SetParameters(parameters);
            }
           
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
