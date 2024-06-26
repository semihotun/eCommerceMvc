﻿using Core.SeedWork;
using System;
namespace Entities.Concrete
{
    public class OrderNote : BaseEntity, IEntity
    {
        public string Note { get; set; }
        public Guid OrderId { get; set; }
        public Guid DownloadId { get; set; }
        public bool DisplayToCustomer { get; set; }
    }
}
