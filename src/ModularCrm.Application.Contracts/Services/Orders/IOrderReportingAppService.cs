
using ModularCrm.Services.Dtos.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ModularCrm.Services.Orders;

public interface IOrderReportingAppService : IApplicationService
{
    Task<List<OrderReportDto>> GetLatestOrders();
}
