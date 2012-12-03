namespace Console.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Value { get; set; }
    }
}
