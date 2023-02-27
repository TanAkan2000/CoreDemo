using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreDemo.Controllers
{
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        // bu method sayesinde categorymannager sınıdfındaki tüm methodlara erişim sağlanır
        // GET: /<controller>/
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
        // methodları çağırınca  aktif hale gelir
    }
}

