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

        public string Name { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }
    }
}
