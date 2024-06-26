﻿using System;

namespace Entities.RequestModel.ProductAggregate.Products
{
    public class UpdateProductReqModel
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public string ProductName { get; set; }
        public Guid? BrandId { get; set; }
        public Guid? CategoryId { get; set; }
        public string ProductContent { get; set; }
        public bool? ProductShow { get; set; }
        public string Gtin { get; set; }
        public string Sku { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public Guid ProductStockTypeId { get; set; }
        public string ProductNameUpper { get; set; }
        public UpdateProductReqModel()
        {

        }
        public UpdateProductReqModel(Guid id, string productName,
            Guid? brandId,
            Guid? categoryId,
            string productContent,
            bool? productShow,
            string gtin, string sku, DateTime createdOnUtc, Guid productStockTypeId, string productNameUpper)
        {
            Id = id;
            ProductName = productName;
            BrandId = brandId;
            CategoryId = categoryId;
            ProductContent = productContent;
            ProductShow = productShow;
            Gtin = gtin;
            Sku = sku;
            CreatedOnUtc = createdOnUtc;
            ProductStockTypeId = productStockTypeId;
            ProductNameUpper = productNameUpper;
        }
    }
}
