using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.ProductDto;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _SocialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService SocialMediaService, IMapper mapper)
        {
            _SocialMediaService = SocialMediaService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var value=_SocialMediaService.TGetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            _SocialMediaService.TAdd(new SocialMedia()
            {
              Title=createSocialMediaDto.Title,
              Icon=createSocialMediaDto.Icon, 
              Url=createSocialMediaDto.Url
            });
            return Ok("sosyal medya bilgisi eklendi");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _SocialMediaService.TGetByID(id);
            _SocialMediaService.TDelete(value);
            return Ok("ürün silindi");
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediadto)
        {
            _SocialMediaService.TUpdate(new SocialMedia
            {
                Title = updateSocialMediadto.Title,
                Icon = updateSocialMediadto.Icon,
                Url = updateSocialMediadto.Url,
                SocialMediaId= updateSocialMediadto.SocialMediaID
            });
            return Ok("sosyal medya güncellendi");
        }
        [HttpGet("GetSocialMedia")]
        public IActionResult GetProduct(int id)
        {
            var value = _SocialMediaService.TGetByID(id);
            return Ok(value);
        }
    }
}
