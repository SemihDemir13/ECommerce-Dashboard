﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(IMapper mapper,ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService; 
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var value=_mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAll());
            return Ok(value);

        }
       
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_categoryService.TCategoryCount());
        }
        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_categoryService.TActiveCategoryCount());
        }
        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_categoryService.TPassiveCategoryCount());
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName=createCategoryDto.CategoryName,
                status=true
            });
            return Ok("kategori eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value= _categoryService.TGetByID(id);
            _categoryService.TDelete(value);
            return Ok("kategori silindi");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                CategoryId = updateCategoryDto.CategoryID,
                status = true
            });
            return Ok("categori güncellendi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value=_categoryService.TGetByID(id);
            return Ok(value);
        }
        
    }
}
