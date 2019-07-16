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

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private int _doDID;
        public int DoDID
        {
            get {return _doDID; }
            set {_doDID = value; }
        }
        private String _facilityCode;
        public string FacilityCode
        {
            get {return _facilityCode; }
            set { _facilityCode = value; }
        }        
    }
}
