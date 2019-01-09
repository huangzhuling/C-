using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Genre
    {
        public string Name { get; set; }
    }
    public class Album
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
    }
}