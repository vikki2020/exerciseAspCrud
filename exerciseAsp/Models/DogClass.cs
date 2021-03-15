using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace exerciseAsp.Models
{
    public class DogClass
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Comment { get; set; }

    }
}