using BBM.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBM.Ui
{
    public partial class ReportForm : MetroFramework.Forms.MetroForm
    {
        string keyWord = null;
        HistoryData historyToShow = new HistoryData();
        public ReportForm()
        {
            InitializeComponent();
            requestTypeComboBoxReportForm.SelectedIndex = 0;
            searchBoxReportForm.Text = "";
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            FormLoadAllHistory();
        }

        private void requestTypeComboBoxReportForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyWord = requestTypeComboBoxReportForm.SelectedItem.ToString();
            bloodReportGridReportForm.DataSource =  historyToShow.HistoryByRequest(keyWord);
        }
        private void FormLoadAllHistory()
        {
            bloodReportGridReportForm.DataSource = historyToShow.ExchangeHistory();
        }

        private void realoadButton_Click(object sender, EventArgs e)
        {
            FormLoadAllHistory();
        }

        private void searchButtonReportForm_Click(object sender, EventArgs e)

        {
          //  requestTypeComboBoxReportForm.SelectedIndex = 0;
            keyWord = searchBoxReportForm.Text;
           bloodReportGridReportForm.DataSource = historyToShow.HistoryByUserName(keyWord);
        }
    }
}
