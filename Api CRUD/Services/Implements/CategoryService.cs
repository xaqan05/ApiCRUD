using Api_CRUD.DAL;
using Api_CRUD.DTOs.Categories;
using Api_CRUD.Entities;
using Api_CRUD.Services.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace Api_CRUD.Services.Implements
{
    public class CategoryService(AppDbContext _context) : ICategoryService
    {
        public async Task CreateAsync(CategoryCreateDto dto)
        {
            await _context.Categories.AddAsync(new Category
            {
                Id = dto.Id,
                Name = dto.Name,
            });
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CategoryGetDto>> GetAllAsyncs()
        {
            return await _context.Categories.Select(x => new CategoryGetDto{
                Id = x.Id,
                Name = x.Name,
            }).ToListAsync();
        }
    }
}
