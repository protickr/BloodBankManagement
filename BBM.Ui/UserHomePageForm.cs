using BBM.DAL;
using BBM.Entity;
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
    public partial class UserHomePageForm : MetroFramework.Forms.MetroForm
    {
        public static UserInfo loggedInUserInfo = new UserInfo();
        HistoryData gridHistory = new HistoryData();
        public UserHomePageForm(UserInfo loggedInUser)
        {
            InitializeComponent();
            loggedInUserInfo = loggedInUser;
            userIdLabelUserHomePageForm.Text = loggedInUserInfo.UId.ToString();
            userNameUserHomePageForm.Text = loggedInUserInfo.Name;
        }

        private void UserHomePageForm_Load(object sender, EventArgs e)
        {
            userHistoryGridUserHomePageForm.DataSource = gridHistory.UserHistory(Convert.ToInt32 (userIdLabelUserHomePageForm.Text));
        }

        private void requestButtonUserHomePageForm_Click(object sender, EventArgs e)
        {
            //this is temporary please clear before main implementation
            RequestForm newRequestForm = new RequestForm(loggedInUserInfo);
            newRequestForm.Show(this);
            this.Hide();
        }

        private void mainPanelUserHomePageForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userHistoryGridUserHomePageForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void logOutButtonUserHomePageForm_Click(object sender, EventArgs e)
        {
            new MainForm().Show();
            this.Close();
        }

        private void donateButtonUserHomePageForm_Click(object sender, EventArgs e)
        {
            RequestForm newRequestForm = new RequestForm(loggedInUserInfo);
            newRequestForm.Show(this);
            this.Hide();
        }

        private void editDetailsHomepageForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newEditDetails= new EditDetailsForm(loggedInUserInfo);
            newEditDetails.Show(this);
        }
    }
}
