﻿namespace Entities.Concrete.DiscountsAggregate
{
    public class DiscountProduct : BaseEntity
    {
        public int DiscountId { get; set; }
        public int ProductId { get; set; }
    }
}
