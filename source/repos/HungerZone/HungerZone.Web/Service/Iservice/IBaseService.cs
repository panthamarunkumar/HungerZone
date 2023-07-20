using HungerZone.Web.Models;
//using HungerZone.Web.CouponAPI.Model;
using HungerZone.Web.Models;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace HungerZone.Web.Service.Iservice
{

    /// <summary>
    /// this interface ibaseservice have method that calls all the endpoints.
    /// </summary>
    public interface IBaseService
    {
       Task<ResponseDto?> SendAsync(RequestDto requestDto);
    }
}
