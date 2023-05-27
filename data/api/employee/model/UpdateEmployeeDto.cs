namespace DiplomaOborotovIS.data.api.model.employee
{
    internal class UpdateEmployeeDto
    {
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int WarehouseId { get; set; } = new();
        public string Login { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MidleName { get; set; } = string.Empty;
    }
}
