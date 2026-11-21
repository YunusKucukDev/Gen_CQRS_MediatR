using Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Response;
using MediatR;

namespace Gen_Cqrs_API_Project.Mediatr_CQRS.Queries.Request
{
    public class GetByIdProductQueryRequest : IRequest<GetByIdProductQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
