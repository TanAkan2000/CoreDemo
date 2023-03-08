using System;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

       
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> GetList()
        {
            //FIX
            //throw new NotImplementedException();
            return _categoryDal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categoryDal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categoryDal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categoryDal.Update(t);
        }

        //void ICategoryService.CategoryAdd(Category category)
        //{
        //    _categoryDal.Insert(category);
        //}

        //void ICategoryService.CategoryDelete(Category category)
        //{
        //    _categoryDal.Delete(category);
        //}

        //void ICategoryService.CategoryUpdate(Category category)
        //{
        //    _categoryDal.Update(category);
        //}

    }
}

