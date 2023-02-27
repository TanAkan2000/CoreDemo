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

        public void CategoryAdd(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList()
        {
            //FIX
            //throw new NotImplementedException();
            return _categoryDal.GetListAll();
        }

        void ICategoryService.CategoryAdd(Category category)
        {
            _categoryDal.Insert(category);
        }

        void ICategoryService.CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        void ICategoryService.CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }

        Category ICategoryService.GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        List<Category> ICategoryService.GetList()
        {
            return _categoryDal.GetListAll();
        }
    }
}

