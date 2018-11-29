using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Vibes.Web.Models;

namespace Vibes.Web.Context
{
    public class VibesContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
    }
}