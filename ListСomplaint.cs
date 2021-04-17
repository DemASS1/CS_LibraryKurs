using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class ListСomplaint
    {

        [Key]
        public int ListСomplaintID { get; set; }
        public string Description { get; set; }
    }
}
