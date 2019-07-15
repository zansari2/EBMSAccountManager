using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBMSAccountManager.BusinessLogic
{
    public class User
    {
        public User()
        {

        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int DoDID { get; set; }
        public string FacilityCode { get; set; }        
    }
}
