using kShopSolution.ViewModels.Common;
using System.Collections.Generic;

namespace kShopSolution.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }
        public List<int> CategoryIds { set; get; }
    }
}
