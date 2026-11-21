namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Response
{
    public class GetByIdProductQueryResponse
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
