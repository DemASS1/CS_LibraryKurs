using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Сomplaint
    {
        [Key]
        public int СomplaintID { get; set; }
        public string Description { get; set; }
        public string СomplaintTheme { get; set; }
        public int BookID { get; set; }
    }
}
