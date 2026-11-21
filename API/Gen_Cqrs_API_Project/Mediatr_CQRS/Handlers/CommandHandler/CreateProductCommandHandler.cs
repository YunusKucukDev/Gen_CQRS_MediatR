using Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Request;
using Gen_Cqrs_API_Project.Mediatr_CQRS.Commands.Response;
using Gen_Cqrs_API_Project.Models;
using MediatR;

namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Handlers.CommandHandler
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var id = Guid.NewGuid();

            ApplicationDbContext.PrdoductList.Add(new Product
            {
                Id = id,
                Name = request.Name,
                Quantity = request.Quantity,
                Price = request.Price
            });
            return new CreateProductCommandResponse
            {
                ProductId = id,
                IsSuccess = true
            };
        }
    }
}
