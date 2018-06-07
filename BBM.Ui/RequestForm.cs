using BBM.BLL;
using BBM.Entity;
using MetroFramework;
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
    public partial class RequestForm : MetroFramework.Forms.MetroForm
    {
        static UserInfo loggedInUserInfo = new UserInfo();
        public RequestForm(UserInfo loggedInUser)
        {
            InitializeComponent();
            loggedInUserInfo = loggedInUser;
            userIdLabelRequestForm.Text = loggedInUserInfo.UId.ToString();
            userNameLabelUserForm.Text = loggedInUserInfo.Name;//requestForm is mixed up with userForm in the following part //sorry
            SetFields();
        }
        private void SetFields()
        {
            bloodGroupComboBoxUserForm.SelectedIndex = 0;
            requestTypeComboBoxUserForm.SelectedIndex = 0;
            quantityComboBoxUserForm.SelectedIndex = 0;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {

        }

        private void bloodGroupComboBoxUserForm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButtonRequestForm_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void backButtonRequestForm_Click(object sender, EventArgs e)
        {
            var UserHomepageForm = new UserHomePageForm(loggedInUserInfo);
            UserHomepageForm.Show();
            this.Close();
        }

        private void sendButtonRequestForm_Click(object sender, EventArgs e)
        {
            if (userIdLabelRequestForm.Text == string.Empty || userNameLabelUserForm.Text == string.Empty ||
                bloodGroupComboBoxUserForm.SelectedIndex == 0 || requestTypeComboBoxUserForm.SelectedIndex == 0 ||
                quantityComboBoxUserForm.SelectedIndex == 0)
            {
                MetroMessageBox.Show(this, "Please Fill Up all the fields First", "Empty Field", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
              //request information 
                RequestInfo requestStat = new RequestInfo();
                requestStat.UserID = Convert.ToInt32(userIdLabelRequestForm.Text);
                requestStat.UserName = userNameLabelUserForm.Text;
                requestStat.BloodID = bloodGroupComboBoxUserForm.SelectedItem.ToString();
                requestStat.RequestTypeID = requestTypeComboBoxUserForm.SelectedItem.ToString();
                requestStat.Quantity = quantityComboBoxUserForm.SelectedIndex;

                //Request Processing 
                string status = null;
                RequestProcessRepo requestToProcess = new RequestProcessRepo();
                status=requestToProcess.AllRequestProcess(requestStat);


                if (status != "Unavailable")
                {
                    status = "Request Successfully submitted, Bag Code: " + status;
                    MetroMessageBox.Show(this, status, "Sucess",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    Clear();
                }
                else if(status == "Unavailable")
                {
                    status = "Sorry Blood Not available for requested Blood Group";
                    MetroMessageBox.Show(this,status, "Sorry", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this,"Sorry Request Can Not Be Submitted","Sorry",MessageBoxButtons.RetryCancel,MessageBoxIcon.Exclamation);
                    Clear();
                }
            }
        }

        private void Clear()
        {
            bloodGroupComboBoxUserForm.SelectedIndex = 0;
            requestTypeComboBoxUserForm.SelectedIndex = 0;
            quantityComboBoxUserForm.SelectedIndex = 0;
        }

        private void requestPanelRequestForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
