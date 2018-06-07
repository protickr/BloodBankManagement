using BBM.DAL;
using BBM.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.BLL
{
    public class RequestProcessRepo
    {
        private ProcessRequest request = new ProcessRequest();//to access dal ProcessRequest
        private string bagCode = null;

        public string AllRequestProcess(RequestInfo requestToProcess)
        {
            //user want to donate
            if (requestToProcess.RequestTypeID == "Donate") 
            {
                bagCode=request.AddToInventory(requestToProcess);
                request.AddToHistory(requestToProcess, bagCode);
                request.AddtoBloodData(requestToProcess);
                return bagCode;
            }

            //user want to obtain
            else
            {
                bool isAvailable = request.BloodAvailability(requestToProcess);
                if(isAvailable==true)
                {
                    bagCode = request.RequestBagCode(requestToProcess);
                    if (bagCode != null)
                    {
                        request.AddToHistory(requestToProcess, bagCode);
                        request.RemoveFromBloodData(requestToProcess);
                    }
                    return bagCode;
                }
                else
                {
                    bagCode = "Unavailable";
                    return bagCode;
                }
            }
        }
    }
}
