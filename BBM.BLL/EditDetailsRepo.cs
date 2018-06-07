using BBM.DAL;
using BBM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.BLL
{
    public class EditDetailsRepo
    {
        EditDetailsData userToEdit = new EditDetailsData();
        private int returnedAddressId = 0, isSuccessful = 0;

        //edit process by accessing DAL -> EditDetailsData

        public int editUser(UserInfo userObj, AddressInfo addressObj)
        {
            returnedAddressId = userToEdit.editUserAddress(addressObj);

            if(userObj.AddressId == returnedAddressId)
            {
                isSuccessful = userToEdit.editUserInfo(userObj);//Primary key of User table is always > 0 
            }

            if (isSuccessful > 0)
                return isSuccessful;
            else
                return 0;
        }
    }
}
