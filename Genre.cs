using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLibrary
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        public int Genr { get; set; }

    }
}
