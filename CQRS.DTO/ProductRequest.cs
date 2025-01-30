namespace CQRS.DTO
{
    public class ProductRequest
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; }
        public double? Price { get; set; }
        public long? Stock { get; set; }

    }
}
