using Microsoft.AspNetCore.Mvc;
using StoreApi.Entities;

namespace StoreApi.Controllers
{
    [Route("StoreApi/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private static List<Customer> _customers = new()
        {
            new Customer
            {
                Id = 1,
                Name = "Peter Parker",
                CustomerAddress1 = "HowardStreet",
                CustomerAddress2 = "233 44 NEW YORK",
                Email = "peter@howard.com"
            },
            new Customer
            {
                Id = 2,
                Name = "RoboCop",
                CustomerAddress1 = "AiStreet",
                CustomerAddress2 = "111 44 NEW YORK",
                Email = "RoboCop@howard.com"
            },
            new Customer
            {
                Id = 3,
                Name = "John Saxberg",
                CustomerAddress1 = "Saxbergen",
                CustomerAddress2 = "121 44 SWEDEN",
                Email = "John@Saxberg.com"
            }
        };


        [HttpGet]
        public ActionResult<List<Customer>> GetCustomers()
        {
            return Ok(_customers);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customer = _customers.FirstOrDefault(p => p.Id == id);

            if (customer is null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public ActionResult<Customer> AddCustomer(Customer newCustomer)
        {
            if (newCustomer is null)
            {
                return BadRequest();
            }

            newCustomer.Id = _customers.Max(p => p.Id) + 1;
            _customers.Add(newCustomer);

            return CreatedAtAction(nameof(GetCustomerById), new { id = newCustomer.Id }, newCustomer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, Customer updatedCustomer)
        {
            var oldCustomer = _customers.FirstOrDefault(p => p.Id == id);
            if (oldCustomer is null)
            {
                return NotFound();
            }

            oldCustomer.Name = updatedCustomer.Name;
            oldCustomer.Email = updatedCustomer.Email;
            oldCustomer.CustomerAddress1 = updatedCustomer.CustomerAddress1;
            oldCustomer.CustomerAddress2 = updatedCustomer.CustomerAddress2;
            oldCustomer.CustomerAddress3 = updatedCustomer.CustomerAddress3;

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var customerToBeDeleted = _customers.FirstOrDefault(p => p.Id == id);
            if (customerToBeDeleted is null)
            {
                return NotFound();
            }

            _customers.Remove(customerToBeDeleted);
            return Ok();
        }
    }
}
