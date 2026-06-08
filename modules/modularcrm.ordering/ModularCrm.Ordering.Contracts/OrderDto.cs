using System;

namespace ModularCrm.Ordering
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string CustomerName { get; set; } = null!;
        public OrderState State { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
