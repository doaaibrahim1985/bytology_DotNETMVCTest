using Blog.BL;
using Blog.IBL;
using Blog.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.MobileControls;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class HomeController : Controller
    {
        private IBlogPostsRepository iBlogPostsRepository;
       
        
        public HomeController(IBlogPostsRepository _IBlogPostsRepository)
        {
            iBlogPostsRepository = _IBlogPostsRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {

           
            ViewBag.blogposts = iBlogPostsRepository.Getblogposts(); ;
            return View();
        }

        [HttpGet]
        public ActionResult blog(int ? id=1)
        {
            
            ViewBag.blog = iBlogPostsRepository.getblogpostsbyid(id.Value);
            return View();
        }
        [HttpPost]
        public ActionResult blog()
        {
         
            CommentModel comment = new CommentModel();
            comment.name = Request.Form["Name"];
            comment.date = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            comment.emailAddress = Request.Form["EmailAddress"];
            comment.message = Request.Form["Message"];
            int id=Int32.Parse(Request.Form["Id"]);
            ViewBag.blog = iBlogPostsRepository.addcomment(comment, id);
            return View();
        }
        [HttpPost]
        public ActionResult addreply()
        {

            ReplyModel reply = new ReplyModel();
            reply.name = Request.Form["Name"];
            reply.date = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            reply.message = Request.Form["Message"];
            int id = Int32.Parse(Request.Form["id"]);
            string date = Request.Form["date"];
            ViewBag.blog = iBlogPostsRepository.addreply(reply, date, id);
            return RedirectToAction("blog/"+id);
        }

    }
}
