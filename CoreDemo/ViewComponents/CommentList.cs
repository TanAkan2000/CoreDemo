using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
	public class CommentList: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>()
			{
				new UserComment
				{
					ID=1,
					username="Alara"
				},
				new UserComment
				{
					ID=2,
					username="Tan"
				},
				new UserComment
				{
					ID=3,
					username="İrem"
				}
			};
			return View(commentvalues);
		}
	}
}
