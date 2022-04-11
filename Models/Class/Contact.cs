using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Class
{
    
    public class Contact
    {
        [Key]
        public int Contactid { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string  Email { get; set; }

        [Column(TypeName = "Varchar")]
        [MaxLengthAttribute]
        public string Message { get; set; }

    }
}