using GroceryStoreSimulatorWebAPI.Models;
using GroceryStoreSimulatorWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryStoreSimulatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly StoresService storesService;

        public StoresController(StoresService storesService)
        {
            this.storesService = storesService;
        }
        // GET: api/<StoresController>
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            return storesService.GetStores();
        }

        // GET api/<StoresController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StoresController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
