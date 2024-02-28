using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Queries.GetAllBooks
{
    public class GetAllBooksResponse
    {
        public int Id {  get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; } = 0;
    }
}
