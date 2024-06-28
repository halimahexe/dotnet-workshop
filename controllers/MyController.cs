// imports useful methods for setting up a controller
using Microsoft.AspNetCore.Mvc;
// sets up an api controller
namespace MyApi.AddControllers {
    [ApiController]
    [Route("[controller]")]
    public class HelloController: ControllerBase {
        // creates our get route
        [HttpGet]
        public string Get() {
            // decides what is returned by the route
            return "Hello, World!";
        }
    }
}