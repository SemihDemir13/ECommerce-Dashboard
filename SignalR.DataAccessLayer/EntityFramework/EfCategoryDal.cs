using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(SignalRContext context) : base(context)
        {
        }

        public int ActiveCategoryCount()
        {
            using var context=new SignalRContext(); 
          var values =context.Categorys.Where(x => x.status==true ).Count();
            return values;
        }

        public int CategoryCount()
        {
            using var context = new SignalRContext();
            return context.Categorys.Count();
        }

        public int PassiveCategoryCount()
        {
            using var context = new SignalRContext();
            var values = context.Categorys.Where(x => x.status == false).Count();
            return values;

        }
    }
}
