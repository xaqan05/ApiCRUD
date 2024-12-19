using Api_CRUD.DTOs.Categories;

namespace Api_CRUD.Services.Abstracts
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryCreateDto dto);
        Task<IEnumerable<CategoryGetDto>> GetAllAsyncs();
    }
}
