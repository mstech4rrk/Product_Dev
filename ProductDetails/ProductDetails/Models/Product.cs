namespace ProductDetails.Models
{
    public class Product
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string Description { get; set; }
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }

        public bool IsAvailable
        {
            get
            {
                return Quantity > 0 ? true : false;
            }
        }

        public override string ToString()
        {
            return $"Product [Id={Id}, Name={Name}, Description={Description}, Price={Price}, Quantity={Quantity}, IsAvailable = {IsAvailable}]";
        }
    }
}
