namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Response
{
    public class DeleteProductCommandResponse
    {
        public bool IsSuccess { get; set; }
        public string ProductName { get; set; }
        public Guid ProductId { get; set; }
    }
}
