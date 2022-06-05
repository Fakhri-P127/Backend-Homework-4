using Backend_Homework_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_4.ViewModels
{
    public class BlogVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }

    }
}
