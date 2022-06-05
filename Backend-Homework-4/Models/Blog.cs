using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_4.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        
        public DateTime PostTime { get; set; }

        public string Title { get; set; }
        public string Text { get; set; }
        public string BlockQuote { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
