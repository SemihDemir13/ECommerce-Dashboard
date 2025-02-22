using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.SocialMediaDto;
using SignalR.DtoLayer.TestimonialDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }
        [HttpGet]
        public ActionResult TestimonialList()
        {
            var value= _testimonialService.TGetAll();
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto testimonialMediaDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
               Comment=testimonialMediaDto.Comment, 
               ImageUrl=testimonialMediaDto.ImageUrl,   
               Name=testimonialMediaDto.Name,
               Status=testimonialMediaDto.Status,
               Title=testimonialMediaDto.Title, 
            });
            return Ok("müşteri yorum bilgisi eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {
            var value=_testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("müşteri yorum silindi");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialdto)
        {
            _testimonialService.TUpdate(new Testimonial
            {
                Comment = updateTestimonialdto.Comment,
                ImageUrl = updateTestimonialdto.ImageUrl,
                Name = updateTestimonialdto.Name,
                Status = updateTestimonialdto.Status,
                Title = updateTestimonialdto.Title,
                TestimonialId= updateTestimonialdto.TestimonialID
            });
            return Ok("sosyal medya güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialService.TGetByID(id);
            return Ok(value);
        }
    }
}
