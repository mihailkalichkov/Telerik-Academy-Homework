namespace Task02_OrderedBagUsage
{
    using System;

    public class Product : IComparable<Product>
    {
        public Product(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
