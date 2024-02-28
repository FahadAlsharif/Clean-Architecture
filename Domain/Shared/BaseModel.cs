using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString();
        public string? ModifyDate { get; set; } 
    }
}
