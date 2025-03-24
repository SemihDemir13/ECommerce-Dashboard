using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal //buradaki GenericRepository IGeneric interface'inden implemente edilen metotları içerir
                                                                  //IAboutDal ise özel olarak IAboutDal kısmında özel olarak eklediğimiz metotları içerir

    {
        public EfOrderDal(SignalRContext context) : base(context)
        {

        }

        public int ActiveOrderCount()
        {
            using var context = new SignalRContext();
            var values = context.Orders.Where(a => a.Description == "Müşteri masada").Count();
            return values;
        }

        public decimal LastOrderPrice()
        {
            using var context = new SignalRContext();
            return context.Orders.OrderByDescending(x => x.OrderID).Take(1).Select(y => y.TotalPrice).FirstOrDefault();

        }

        public int OrderCount()
        {
            using var context = new SignalRContext();
            var values = context.Orders.Count();
            return values;

        }
    }
    
 }

