using Application.Common.GenericResponse;
using MediatR;


namespace Application.Features.Queries.GetAllBooks
{
    public class GetAllBooksRequest : IRequest<EndpointResponse<List<GetAllBooksResponse>>>
    {
        public string lang { get; set; } = "en";
    }
}
