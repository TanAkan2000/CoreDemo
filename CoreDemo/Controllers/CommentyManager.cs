using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;

namespace CoreDemo.Controllers
{
	internal class CommentyManager : CommentManager
	{
		public CommentyManager(ICommentDal commentdal) : base(commentdal)
		{
		}
	}
}