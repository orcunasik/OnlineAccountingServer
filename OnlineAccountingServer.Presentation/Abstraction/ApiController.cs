using Microsoft.AspNetCore.Mvc;

namespace OnlineAccountingServer.Presentation.Abstraction
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
