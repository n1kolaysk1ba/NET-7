using Microsoft.AspNetCore.Mvc;
using PPPI.Services.Car;


namespace PPPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarData _carData;

        public CarController(ICarData carData) {
            _carData = carData;
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public async Task<String> Get(int id)
        {
            return await _carData.Get(id);
        }

        // GETALL api/<CarController>
        [HttpGet]
        public async Task<String> GetAll()
        {
            return await _carData.GetAll();
        }

        // POST api/<CarController>
        [HttpPost]
        public async Task Post([FromQuery] string mark, [FromQuery] string model, [FromQuery] string serie)
        {
            await _carData.Post(mark, model, serie);
        }

        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromQuery] string mark, [FromQuery] string model, [FromQuery] string serie)
        {
            await _carData.Put(id, mark, model, serie);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _carData.Delete(id);
        }
    }
}
