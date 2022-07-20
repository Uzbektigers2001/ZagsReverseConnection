using Microsoft.AspNetCore.Mvc;
using ZagsReverseConnection.API.DbContexts;
using ZagsReverseConnection.API.Interfaces;
using ZagsReverseConnection.API.Models;

namespace ZagsReverseConnection.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDBContext dbcontext;
        private readonly IHomeService homeService;

        public HomeController(ApplicationDBContext DBContext, IHomeService service)
        {
            dbcontext = DBContext;
            homeService = service;
        }

        [HttpGet("Get")]
        public IActionResult GetFamily(string pinfl)
        {
            return Ok(homeService.GetFamily(pinfl));
        }

        [HttpPost("Post")]
        public IActionResult PostFamily(object family)
        {
            return Ok(homeService.PostFamilyAsync(family));
        }

        [HttpPost("Response")]
        public IActionResult ResponseResult(ResponseModel model)
        {
            try
            {
                homeService.ResposeResult(model);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }

        }

    }
}
