using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBMSAccountManager.BusinessLogic
{
    public class Role
    {
        public Role()
        {

        }

        // Add logic to get these from external resource/dynamic
        public static IList<Role> roles = new List<Role>()
        {
            new Role() { ID = 0, Name = "Installer" },
            new Role() { ID = 1, Name = "Admin" },
            new Role() { ID = 2, Name = "Tech 1" },
            new Role() { ID = 3, Name = "TBD" },
            new Role() { ID = 4, Name = "TBD" },
            new Role() { ID = 5, Name = "TBD" },
            new Role() { ID = 6, Name = "Bench Tech" },
        };

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }        
    }
}
