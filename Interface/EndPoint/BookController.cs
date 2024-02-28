using Application.Common.GenericResponse;
using Application.Features.Commands.InsertBook;
using Application.Features.Queries.GetAllBooks;
using Application.Features.Queries.GetLibrarys;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Controllers
{

    public class BookController : ApiControllerBase
    {
        [HttpGet("GetAllBooks")]
        public async Task<EndpointResponse<List<GetAllBooksResponse>>> GetAllBooks()
        {
            return await Mediator.Send(new GetAllBooksRequest());
        }

        [HttpPost]
        [Route("InsertBook")]
        public async Task<EndpointResponse<InsertBookResponse>> InsertBook([FromBody] InsertBookReqest reqest)
        {
            return await Mediator.Send(reqest);
        }

        [HttpGet("GetLibrary")]
        public async Task<EndpointResponse<List<GetLibrarysResponse>>> GetLibrary()
        {
            return await Mediator.Send(new GetLibrarysRequest());
        }

/*        [HttpDelete]
        [Route("Deletebook/{id}")]
        public async Task<EndpointResponse<InsertBookResponse>> Deletebook(int id)
        {
            return await Mediator.Send(id);
        }*/
    }
}
