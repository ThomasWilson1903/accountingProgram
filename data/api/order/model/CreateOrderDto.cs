namespace DiplomaOborotovIS.data.api.model.order
{
    internal class CreateOrderDto
    {
        public string Addres { get; set; } = string.Empty;
        public int ProductId { get; set; } = new();
        public int Quantity { get; set; }
    }
}
