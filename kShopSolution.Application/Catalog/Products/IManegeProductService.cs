using kShopSolution.Application.Catalog.Products.Dtos;
using kShopSolution.Application.Catalog.Products.Dtos.Manage;
using kShopSolution.Application.Dtos;
using System.Threading.Tasks;

namespace kShopSolution.Application.Catalog.Products
{
    public interface IManegeProductService
    {
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int ProducId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
    }
}
