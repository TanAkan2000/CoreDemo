using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
	 CommentManager cm = new CommentManager(new EfCommentRepository());
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment p)
        {
			//TODO postgresql datetime nasıl importlanır
			p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
			p.CommentStatus = true;
			p.BlogId = 2;
			cm.CommentAdd(p);
            return PartialView();
        }
        public PartialViewResult CommentPartialListByBlog(int id)
		{
			var values =cm.GetList(id);
			return PartialView(values);
		}

    }
}
