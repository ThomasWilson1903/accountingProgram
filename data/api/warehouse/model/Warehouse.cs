using DiplomaOborotovIS.data.api.model.provider;
using System.Collections.Generic;

namespace DiplomaOborotovIS.data.api.model.warehouse
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
