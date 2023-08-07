using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTripProject.Models.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FullAddress { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
    }
}