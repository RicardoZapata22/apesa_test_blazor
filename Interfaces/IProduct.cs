namespace apesa_test.Interfaces{
    public class Product {
        public string name {get; set; }
        public string type {get; set; }
        public double interest_rate {get; set; } = 0;
        public Product(string name = "", string type = "", double interest_rate = 0.0){
            this.name = name;
            this.type = type;
            this.interest_rate = interest_rate;
        }


    }
}