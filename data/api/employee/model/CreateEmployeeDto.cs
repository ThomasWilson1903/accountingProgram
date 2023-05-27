using System.ComponentModel.DataAnnotations;

namespace DiplomaOborotovIS.data.api.model.employee
{
    internal class CreateEmployeeDto
    {
        public int UserId { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int WarehouseId { get; set; } = new();
    }
}
