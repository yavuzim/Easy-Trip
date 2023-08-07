using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTripProject.Models.Entities
{
    public class BlogComment
    {
        // IEnumerable sayesinde bir view içerisinde birden fazla tablodan veri çekeriz.
        public IEnumerable<Blog> Blog{ get; set; }
        public IEnumerable<Comments> Comment{ get; set; }
        public IEnumerable<Blog> BlogFilter { get; set; }
    }
}