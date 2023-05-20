using Microsoft.AspNetCore.Mvc;
using PPPI.Services.Owner;


namespace PPPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerData _ownerData;

        public OwnerController(IOwnerData ownerData)
        {
            _ownerData = ownerData;
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public async Task<String> Get(int id)
        {
            return await _ownerData.Get(id);
        }

        // GETALL api/<OwnerController>
        [HttpGet]
        public async Task<String> GetAll()
        {
            return await _ownerData.GetAll();
        }

        // POST api/<OwnerController>
        [HttpPost]
        public async Task Post([FromQuery] string name, [FromQuery] string surname, [FromQuery] string age)
        {
            await _ownerData.Post(name, surname, age);
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromQuery] string name, [FromQuery] string surname, [FromQuery] string age)
        {
            await _ownerData.Put(id, name, surname, age);
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _ownerData.Delete(id);
        }
    }
}
