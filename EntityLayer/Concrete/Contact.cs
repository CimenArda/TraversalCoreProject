﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int ContactID { get; set; }

        public string Description { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }
        public string MapLocation { get; set; }
        public string Status { get; set; }
    }
}
