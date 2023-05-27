using DiplomaOborotovIS.data.api.model.warehouse;
using System.Collections.Generic;

namespace DiplomaOborotovIS.data.api.model.provider
{
    public class Provider
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string MidleName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Photo { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

    }
}
