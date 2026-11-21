namespace Gen_Cqrs_API_Project.ManuelCQRS.Queries.Request
{
    public class GetByIdProductQueryRequest
    {
        public GetByIdProductQueryRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}