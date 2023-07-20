using Microsoft.AspNetCore.Mvc;
using static HungerZone.Web.Utility.StaticDetails;

namespace HungerZone.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
