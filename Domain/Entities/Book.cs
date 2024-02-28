using Domain.Shared;

namespace Domain.Entities
{
    public class Book : BaseModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
