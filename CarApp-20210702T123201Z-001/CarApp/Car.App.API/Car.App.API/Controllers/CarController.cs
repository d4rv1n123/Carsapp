using Car.App.API.Models;
using Car.App.API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car.App.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<CarModel>> GetCars()
        {
            return await _carRepository.GetCars();
        }

        [HttpPost]
        public async Task<ActionResult<CarModel>> AddCar([FromBody] CarModel car)
        {
            var newCar = await _carRepository.AddCar(car);
            return CreatedAtAction(nameof(GetCars),new { id = newCar.Id }, newCar);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deletedCar = await _carRepository.DeleteCar(id);
            if (deletedCar == null) return NotFound();
            return NoContent();
        }
    }
}
