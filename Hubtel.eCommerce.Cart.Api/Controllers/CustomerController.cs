//using AutoMapper;
//using Hubtel.eCommerce.Cart.Api.Data.Interfaces;
//using Hubtel.eCommerce.Cart.Api.DTOs;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace Hubtel.eCommerce.Customer.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CustomerController : ControllerBase
//    {
//        private readonly ICustomer _customerRepository;
//        private readonly IMapper _mapper;
//        public CustomerController(ICustomer customerRepository, IMapper mapper)
//        {
//            _customerRepository = customerRepository;
//            _mapper = mapper;
//        }

//        // GET: api/<CustomerController>
//        [HttpGet]
//        public async Task<IActionResult> Get()
//        {
//            var results = await _customerRepository.GetAllAsync();
//            var customers = _mapper.Map<List<Cart.Api.Entities.Customer>>(results);

//            return Ok(customers);
//        }

//        // GET api/<CustomerController>/5
//        [HttpGet("{id}")]
//        public async Task<IActionResult> Get(int id)
//        {

//            var result = await _customerRepository.GetByIdAsync(id);
//            var customer = _mapper.Map<Cart.Api.Entities.Customer>(result);

//            return Ok(customer);
//        }

//        // POST api/<CustomerController>
//        [HttpPost]
//        public async Task<IActionResult> Post([FromBody] CustomerDto  customerDto)
//        {
//            var customer = _mapper.Map<Cart.Api.Entities.Customer>(customerDto);
//            _customerRepository.Insert(customer);

//            await _customerRepository.SaveAsync();

//            return Ok();
//        }

//        // PUT api/<CustomerController>/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> Put(int id, [FromBody] CustomerDto  customerDto)
//        {
//            if (id != customerDto.Id)
//            {
//                return BadRequest();
//            }
//            var customer = _mapper.Map<Cart.Api.Entities.Customer>(customerDto);
//            _customerRepository.Update(customer);

//            await _customerRepository.SaveAsync();

//            return NoContent();
//        }

//        // DELETE api/<CustomerController>/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> Delete(int id)
//        {
//            var customerToRemove = _customerRepository.GetById(id);
//            if (customerToRemove != null)
//            {
//                return NotFound();
//            }
//            _customerRepository.Delete(customerToRemove.Id);
//            await _customerRepository.SaveAsync();

//            return NoContent();
//        }
//    }
//}
