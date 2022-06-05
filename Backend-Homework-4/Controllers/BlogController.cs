using Backend_Homework_4.DAL;
using Backend_Homework_4.Models;
using Backend_Homework_4.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Homework_4.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            BlogTagsVM model = new BlogTagsVM
            {
                Tags = _context.Tags.ToList(),
                Blogs = _context.Blogs.OrderByDescending(b => b.PostTime).Take(4).Include(b => b.Comments).Include(b => b.Tags).ToList()
            };
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            BlogVM model = new BlogVM
            {
                Blog = _context.Blogs.Include(b => b.Comments).Include(b=>b.Tags).FirstOrDefault(b => b.Id == id),
                Blogs = _context.Blogs.OrderByDescending(order => order.PostTime).Take(4).ToList()
            };
         
            if (model.Blog == null) return NotFound();

            return View(model);
        }
    }
}
