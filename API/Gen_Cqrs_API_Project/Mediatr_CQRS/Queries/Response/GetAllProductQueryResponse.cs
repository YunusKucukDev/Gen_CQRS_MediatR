namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Response
{
    public class GetAllProductQueryResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreateDate { get; set; }
        public int Quantity { get; set; }
    }
}
