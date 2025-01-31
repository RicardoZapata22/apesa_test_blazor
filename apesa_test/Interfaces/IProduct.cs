using System.Text.Json.Serialization;

namespace apesa_test.Interfaces{

    public class IProduct: ICloneable {
        [JsonPropertyName("product_id")]
        public string? ProductId { get; set; } = "";

        [JsonPropertyName("name")]
        public string? Name {get; set; }

        [JsonPropertyName("product_type")]
        public string? ProductType {get; set; }

        [JsonPropertyName("interest_rate")]
        public double InterestRate {get; set; } = 0;

        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}