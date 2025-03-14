using MultiShop.Catalog.Dtos.CategoryDtos;
using MultiShop.Catalog.Dtos.ProductDtos;

namespace MultiShop.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task <List<ResultProductDto>> GetAllCategoryAsync();

        Task CreateProdcutAsync(CreateProductDto createProductDto);
        Task UpdateProdcutAsync(UpdateProductDto updateProductDto);
        Task DeleteProdcutAsync(string id);
        Task<GetByIdProductDto> GetByIdProdcutAsync(string id);
    }
}
