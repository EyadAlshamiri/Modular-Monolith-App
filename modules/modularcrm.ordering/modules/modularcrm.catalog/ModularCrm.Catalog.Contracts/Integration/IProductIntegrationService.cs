using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModularCrm.Catalog.Integration
{
    public interface IProductIntegrationService
    {
        Task<List<ProductDto>> GetProductsByIdsAsync(List<Guid> ids);
    }
}
