using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBMSAccountManager.BusinessLogic
{
    public class Facility
    {
        public Facility()
        {
            
        }
        public static IList<Facility> facilities = new List<Facility>()
        {
            new Facility() { Name = "Tripler", Code = "TRP", Active = true },
            new Facility() { Name = "Brian All Good", Code = "ALL", Active = true },
        }.OrderBy(o => o.Code).ToList();
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _code;
        public string Code
        {
            get {return _code; }
            set { _code = value; }
        }
        private bool _active;
        public bool Active
        {
            get {return _active; }
            set {_active = value; }
        }
    }
}
