using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LHSDBFreeAgentsAPI.Models
{
    public class PlayerResponse
    {
        public int UniqueID { get; set; }
        public string Name { get; set; }
        public string URLLink { get; set; }
        public int Team { get; set; }
        public int Contract { get; set; }
        public int Salary { get; set; }
        //public int Overall { get; set; }

        public int OVK { get; set; }
        public string Position { get; set; }

        public bool IsFA { get; set; }
        public int Age { get; set; }
    }
}
