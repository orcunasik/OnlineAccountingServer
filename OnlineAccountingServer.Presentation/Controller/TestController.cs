using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controller
{
    public sealed class TestController : ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("İşlem Başarılı");
        }
    }
}
