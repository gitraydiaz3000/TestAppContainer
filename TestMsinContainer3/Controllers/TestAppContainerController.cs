using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestAppContainer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestAppContainerController : ControllerBase
    {
        private static readonly string[] Activities = new[]
        {
            "Login Test"
        };

        private readonly ILogger<TestAppContainerController> _logger;

        public TestAppContainerController(ILogger<TestAppContainerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<LoginTemplate> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new LoginTemplate
            {
                Activity = Activities[rng.Next(Activities.Length)]
            })
            .ToArray();
        }
    }
}
