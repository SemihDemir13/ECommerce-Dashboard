using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;


namespace SignalRApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;

        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values=_aboutService.TGetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImageUrl = createAboutDto.ImageUrl
            };
            _aboutService.TAdd(about);
            return Ok("Hakkımda kısmı başarıyla eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value=_aboutService.TGetByID(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda kısmı başarıyla silindi");


        }
        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var value = _mapper.Map<About>(updateAboutDto);
            _aboutService.TUpdate(value);
            return Ok("Hakkımda kısmı başarıyla güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value=_aboutService.TGetByID(id);
            return Ok(value);   
        }

    }
}
/*DTO ve Mapper arasındaki ilişki şudur:
DTO, veri taşımak için kullanılan nesne iken, Mapper ise bu veri taşıma işlemini dönüştürmek için kullanılan araçtır. AutoMapper gibi bir Mapper kullanarak, Entity (veritabanı modeliniz) ile DTO arasında dönüşüm işlemini kolayca yapabilirsiniz.

AutoMapper ile DTO ve Entity Arasında Dönüşüm
Entity → DTO dönüşümü: Veritabanından aldığınız bir Entity'yi, yalnızca gerekli verileri içeren bir DTO'ya dönüştürürsünüz.
DTO → Entity dönüşümü: Kullanıcıdan aldığınız verileri, veritabanına kaydetmek için bir Entity'ye dönüştürürsünüz.
*/
