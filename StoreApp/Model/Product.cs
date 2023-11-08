namespace StoreApp.Models

{
    class Product : IComparable
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public double Price { get; set; }

        public int CompareTo(object? obj)
        {
            return this.Price.CompareTo((Product)obj);
        }
    }   
}