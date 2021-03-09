using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SUN.DOTNET31.WebAPI.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController:ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }


        public string Index() {
            _logger.LogInformation("你好");
            return "Hello World";
        }
    }
}
