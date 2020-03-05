using Microsoft.AspNetCore.Mvc;
using SharentAPI.ExternalServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallbackController : ControllerBase
    {
        private VkApiService vkApiService = new VkApiService();

        public CallbackController()
        {

        }
        [HttpGet]
        public ActionResult<bool> VkAuth(string code)
        {
            var token = vkApiService.Authorize(code);
            return true;
        }
    }
}
