namespace TechMartProductManager
{
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string CategoryValue { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public string Avatar { get; set; }
    }

    public class Category
    {
        public string Value { get; set; }
        public string Name { get; set; }

        public Category(string value, string name)
        {
            Value = value;
            Name = name;
        }
    }
}