using AutoMapper;
using HungerZone.Services.CouponAPI.Model;
using HungerZone.Services.CouponAPI.Model.Dto;

namespace HungerZone.Services.CouponAPI
{
    public class MappingConfiguration
    {
        public static MapperConfiguration RegisterMaps()
        {
          var mappingconfig= new MapperConfiguration(Config =>
          {
              Config.CreateMap<CouponDto, Coupon>();
              Config.CreateMap<Coupon, CouponDto>();

          });
            return mappingconfig;
        }
    }
}
