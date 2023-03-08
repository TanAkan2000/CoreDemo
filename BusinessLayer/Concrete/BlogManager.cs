using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
		{
            return _blogDal.GetById(id);
        }
        public List<Blog>GetBlogById(int id)
        {
            return _blogDal.GetListAll(x=>x.BlogId== id);
        }

		public List<Blog> GetList()
		{
            return _blogDal.GetListAll();
        }
        public List<Blog>GetLast3Blog(int v)
        {
            return _blogDal.GetListAll().Take(3).ToList();
        }

        public List<Blog> GetBlogListByWriter(int id)
        {            
            return _blogDal.GetListAll(x => x.WriterID == id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TUpdate(Blog t)
        {
            _blogDal.Update(t);
        }

        public void TDelete(Blog t)
        {
            _blogDal.Delete(t);
        }

        public object GetLast3Blog()
        {
            throw new NotImplementedException();
        }

        //void IBlogService.BlogAdd(Blog blog)
        //{
        //    _blogDal.Insert(blog);
        //}

        //void IBlogService.BlogDelete(Blog blog)
        //{
        //    _blogDal.Delete(blog);
        //}

        //void IBlogService.BlogUpdate(Blog blog)
        //{
        //    _blogDal.Update(blog);
        //}
    }
}
