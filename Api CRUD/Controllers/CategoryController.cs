using Api_CRUD.DAL;
using Api_CRUD.DTOs.Categories;
using Api_CRUD.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Api_CRUD.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CategoryController(ICategoryService _service) : ControllerBase
    {
        
        [HttpGet]
        public async Task<IActionResult> Read()
        {
            return Ok(await _service.GetAllAsyncs());
        }


        [HttpPost]
        public async Task<IActionResult> Create(CategoryCreateDto dto)
        {
            await _service.CreateAsync(dto);
            return Ok();
        }


        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }


        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }
    }
}
