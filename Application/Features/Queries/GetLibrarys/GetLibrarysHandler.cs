using Application.Common.GenericResponse;
using Application.Services.BookServices.Interface;
using MediatR;


namespace Application.Features.Queries.GetLibrarys
{
    public class GetLibrarysHandler : IRequestHandler<GetLibrarysRequest,EndpointResponse<List<GetLibrarysResponse>>>
    {
        public readonly IBookService bookService;

        public GetLibrarysHandler(IBookService bookService)
        {
            this.bookService = bookService;
        }
        public async Task<EndpointResponse<List<GetLibrarysResponse>>> Handle(GetLibrarysRequest request, CancellationToken cancellationToken)
        {
            try
            {
            return new EndpointResponse<List<GetLibrarysResponse>>
            {
                Result = bookService.GetLibrarys().Select(c => new GetLibrarysResponse()
                { Name = c.Name, Size = c.Size, }).ToList()
                
            };
            }catch (Exception ex)
            {
                return new EndpointResponse<List<GetLibrarysResponse>>
                {
                    ErrorCode = Domain.Enum.ErrorCodes.ServerException,
                    ErrorDescription = ex.Message,

                };
            }
        }
    }
}
