using Application.Common.GenericResponse;
using MediatR;


namespace Application.Features.Queries.GetLibrarys
{
    public class GetLibrarysRequest : IRequest<EndpointResponse<List<GetLibrarysResponse>>>
    {
        public int Id { get; set; }
    }
}
