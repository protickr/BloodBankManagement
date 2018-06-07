using BBM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.DAL
{
    public class ProcessRequest
    {
        //*****Donation******//
        //donation request adding to inventory
        public string AddToInventory(RequestInfo request)
        {
            string _randomString = RandomString(4);
            using (var context = new BbmDBEntities())
            {
                var newInventoryEntry = new BloodInventory()
                {
                    BI_UserId = request.UserID,
                    Blood_Group = request.BloodID,
                    BI_Quantity = request.Quantity,
                    BI_Bag_Code = request.UserID + _randomString,
                    BI_Date=DateTime.Now
                };
                context.BloodInventories.Add(newInventoryEntry);//if i do single for each quantiy then it will consume more data
                context.SaveChanges();
                return newInventoryEntry.BI_Bag_Code;
            }
        }
        //donation request adding to history
        public void AddToHistory(RequestInfo request,string bagCode)
        {
            using (var context = new BbmDBEntities())
            {
                var HistoryToAdd = new History()
                {
                    UserId=request.UserID,
                    UserName=request.UserName,
                    RequestType=request.RequestTypeID,
                    BloodGroup=request.BloodID,
                    Quantity=request.Quantity,
                    History_Bag_Code=bagCode,
                    History_date=DateTime.Now
                };
                context.Histories.Add(HistoryToAdd);
                context.SaveChanges();//error because if blood not found what is the bag code ?
            }
        }

        //donation request, Updating BloodData table
        public void AddtoBloodData(RequestInfo request)
        {
            int newQuantity = 0;
            using (var context = new BbmDBEntities())
            {
                var bloodDataToUpdate = from blood in context.BloodDatas where blood.Title == request.BloodID select blood;
                foreach(var item in bloodDataToUpdate)
                {
                    newQuantity = item.AvailableQuantity;
                    newQuantity = newQuantity + request.Quantity;
                    item.AvailableQuantity = newQuantity;
                }
                context.SaveChanges();
            }
        }

        //copied from stackoverflow
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        //*****Donation******//



        //*****Obtain******//
        //Main Blood inventory check for total quantity availability
        public bool BloodAvailability(RequestInfo request)
        {
            using (var context = new BbmDBEntities())
            {
                var bloodData = from blood in context.BloodDatas
                                where blood.Title == request.BloodID &&
                                blood.AvailableQuantity >= request.Quantity
                                select blood;

                    if (bloodData.Count() != 0)
                        return true;
                    else
                        return false;
            }
        }

        //Obtain request,returning bagcode Inventory check
        public string RequestBagCode(RequestInfo request)
        {
            int totalQuantity = 0;
            int individualInventoryQuantity = 0;
            string bagCode = null;
            
            using (var context = new BbmDBEntities())
            {
                var selectRowToGetData = from blood in context.BloodInventories
                                      where blood.Blood_Group == request.BloodID
                                      select blood;
                

                foreach(var item in selectRowToGetData)
                {
                    while(totalQuantity<request.Quantity)
                    {
                        totalQuantity++;

                        item.BI_Quantity--;
                        individualInventoryQuantity++;
                        bagCode = item.BI_Bag_Code + " " + bagCode;

                        if (item.BI_Quantity == 0)
                        {
                            RemoveFromInventory(item.BInventory_Id);
                            individualInventoryQuantity = 0;
                            break;
                        }
                        if(totalQuantity == request.Quantity && item.BI_Quantity > 0)
                        {
                            UpdateInventory(item.BInventory_Id,individualInventoryQuantity);
                            individualInventoryQuantity = 0;
                            break;
                        }
                    }
                }
            }
            return bagCode;
        }

        //update inventory if BI_Quantity > 0
        private void UpdateInventory(int inventoryId,int quantity)
        {
            using (var context = new BbmDBEntities())
            {
                var itemToRemove = from bloodInventoy in context.BloodInventories
                                   where bloodInventoy.BInventory_Id==inventoryId
                                   select bloodInventoy;
                if (itemToRemove != null)
                {
                    foreach(var item in itemToRemove)
                    {
                        item.BI_Quantity = item.BI_Quantity - quantity;
                    }
                    context.SaveChanges();
                }
            }
        }

        //remove from inventory if BI_Quantity = 0
        private void RemoveFromInventory(int inventoryId)
        {
            using (var context = new BbmDBEntities())
            {
                var itemToRemove = context.BloodInventories.SingleOrDefault(x => x.BInventory_Id == inventoryId);
                if(itemToRemove!=null)
                {
                    context.BloodInventories.Remove(itemToRemove);
                    context.SaveChanges();
                }
            }
        }

        //adjusting available quantity//removing requested quantity amount from BloodData
        public void RemoveFromBloodData(RequestInfo request)
        {
            int newQuantity = 0;
            using (var context = new BbmDBEntities())
            {
                var bloodDataToUpdate = from blood in context.BloodDatas where blood.Title == request.BloodID select blood;
                foreach (var item in bloodDataToUpdate)
                {
                    newQuantity = item.AvailableQuantity;
                    newQuantity = newQuantity - request.Quantity;
                    item.AvailableQuantity = newQuantity;
                }
                context.SaveChanges();
            }
        }

    }
}
