using DiplomaOborotovIS.data.api.model.product;
using DiplomaOborotovIS.data.api.model.provider;
using DiplomaOborotovIS.data.api.model.warehouse;
using System.ComponentModel.DataAnnotations;
using System;

namespace DiplomaOborotovIS.data.api.model.supply
{
    internal class Supply
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; } = new();
        public Provider Provider { get; set; } = new();
        public Warehouse Warehouse { get; set; } = new();
        public DateTime DateTime { get; set; }
    }
}
