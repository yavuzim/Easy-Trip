﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EasyTripProject.Models.Entities
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}