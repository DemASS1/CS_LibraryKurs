using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Book
    {
        [Key]
        public int BookID { get; set; }
        //public int AuthorID { get; set; }
        public string TextTxtPath { get; set; } 
        public string DescriptionTxtPath { get; set; }
        public int Ban { get; set; }
    }
}
