using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Class
{
    public class Portfoliooo
    {
        [Key]
        public int Portfolioooid { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string PName { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Photo { get; set; }

        public int Categoriid { get; set; }
        public virtual Categories Categories { get; set; }
    }
}