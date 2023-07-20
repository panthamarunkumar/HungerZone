using AutoMapper;
using HungerZone.Services.CouponAPI.Data;
using HungerZone.Services.CouponAPI.Model;
using HungerZone.Services.CouponAPI.Model.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace HungerZone.Services.CouponAPI.Controllers
{
    [Route("api/coupon")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;
        private ResponseDto _responseDto;
        private  IMapper _mapper;
        public CouponAPIController(AppDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _responseDto = new ResponseDto();
            
        }
        [HttpGet]
        public ResponseDto GetAllCoupons()
        {
            try
            {
                IEnumerable<Coupon> objlist = _db.Coupons.ToList();
                _responseDto.Result = _mapper.Map<IEnumerable<CouponDto>>(objlist);




            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess= false;
                _responseDto.Message= ex.Message;
              
            }
            return _responseDto;
        }
        [HttpGet]
        [Route("{id:int}")]
        public ResponseDto  GetCouponById(int id)
        {
            try
            {
                Coupon obj = _db.Coupons.First(u => u.CouponId == id);
               _responseDto.Result= _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess= false;
                _responseDto.Message= ex.Message;

            }
            return _responseDto;
        }

        [HttpGet]
        [Route("GetByCode/{code}")]
        public ResponseDto  GetCouponByCode(String code)
        {
            try
            {
                Coupon obj = _db.Coupons.FirstOrDefault(u => u.CouponCode.ToLower() == code.ToLower());
                _responseDto.Result = _mapper.Map<CouponDto>(obj);
                 
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess= false;  
                _responseDto.Message= ex.Message;
                
            }
            return _responseDto;
        }
        [HttpPost]
        public ResponseDto CreateACoupon([FromBody] CouponDto couponDto)
        {
            try
            {
              
                Coupon obj = _mapper.Map<Coupon>(couponDto);
               

                _db.Coupons.Add(obj);
               _db.SaveChangesAsync();
                _responseDto.Result= _mapper.Map<CouponDto>(obj);

              

                
            }
            catch (Exception ex)
            {
               _responseDto.IsSuccess= false;
                    _responseDto.Message= ex.Message;
            }
            return _responseDto;
            
        }
        [HttpPut] 
        [Route("UpdateCouponData")]
        public ResponseDto UpdateCouponData(CouponDto couponDto)
        {
            try
            {
                Coupon obj = _mapper.Map<Coupon>(couponDto);
                _db.Coupons.Update(obj);
                _db.SaveChangesAsync();
                _responseDto.Result=_mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess= false;
                _responseDto.Message= ex.Message;

            }
            return _responseDto;

        


        }
        [HttpDelete]
        [Route("{id:int}")]
        public ResponseDto DeleteCoupon(int id )
        {
            try
            {
                Coupon obj = _db.Coupons.First(u => u.CouponId == id);
                _db.Coupons.Remove(obj);
                _db.SaveChangesAsync();
                _responseDto.Result= _mapper.Map<CouponDto>(obj);
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess= false;
                _responseDto.Message= ex.Message;

            }
            return _responseDto;
            
        }


    }
}
