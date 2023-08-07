using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTripProject.Models.Entities
{
    public class HomePage
    {
        [Key]
        public int homePageID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } // Açıklama

    }
}