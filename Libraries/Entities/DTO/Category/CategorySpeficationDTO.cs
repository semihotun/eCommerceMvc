﻿using Entities.Concrete.SpeficationAggregate;
using System.Collections.Generic;
namespace Entities.DTO.Category
{
    public class CategorySpeficationDTO
    {
        public Concrete.CategoriesAggregate.Category Category { get; set; }
        public IEnumerable<SpecificationAttribute> CategorySpeficationList { get; set; }
    }
}
