using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Petstore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        private static List<Pet> _pets;
        private readonly ILogger<PetsController> _logger;

        public PetsController(ILogger<PetsController> logger)
        {
            _logger = logger;

            if (_pets != null)
                return;

            InitializatePets();
        }

        [HttpGet]
        public IEnumerable<Pet> Get()
        {
            return _pets;
        }

        [HttpPost]
        public IActionResult Post(Pet pet)
        {
            Add(pet);
            return Ok();
        }

        private void InitializatePets()
        {
            _pets = new List<Pet>();
            _pets.AddRange(new [] {
                new Pet("123", "collar perro", "perro"),
                new Pet("124", "collar gato", "gato")
            });
        }

        private void Add(Pet pet)
        {
            _pets.Add(pet);
        }
    }
}
