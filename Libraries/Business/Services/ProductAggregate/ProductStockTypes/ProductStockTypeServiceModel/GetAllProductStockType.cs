﻿namespace Business.Services.ProductAggregate.ProductStockTypes.ProductStockTypeServiceModel
{
    public class GetAllProductStockType
    {
        public int SelectedId { get; set; }
        public GetAllProductStockType(int selectedId = 0)
        {
            SelectedId = selectedId;
        }
        public GetAllProductStockType()
        {
        }
    }
}
