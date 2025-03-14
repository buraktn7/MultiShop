namespace MultiShop.Catalog.Dtos.ProductDtos
{
    public class UpdateProductDto
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int ProductImageUrl { get; set; }
        public int ProductDescription { get; set; }
        public string CategoryId { get; set; }
    }
}
