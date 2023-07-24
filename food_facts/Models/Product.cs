namespace food_facts.Models
{
    public class Product
    {
        public int id { get; set; }
        public string barcode { get; set; } = string.Empty;
        public string product_name { get; set; } = string.Empty;
        public string brands { get; set; } = string.Empty;
        public string ingredients_text { get; set; } = string.Empty;
        public string allergens { get; set; } = string.Empty;

     
       
    }
}