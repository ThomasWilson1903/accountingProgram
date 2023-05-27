namespace DiplomaOborotovIS.data.api.model.supply
{
    internal class CreateSupplyDto
    {
        public int Quantity { get; set; }
        public int ProductId { get; set; } = new();
        public int ProviderId { get; set; } = new();
        public int WarehouseId { get; set; } = new();
    }
}
