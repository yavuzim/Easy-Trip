using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyTripProject.Models.Entities
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}