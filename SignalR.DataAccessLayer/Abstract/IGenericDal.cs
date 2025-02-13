using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Abstract //Abstract klasörlerinde interfacelerimiz bulunur
{
    public interface IGenericDal<T> where T : class //burası bizim genel metotları eklendiğimiz yer IAboutDal gibi intercaelerde
                                                    // ise özel metotlarımızı implemente ettircez
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);  
        T GetByID(int id);  
        List<T> GetAll();

    }
}
