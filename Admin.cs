using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Admin
    {
        [Key]
        public int AuthorID { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }

    }
}
