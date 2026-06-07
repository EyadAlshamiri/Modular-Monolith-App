using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ModularCrm.Ordering;

public class OrderAppService : OrderingAppService, IOrderAppService
{
    private readonly IRepository<Order, Guid> _orderRepository;

    public OrderAppService(IRepository<Order, Guid> orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<List<OrderDto>> GetListAsync()
    {
        var orders = await _orderRepository.GetListAsync();
        return ObjectMapper.Map<List<Order>, List<OrderDto>>(orders);
    }

    public async Task<OrderDto> CreateAsync(OrderCreationDto input)
    {
        var order = new Order
        {
            ProductId = input.ProductId,
            CustomerName = input.CustomerName,
            State = OrderState.Placed
        };

        await _orderRepository.InsertAsync(order);
        return ObjectMapper.Map<Order, OrderDto>(order);
    }
}
