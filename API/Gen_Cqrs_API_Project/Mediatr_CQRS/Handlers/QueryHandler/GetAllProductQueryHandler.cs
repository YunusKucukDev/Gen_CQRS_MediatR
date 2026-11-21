using Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Request;
using Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Response;
using Gen_Cqrs_API_Project.Models;
using MediatR;

namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Handlers.QueryHandler
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, List<GetAllProductQueryResponse>>
    {
        public async Task<List<GetAllProductQueryResponse>> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            return ApplicationDbContext.PrdoductList
                    .Select(p => new GetAllProductQueryResponse
                    {
                        Id = p.Id,
                        Name = p.Name,
                        Quantity = p.Quantity,
                        Price = p.Price,
                        CreateDate = p.CreateTime
                    })
                    .ToList();
        }
    }
}

