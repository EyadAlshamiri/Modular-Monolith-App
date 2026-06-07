using System;

namespace ModularCrm.Ordering
{
    public class OrderCreationDto
    {
        public Guid ProductId { get; set; }
        public string CustomerName { get; set; } = null!;
    }
}
