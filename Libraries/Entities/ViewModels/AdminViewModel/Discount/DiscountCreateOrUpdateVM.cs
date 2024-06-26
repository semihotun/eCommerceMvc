﻿using Core.SeedWork;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
namespace Entities.ViewModels.AdminViewModel.Discount
{
    public class DiscountCreateOrUpdateVM : BaseEntity
    {
        public string Name { get; set; }
        public string AdminComment { get; set; }
        public Guid DiscountTypeId { get; set; }
        public bool UsePercentage { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal? MaximumDiscountAmount { get; set; }
        public DateTime? StartDateUtc { get; set; }
        public DateTime EndDateUtc { get; set; }
        public bool RequiresCouponCode { get; set; }
        public string CouponCode { get; set; }
        public Guid DiscountLimitationId { get; set; }
        public int LimitationTimes { get; set; }
        public int? MaximumDiscountedQuantity { get; set; }
        public bool AppliedToSubCategories { get; set; }
        public List<SelectListItem> DiscountTypeList { get; set; }
        public List<SelectListItem> DiscountLimitationList { get; set; }
        public string StartDateUtcFormat { get; set; }
        public string EndDateUtcFormat { get; set; }
    }
}
