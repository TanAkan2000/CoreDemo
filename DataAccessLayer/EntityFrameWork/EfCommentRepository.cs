using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFrameWork
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {

    }
}