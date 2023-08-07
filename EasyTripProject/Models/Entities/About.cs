using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTripProject.Models.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string PhotoURL { get; set; }
        public string Description { get; set; }
    }
}