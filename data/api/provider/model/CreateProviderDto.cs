namespace DiplomaOborotovIS.data.api.model.provider
{
    internal class CreateProviderDto
    {
        public int UserId { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }
}
