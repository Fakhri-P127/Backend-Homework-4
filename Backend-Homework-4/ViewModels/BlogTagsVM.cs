using Backend_Homework_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_4.ViewModels
{
    public class BlogTagsVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Tag> Tags { get; set; }

    }
}
