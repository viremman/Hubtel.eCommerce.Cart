using AutoMapper;
using Hubtel.eCommerce.Cart.Api.Data.Interfaces;
using Hubtel.eCommerce.Cart.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hubtel.eCommerce.Cart.Api.Controllers
{
    [Route("api/carts")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICart _cartRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<CartController> _logger;
        public CartController(ICart cartRepository, IMapper mapper, ILogger<CartController> logger)
        {
            _cartRepository = cartRepository;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<CartController>
        [HttpGet]
        public async Task<IActionResult> Get(string phoneNumber, DateTime? time, int? quantity, int? itemId)
        {
            var query = await _cartRepository.GetAllAsync();
            if (!string.IsNullOrEmpty(phoneNumber))
            {
                query = query.Where(s => s.PhoneNumber == phoneNumber);
            }
            if (time != null)
            {
                query = query.Where(s => s.CreatedAt == time);
            }
            if (quantity != null)
            {
                query = query.Where(s => s.Quantity == quantity);
            }
            if (itemId != null)
            {
                query = query.Where(s => s.ItemID == itemId);
            }
            var results = query.OrderBy(s => s.CreatedAt).ToList();
            var carts = _mapper.Map<List<Entities.Cart>>(results);

            return Ok(carts);
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var cart = await _cartRepository.GetByIdAsync(id);

            return Ok(cart);
        }

        // POST api/<CartController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CartDto cartDto)
        {
            if (cartDto == null)
            {
                BadRequest("Cart cannot be empty");
            }
            if (string.IsNullOrEmpty(cartDto.PhoneNumber))
            {
                BadRequest("Phone Number cannot be null");
            }
            if (cartDto.Quantity <= 0)
            {
                BadRequest("Item Quantity must be greater than 0");
            }

            var cartToCheck = _cartRepository.Find(s => s.ItemID == cartDto.ItemID
            && s.PhoneNumber == cartDto.PhoneNumber).FirstOrDefault();

            try
            {
                if (cartToCheck == null)
                {
                    var cart = _mapper.Map<Entities.Cart>(cartDto);
                    cart.CreatedAt = DateTime.Now;
                    _cartRepository.Insert(cart);
                }
                else
                {
                    cartToCheck.Quantity = cartDto.Quantity;
                    cartToCheck.UpdatedAt = DateTime.Now;
                    _cartRepository.Update(cartToCheck);
                }
                await _cartRepository.SaveAsync();

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return BadRequest();
        }

        // PUT api/<CartController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] CartDto cartDto)
        //{
        //    if (id != cartDto.Id)
        //    {
        //        return BadRequest();
        //    }

        //    var cart = _mapper.Map<Entities.Cart>(cartDto);
        //    _cartRepository.Update(cart);
        //    await _cartRepository.SaveAsync();

        //    return NoContent();
        //}

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var cartToRemove = _cartRepository.GetById(id);
            if (cartToRemove != null)
            {
                return NotFound();
            }
            _cartRepository.Delete(cartToRemove.Id);
            await _cartRepository.SaveAsync();

            return NoContent();
        }
    }
}
