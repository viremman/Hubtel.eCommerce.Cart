//using AutoMapper;
//using Hubtel.eCommerce.Cart.Api.Data.Interfaces;
//using Hubtel.eCommerce.Cart.Api.DTOs;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Hubtel.eCommerce.Item.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ItemController : ControllerBase
//    {
//        private readonly IItem _itemRepository;
//        private readonly IMapper _mapper;
//        public ItemController(IItem itemRepository, IMapper mapper)
//        {
//            _itemRepository = itemRepository;
//            _mapper = mapper;
//        }

//        // GET: api/<ItemController>
//        [HttpGet]
//        public async Task<IActionResult> Get()
//        {
//            var results = await _itemRepository.GetAllAsync();
//            var items = _mapper.Map<List<Cart.Api.Entities.Item>>(results);

//            return Ok(items);
//        }

//        // GET api/<ItemController>/5
//        [HttpGet("{id}")]
//        public async Task<IActionResult> Get(int id)
//        {
//            var result = await _itemRepository.GetByIdAsync(id);
//            var item = _mapper.Map<ItemDto>(result);

//            return Ok(item);
//        }

//        // POST api/<ItemController>
//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] ItemDto itemDto)
//        {
//            var item = _mapper.Map<Cart.Api.Entities.Item>(itemDto);
//            _itemRepository.Insert(item);
//            await _itemRepository.SaveAsync();

//            return Ok();
//        }

//        // PUT api/<ItemController>/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> Put(int id, [FromBody] ItemDto itemDto)
//        {
//            if (id != itemDto.Id)
//            {
//                return BadRequest();
//            }
//            var item = _mapper.Map<Cart.Api.Entities.Item>(itemDto);
//            _itemRepository.Update(item);
//            await _itemRepository.SaveAsync();

//            return NoContent();
//        }

//        // DELETE api/<ItemController>/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            var itemToRemove = _itemRepository.GetById(id);
//            if (itemToRemove != null)
//            {
//                return NotFound();
//            }
//            _itemRepository.Delete(itemToRemove.Id);
//            await _itemRepository.SaveAsync();

//            return NoContent();
//        }
//    }
//}
