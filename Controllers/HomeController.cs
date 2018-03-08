using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app1.Models;
using app1.DAL;
using Microsoft.EntityFrameworkCore;

namespace app1.Controllers
{
    public class HomeController : Controller
    {
        private readonly BloggingContext db;

        public HomeController(BloggingContext db)
        {
            this.db = db;
        }

        public async Task<IActionResult> Index()
        {
            var blogs = await db
                .Blog
                //.Include(b=>b.Post)
                .ToListAsync();

            //blogs.FirstOrDefault()?.Post.Add(new Post
            //{
            //    Title = "Post " + DateTime.Now.Ticks,
            //    Content = "Post",
            //     CreateDate = DateTime.Now
            //});
            //await db.SaveChangesAsync();

            //var post = db.Post.FirstOrDefault(p => p.PostId == 2);
            //post.Title = "Post " + DateTime.Now.Ticks;
            //post.LastUpdate = DateTime.Now;
            //await db.SaveChangesAsync();

            //blogs.First().CreateDate = DateTime.Now;
            //await db.SaveChangesAsync();

            return View(blogs);
        }


        public async Task<IActionResult> Update()
        {
            var blogs = db.Blog;
            var b1 = await blogs.FindAsync(1);
            b1.BlogName = "DOTNET";

            var b2 = await blogs.FindAsync(2);
            b2.BlogName = "Web Development";
            b2.CreateDate = DateTime.Now;

            await db.SaveChangesAsync();


            return RedirectToAction(nameof(Index));
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
