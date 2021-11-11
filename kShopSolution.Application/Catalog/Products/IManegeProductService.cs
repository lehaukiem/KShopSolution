using kShopSolution.ViewModels.Catalog.Products;
using kShopSolution.ViewModels.Catalog.Products.Manage;
using kShopSolution.ViewModels.Catalog.Products.Public;
using kShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using GetProductPagingRequest = kShopSolution.ViewModels.Catalog.Products.Manage.GetProductPagingRequest;

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

        Task<int> AddImages(int productId, List<IFormFile> files);
        Task<int> RemoveImages(int imageId);
        Task<int> UpdateImages(int imageId, string caption, bool isDefault);

        Task<List<ProductImageViewModel>> GetListImage(int productId);
    }
}
