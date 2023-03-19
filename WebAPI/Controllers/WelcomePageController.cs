using Bussiness.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WelcomePageController : ControllerBase
    {
        IWelcomePageService _welcomePageService;

        public WelcomePageController(IWelcomePageService welcomePageService)
        {
            _welcomePageService = welcomePageService;
        }
        [HttpPost("add")]
        public IActionResult Add(WelcomePage welcomePage)
        {
            var result = _welcomePageService.Add(welcomePage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(WelcomePage welcomePage)
        {
            var result = _welcomePageService.Delete(welcomePage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPut("update")]
        public IActionResult Update(WelcomePage welcomePage)
        {
            var result = _welcomePageService.Update(welcomePage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _welcomePageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
