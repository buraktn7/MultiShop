using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int ProductImageUrl { get; set; }
        public int ProductDescription { get; set; }
        public string  CategoryId { get; set; }
        [BsonIgnore]
        public Category Category { get; set; }
    }
}
