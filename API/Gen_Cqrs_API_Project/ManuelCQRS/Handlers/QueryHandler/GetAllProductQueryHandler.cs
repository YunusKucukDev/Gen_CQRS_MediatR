using Gen_Cqrs_API_Project.ManuelCQRS.Queries.Request;
using Gen_Cqrs_API_Project.ManuelCQRS.Queries.Response;
using Gen_Cqrs_API_Project.Models;

namespace Gen_Cqrs_API_Project.ManuelCQRS.Handlers.QueryHandler
{
    public class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAllProduct()
        {
            return ApplicationDbContext.PrdoductList
                .Select(p => new GetAllProductQueryResponse
                {
                    Id = p.Id,
                    Name = p.Name,
                    Quantity = p.Quantity,
                    Price = p.Price,
                    CreateDTime = p.CreateTime
                })
                .ToList();
        }
    }
}
