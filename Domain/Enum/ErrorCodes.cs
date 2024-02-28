using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enum
{
    public enum ErrorCodes
    {
        Success = 1,
        ServerException=2,
        NotSuccess=3,
        Failed=4,
        InvalidData=5,
        NotFound=6,
        NotValid=7
    }
}
