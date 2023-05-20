using Microsoft.AspNetCore.Mvc;
using PPPI.Services.Characteristic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PPPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacteristicController : ControllerBase
    {
        private readonly ICharacteristicData _characteristictData;

        public CharacteristicController(ICharacteristicData characteristicData)
        {
            _characteristictData = characteristicData;
        }

        // GET api/<CharacteristicController>/5
        [HttpGet("{id}")]
        public async Task<String> Get(int id)
        {
            return await _characteristictData.Get(id);
        }

        // GETALL api/<CharacteristicController>
        [HttpGet]
        public async Task<String> GetAll()
        {
            return await _characteristictData.GetAll();
        }

        // POST api/<CharacteristicController>
        [HttpPost]
        public async Task Post([FromQuery] string torque, [FromQuery] string engineCapacity, [FromQuery] string hp)
        {
            await _characteristictData.Post(torque, engineCapacity, hp);
        }

        // PUT api/<CharacteristicController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromQuery] string torque, [FromQuery] string engineCapacity, [FromQuery] string hp)
        {
            await _characteristictData.Put(id, torque, engineCapacity, hp);
        }

        // DELETE api/<CharacteristicController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _characteristictData.Delete(id);
        }
    }
}
