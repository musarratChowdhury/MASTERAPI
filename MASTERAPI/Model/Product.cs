using System.Text.Json.Serialization;

namespace MASTERAPI.Model
{
    public class Product:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool isAvailable { get; set; }

        public int? CategoryId { get; set; }
        [JsonIgnore]
        public virtual Category? Category { get; set; }
    }
}
