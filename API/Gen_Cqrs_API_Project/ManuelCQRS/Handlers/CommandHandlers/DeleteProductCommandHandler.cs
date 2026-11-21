using Gen_Cqrs_API_Project.ManuelCQRS.Commands.Request;
using Gen_Cqrs_API_Project.ManuelCQRS.Commands.Response;
using Gen_Cqrs_API_Project.Models;

namespace Gen_Cqrs_API_Project.ManuelCQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest request)
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
                };
            }
        }
    }
}
