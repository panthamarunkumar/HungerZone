
using HungerZone.Web.Models;


using Microsoft.AspNetCore.Mvc;

namespace HungerZone.Web.Service.Iservice
{
    public interface ICouponService
    {
        Task<ResponseDto?> GetCouponAsync(string Couponcode);
        Task<ResponseDto?> GetAllCouponsAsync();
        Task<ResponseDto?> GetCouponsByIdAsync(int id);
        Task<ResponseDto?> CreateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto?> UpdateCouponsAsync(CouponDto couponDto);
        Task<ResponseDto> DeleteCouponsAsync(int id);
    }

}   
