﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentID { get; set; }

        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContext { get; set; }
        public bool CommentState { get; set; }


        public int DestinationID { get; set; }

        public Destination Destination { get; set; }

        public int AppUserID { get; set; }

        public AppUser AppUser { get; set; }

    }
}
