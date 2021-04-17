using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string AboutYourself { get; set; }
        public DateTime TimeBan { get; set; }
    }
}
