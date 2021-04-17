﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class BookAuthor
    {
        [Key, Column(Order = 0)]
        public int BookID { get; set; }

        [Key, Column(Order = 1)]
        public int AuthorID { get; set; }
    }
}
