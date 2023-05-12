using System.Text.Json.Serialization;

namespace MASTERAPI.Model
{
    public class Category:IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public virtual List<Product>? Products { get; set; }
    }
}
