﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guid
    {

        public int GuidID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Description2 { get; set; }
        public string Link2 { get; set; }
        public string GuidListImage { get; set; }

        public bool Status { get; set; }

        public List<Destination> Destinations { get; set; }
    }
}
