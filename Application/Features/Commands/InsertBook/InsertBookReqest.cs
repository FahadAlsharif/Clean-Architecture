using Application.Common.GenericResponse;
using MediatR;


namespace Application.Features.Commands.InsertBook
{
    public class InsertBookReqest : IRequest<EndpointResponse<InsertBookResponse>>
    {
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
    }
}
