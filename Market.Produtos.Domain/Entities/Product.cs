namespace Market.Produtos.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; protected set; }
        public string Brand { get; protected set; }
        public string Weight { get; protected set; }
        public string Price { get; protected set; }

        protected Product(){}

        public Product(string name, string brand, string weight, string price)
        {
            Name = name;
            Brand = brand;
            Weight = weight;
            Price = price;
        }

        public void Update(string name, string brand, string weight, string price)
        {
            Name = name;
            Brand = brand;
            Weight = weight;
            Price = price;
        }

    }
}
