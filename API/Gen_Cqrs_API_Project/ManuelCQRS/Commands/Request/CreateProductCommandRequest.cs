namespace Gen_Cqrs_API_Project.ManuelCQRS.Commands.Request
{
    public class CreateProductCommandRequest
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
