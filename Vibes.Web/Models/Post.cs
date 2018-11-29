using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vibes.Web.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }
        public string FeelingTag { get; set; }
    }
}