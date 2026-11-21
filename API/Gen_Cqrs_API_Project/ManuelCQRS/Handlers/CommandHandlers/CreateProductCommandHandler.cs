using Gen_Cqrs_API_Project.ManuelCQRS.Commands.Request;
using Gen_Cqrs_API_Project.ManuelCQRS.Commands.Response;
using Gen_Cqrs_API_Project.Models;

namespace Gen_Cqrs_API_Project.ManuelCQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest request)
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
