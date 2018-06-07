using BBM.DAL;
using BBM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.BLL
{
    public class UserRepo
    {
        UserData userToAdd = new UserData();
        private int returnedAddressId=0,isSuccessful=0;
        

        public int AddUser(UserInfo userObj, AddressInfo addressObj)
        {
            returnedAddressId = userToAdd.AddUserAddress(addressObj);

            userObj.AddressId = returnedAddressId; //assigning addressId first

            isSuccessful = userToAdd.AddUser(userObj); //adding user to table
            if (isSuccessful > 0)
                return isSuccessful;
            else
                return 0;               
        }
    }
}
