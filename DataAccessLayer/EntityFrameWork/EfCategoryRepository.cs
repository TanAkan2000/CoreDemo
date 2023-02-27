using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFrameWork
{
	public class EfCategoryRepository: GenericRepository<Category>, ICategoryDal
    {
		
	}
}

