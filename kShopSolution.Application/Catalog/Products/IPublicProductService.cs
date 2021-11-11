using kShopSolution.ViewModels.Catalog.Products;
using kShopSolution.ViewModels.Catalog.Products.Public;
using kShopSolution.ViewModels.Common;
using System.Threading.Tasks;

namespace kShopSolution.Application.Catalog.Products
{
    public  interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
