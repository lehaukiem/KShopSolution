using kShopSolution.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace kShopSolution.Application.Catalog.Products.Dtos.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }
        public List<int> CategoryIds { set; get; }
    }
}
