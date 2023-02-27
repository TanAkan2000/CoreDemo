using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// view in browser ctrl+shift+w

namespace BusinessLayer.Concrete
{
	public class BlogManager : IBlogService
	{
		IBlogDal _blogDal;
		private EfCategoryRepository efCategoryRepository;

		public BlogManager(IBlogDal blogDal)
		{
			_blogDal = blogDal;
		}

		public void BlogAdd(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogDelete(Blog blog)
		{
			throw new NotImplementedException();
		}

		public void BlogUpdate(Blog blog)
		{
			throw new NotImplementedException();
		}

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
		{
			throw new NotImplementedException();
		}
        public List<Blog>GetBlogById(int id)
        {
            return _blogDal.GetListAll(x=>x.BlogId== id);
        }

		public List<Blog> GetList()
		{
            return _blogDal.GetListAll();
        }

        void IBlogService.BlogAdd(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        void IBlogService.BlogDelete(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        void IBlogService.BlogUpdate(Blog blog)
        {
            _blogDal.Update(blog);
        }

        Blog IBlogService.GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        List<Blog> IBlogService.GetList()
        {
            return _blogDal.GetListAll();
        }
    }
}
