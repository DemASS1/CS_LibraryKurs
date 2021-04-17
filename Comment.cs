using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public int AuthorID { get; set; }
        public string Text { get; set; }
        public int BookID { get; set; }
        public DateTime Datetime { get; set; }
    }
}
