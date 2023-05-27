using DiplomaOborotovIS.data.api.model.warehouse;

namespace DiplomaOborotovIS.data.api.model.employee
{
    internal class Employee
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Warehouse Warehouse { get; set; } = new();
    }
}
