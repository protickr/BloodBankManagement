using BBM.Entity;
using System;
using System.Linq;
using System.Text;

namespace BBM.DAL
{
    public class UserData
    {
        UserInfo loggedInUserInfo = new UserInfo {UId=0, UserRole=0, Name=null};

        //user Login Starts here
        public UserInfo UserLogin(string userName, string password,UserInfo loggedInUserInfo)
        {
            using (var context = new BbmDBEntities())
            {
                var userToLogin = from person in context.Users where (person.Name == userName) && (person.Password == password) select person;
                if (userToLogin.Count() != 0)
                {
                    foreach (var item in userToLogin)
                    {
                        loggedInUserInfo.UId = item.UId;
                        loggedInUserInfo.UserRole = item.UserRole;
                        loggedInUserInfo.Name = item.Name;
                    }
                }
            }
            return loggedInUserInfo;
        }

        public int AddUserAddress(AddressInfo addressDetails) //to add addRess
        {
            using (var context = new BbmDBEntities())
            {
                var newAddress = new Address //creating new addRess and inserting
                {
                    Houseno = addressDetails.Houseno,
                    Roadno = addressDetails.Roadno,
                    SubDistrict = addressDetails.SubDistrict,
                    District = addressDetails.District,
                    Country = addressDetails.Country,
                    Zip = addressDetails.Zip
                };
                context.Addresses.Add(newAddress);
                context.SaveChanges();
                return newAddress.AId;
            }
        }
        public int AddUser(UserInfo userDetails)//to add new User
        {
            using (var context = new BbmDBEntities())
            {
                var newUser = new User //creating new user for insertion
                {
                    Name = userDetails.Name,
                    Phone = userDetails.Phone,
                    Email = userDetails.Email,
                    Age = userDetails.Age,
                    AddressId = userDetails.AddressId,
                    BloodId = userDetails.BloodId,
                    UserRole = userDetails.UserRole,
                    Password = userDetails.Password,
                    Date= DateTime.Now
                };
                context.Users.Add(newUser);
                context.SaveChanges();//causing error
                return newUser.UId;
            }
        }
    }
}
