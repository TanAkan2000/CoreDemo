using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface IAboutService
	{
        //list
        List<About> GetList();
    }
}

