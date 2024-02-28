using Domain.Enum;


namespace Application.Common.GenericResponse
{
    public class EndpointResponse<TResult>
    {
        public ErrorCodes ErrorCode { get; set; } = ErrorCodes.Success;
        public string ErrorDescription { get; set; } = "Operation went successfully";
        public TResult Result { get; set; }
    }
}
