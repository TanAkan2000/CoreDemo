using System;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        //void AddBlog(Blog blog);
        //void DeleteBlog(Blog blog);
        //Blog GetById(int id);
        //List<Blog> ListAllBlog();
        //void UpdateBlog(Blog blog);

        List<Blog> GetListWithCategory();
    }
}

