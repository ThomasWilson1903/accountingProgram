using DiplomaOborotovIS.data.api.model.user;
using System.ComponentModel.DataAnnotations;
using System;
using DiplomaOborotovIS.data.api.model.product;

namespace DiplomaOborotovIS.data.api.model.order
{
    public class Order
    {
        public int Id { get; set; }
        public string Addres { get; set; } = string.Empty;
        public int Price { get; set; }
        public Product Product { get; set; } = new();
        public int Quantity { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; } = new();
    }
}
