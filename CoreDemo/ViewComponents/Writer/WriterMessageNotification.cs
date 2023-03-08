using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
	public class WriterMessageNotification : ViewComponent
	{
        
        public IViewComponentResult Invoke()
        {
            
            return View();
        }
    }
}

