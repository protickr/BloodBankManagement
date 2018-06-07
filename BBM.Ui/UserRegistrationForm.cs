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
    public partial class userRegistrationForm : MetroFramework.Forms.MetroForm
    {
        //public static MainForm hidden;
        //public void toShowClose(Form toShow, Form toClose)
        //{
        //    toShow.Show();
        //    hidden= (BBM.Ui.MainForm)toClose;
        //    hidden.Hide();
        //}

        public userRegistrationForm()
        {
            InitializeComponent();
        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void backButtonRegistrationForm_Click(object sender, EventArgs e)
        {
            //clear the following code first before implementation this is for From design purposes
            var newForm =new MainForm();
            newForm.Show(this);
            this.Hide();
        }

        private void clearButtonRegistrationForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void confirmButtonRegistrationForm_Click(object sender, EventArgs e)
        {
            int isSuccessful = 0;
            if (userNameRegistrationForm.Text == string.Empty || emailRegistrationForm.Text == string.Empty ||
                phoneRegistrationForm.Text == string.Empty || passwordUserRegistrationForm.Text == string.Empty ||
                ageRegistrationForm.Text == string.Empty || houseNumberRegistrationForm.Text == string.Empty ||
                roadNumberRegistrationForm.Text == string.Empty || subDistrictRegistrationForm.Text == string.Empty ||
                districtRegistrationForm.Text == string.Empty || countryRegistrationForm.Text == string.Empty ||
                zipCodeRegistrationForm.Text == string.Empty || bloodGroupRegistrationForm.SelectedIndex == 0)

                MetroMessageBox.Show(this, "Please Insert All The Values", "Some Field Left Unfilled", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            else
            {
                var addressDetails = new AddressInfo();
                var userDetails = new UserInfo();
                var userToAdd = new UserRepo();
                

                userDetails.Name = userNameRegistrationForm.Text;
                userDetails.Phone = phoneRegistrationForm.Text;
                userDetails.Email = emailRegistrationForm.Text;
                userDetails.Age = ageRegistrationForm.Text;
                userDetails.AddressId = 0;
                userDetails.BloodId = bloodGroupRegistrationForm.SelectedIndex;
                userDetails.UserRole = Convert.ToInt32("2"); //assigning general role as a normal user
                userDetails.Password = passwordUserRegistrationForm.Text;
                userDetails.Date = DateTime.Now;


                addressDetails.Houseno = houseNumberRegistrationForm.Text;
                addressDetails.Roadno = roadNumberRegistrationForm.Text;
                addressDetails.SubDistrict = subDistrictRegistrationForm.Text;
                addressDetails.District = districtRegistrationForm.Text;
                addressDetails.Country = countryRegistrationForm.Text;
                addressDetails.Zip = Convert.ToInt32(zipCodeRegistrationForm.Text);

                isSuccessful = userToAdd.AddUser(userDetails, addressDetails); //user repo bll
                if (isSuccessful > 0)
                {
                    MetroMessageBox.Show(this, "Registration Successful Please go to the Login Page to login, Thank You", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
        }
        private void ClearForm()
        {
            userNameRegistrationForm.Text = "";
            emailRegistrationForm.Text = "";
            phoneRegistrationForm.Text = "";
            passwordUserRegistrationForm.Text = "";
            bloodGroupRegistrationForm.SelectedIndex = 0;
            ageRegistrationForm.Text = "";
            houseNumberRegistrationForm.Text = "";
            roadNumberRegistrationForm.Text = "";
            subDistrictRegistrationForm.Text = "";
            districtRegistrationForm.Text = "";
            countryRegistrationForm.Text = "";
            zipCodeRegistrationForm.Text = "";
        }
    }
}
