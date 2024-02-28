using Application.Common.GenericResponse;
using Application.Services.BookServices.Interface;
using MediatR;


namespace Application.Features.Commands.InsertBook
{
    public class InsertBookHandler : IRequestHandler<InsertBookReqest, EndpointResponse<InsertBookResponse>>
    {


        public readonly IBookService _bookService;

        public InsertBookHandler(IBookService bookService)
        {
            _bookService = bookService;
        }



        public async Task<EndpointResponse<InsertBookResponse>> Handle(InsertBookReqest reqest, CancellationToken cancellationToken)
        {
          bool checker = _bookService.BookInsert(new Domain.Entities.Book()
            {
                Title=reqest.title,
                Description=reqest.description,
                Price=reqest.price,
            });
            return new EndpointResponse<InsertBookResponse>()
            {
                ErrorCode = Domain.Enum.ErrorCodes.Success,
                Result = new InsertBookResponse()
                {
                    Message = "Opration went well"
                }
            };
        }
    }
}
