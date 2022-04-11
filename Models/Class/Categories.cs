using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Class
{
    public class Categories
    {
        [Key]
        public  int Categoriid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public  string CName { get; set; }

        public ICollection<Portfoliooo>Portfoliooos{ get; set; }
    }
}