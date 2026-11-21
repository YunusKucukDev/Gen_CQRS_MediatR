using Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Request;
using Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Response;
using Gen_Cqrs_API_Project.Models;
using MediatR;

namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Handlers.CommandHandler
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, DeleteProductCommandResponse>
    {
        public async Task<DeleteProductCommandResponse> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.PrdoductList.FirstOrDefault(p => p.Id == request.ProductId);
            if (product != null)
            {
                ApplicationDbContext.PrdoductList.Remove(product);
                return new DeleteProductCommandResponse
                {
                    IsSuccess = true,
                };
            }
            else
            {
                return new DeleteProductCommandResponse
                {
                    IsSuccess = false,
                    ProductId = request.ProductId,
                };
            }
        }
    }
}
