using equiscale.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace equiscale.Reports
{
    public partial class FormPrintReport : Form
    {
        private readonly DataGridView _data;
        private readonly DateTimePicker _to;
        private readonly DateTimePicker _from;
        private readonly string _item;
        private readonly string _table;
        DataContext db = new DataContext();

        public FormPrintReport(DataGridView data, DateTimePicker to,DateTimePicker from, string item, string table)
        {
            InitializeComponent();
            _data = data;
            _from = from;
            _to = to;
            _item = item;
            _table = table;
           
        }

        private void FormPrintReport_Load(object sender, EventArgs e)
        {
            var toolStrip = (ToolStrip)reportViewer1.Controls.Find("toolStrip1", true).First();
            ((ToolStripDropDownButton)toolStrip.Items["export"]).DropDownOpening += (obj, arg) =>
            {
                var item = ((ToolStripDropDownButton)obj);
                item.DropDownItems.Cast<ToolStripItem>().Where(x => x.Text != "Excel").ToList()
                    .ForEach(x => item.DropDownItems.Remove(x));
            };
         
            
            this.reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("DataSet1",_data.DataSource) ;
           
            ReportParameter[] parameters= new ReportParameter[3];
            if (db.HouseKeepings.Find(1)!=null) 
            {
                parameters[0] = new ReportParameter("Company", db.HouseKeepings.First(x => x.Id == 1).Company, true);
                    if (!String.IsNullOrEmpty(_item))
                    {
                        parameters[1] = new ReportParameter("Header1", $"{_table}:{_item}", true);
                        parameters[2] = new ReportParameter("Header2", $"Weighings from {_from.Value:dd/MM/yyyy} to {_to.Value:dd/MM/yyyy}.", true);
                    }
                    else
                    {
                        parameters[1] = new ReportParameter("Header1", "All weighings", true);
                        parameters[2] = new ReportParameter("Header2", $"From {_from.Value:dd/MM/yyyy} to {_to.Value:dd/MM/yyyy}.", true);
                    }
                this.reportViewer1.LocalReport.SetParameters(parameters);
            }
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
     
    }
}
