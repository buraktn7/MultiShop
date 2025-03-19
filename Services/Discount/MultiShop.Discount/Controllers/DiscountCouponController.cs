using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountCouponController(IDiscountService discountService)
        {
            _discountService = discountService;
        }
        [HttpGet]
        public async Task<IActionResult> getAllCuopon()
        {
            var values = await _discountService.GetAllCouponAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCoupon(CreateCouponDto createCouponDto)
        {
            await _discountService.CreateCouponAsync(createCouponDto);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCoupon(int Id)
        {
            await _discountService.DeleteCouponAsync(Id);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCoupon(int Id)
        {
            var values = await _discountService.GetByIdCouponAsync(Id);
            return Ok (values);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCoupon(UpdateCouponDto updateCouponDto)
        {
            await _discountService.UpdateCouponAsync(updateCouponDto);
            return Ok();
        }
    }
}
