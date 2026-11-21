namespace Gen_Cqrs_API_Project.ManuelCQRS.Commands.Response
{
    public class CreateProductCommandResponse
    {
        public bool IsSuccess { get; set; }
        public Guid ProductId { get; set; }
    }
}
