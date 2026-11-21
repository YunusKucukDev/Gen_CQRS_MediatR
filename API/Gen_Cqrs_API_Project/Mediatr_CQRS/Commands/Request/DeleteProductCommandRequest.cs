using Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Response;
using MediatR;

namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Request
{
    public class DeleteProductCommandRequest : IRequest<DeleteProductCommandResponse>
    {
        public Guid ProductId { get; set; }
    }
}
