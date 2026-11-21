using Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Request;
using Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Response;
using Gen_Cqrs_API_Project.Models;
using MediatR;

namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Handlers.QueryHandler
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product = ApplicationDbContext.PrdoductList.FirstOrDefault(p => p.Id == request.Id);
            if (product == null)
            {
                throw new Exception("Product not found.");
            }
            return new GetByIdProductQueryResponse
            {
                ProductId = product.Id,
                ProductName = product.Name,
                ProductPrice = product.Price
            };
        }
    }
}
