using Gen_Cqrs_API_Project.ManuelCQRS.Queries.Request;
using Gen_Cqrs_API_Project.ManuelCQRS.Queries.Response;
using Gen_Cqrs_API_Project.Models;

namespace Gen_Cqrs_API_Project.ManuelCQRS.Handlers.QueryHandler
{
    public class GetByIdProductQueryHandler
    {
        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest request)
        {
            var product = ApplicationDbContext.PrdoductList.FirstOrDefault(p => p.Id == request.Id);
            if (product == null)
            {
                throw new Exception("Product not found."); 
            }
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                CreateDTime = product.CreateTime
            };
        }
    }
}
