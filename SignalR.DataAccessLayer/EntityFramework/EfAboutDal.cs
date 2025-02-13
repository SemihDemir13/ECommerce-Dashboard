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
    public class EfAboutDal : GenericRepository<About>, IAboutDal //buradaki GenericRepository IGeneric interface'inden implemente edilen metotları içerir
        //IAboutDal ise özel olarak IAboutDal kısmında özel olarak eklediğimiz metotları içerir
        
    {
        public EfAboutDal(SignalRContext context) : base(context)
        {
            
        }
    
        
    }
}
