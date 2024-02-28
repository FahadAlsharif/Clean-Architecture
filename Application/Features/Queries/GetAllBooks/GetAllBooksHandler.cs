using Application.Common.GenericResponse;
using Application.Services.BookServices.Interface;
using MediatR;

namespace Application.Features.Queries.GetAllBooks
{
    public class GetAllBooksHandler : IRequestHandler<GetAllBooksRequest, EndpointResponse<List<GetAllBooksResponse>>>
    {

        public readonly IBookService _bookService;

        public GetAllBooksHandler(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<EndpointResponse<List<GetAllBooksResponse>>> Handle(GetAllBooksRequest request, CancellationToken cancellationToken)
        {
            try
            {
                return new EndpointResponse<List<GetAllBooksResponse>>
                {
                    Result = _bookService.GetBooks().Select(x => new GetAllBooksResponse()
                    {
                        Id = x.Id,
                        Description = x.Description,
                        Price = Decimal.ToDouble(x.Price),
                        Title = x.Title,
                    }).ToList()
                };
            } catch (Exception ex)
            {
                return new EndpointResponse<List<GetAllBooksResponse>>
                {
                    ErrorCode = Domain.Enum.ErrorCodes.ServerException,
                    ErrorDescription = ex.Message,
                };
            }
        }
    }
}

