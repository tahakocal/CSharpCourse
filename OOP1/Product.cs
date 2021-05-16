namespace OOP1
{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  // ref anahtarlar ikinci siraya yazilir
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }

    }
}
