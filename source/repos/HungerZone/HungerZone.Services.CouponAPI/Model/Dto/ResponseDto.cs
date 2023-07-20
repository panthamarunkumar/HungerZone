using System.Globalization;

namespace HungerZone.Services.CouponAPI.Model.Dto
{
    public class ResponseDto
    {
        public object? Result { get;set; }
        public bool? IsSuccess { get; set; } = true;
        public String Message { get; set; } = "";

    }
}
