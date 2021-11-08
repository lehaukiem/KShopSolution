using kShopSolution.Application.Catalog.Products.Dtos;
using kShopSolution.Application.Catalog.Products.Dtos.Public;
using kShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace kShopSolution.Application.Catalog.Products
{
    public  interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
