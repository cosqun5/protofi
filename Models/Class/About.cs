using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Class
{
    public class About
    {
        [Key]
        public int Aboutid { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Surname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Address { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLengthAttribute]
        public string Information { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Experience { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(10)] 
        public string Completed { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string Available { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string Email { get; set; }

        public int Phone { get; set; }
       
    }
}