using AutoMapper;
using SignalR.EntityLayer.Entities;
using SignalR.DtoLayer.AboutDto;

namespace SignalRApi.Mapping
{ //AutoMapper, ASP.NET Core veya ASP.NET MVC gibi .NET projelerinde nesneler arası
  //dönüşüm işlemini (mapping) otomatikleştiren bir kütüphanedir.
  //Özellikle DTO (Data Transfer Object) ve Entity nesneleri arasında veri taşımak için kullanılır
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About,ResultAboutDto>().ReverseMap(); //buradda eşleştirme işlemlerini yaptık  .yani bu dtolar mapping uygulanacak
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
        }
    }
}
