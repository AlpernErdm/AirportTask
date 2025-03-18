using AirportTask.Business;
using Microsoft.AspNetCore.Mvc;

namespace AirportTask.Controllers
{
    [Route("api/runway")]
    [ApiController]
    public class RunwayController : ControllerBase
    {
        private readonly IRunwayService _runwayService;

        public RunwayController(IRunwayService runwayService)
        {
            _runwayService = runwayService;
        }

        [HttpPost("transfer")]
        public async Task<IActionResult> TransferRunway()
        {
            await _runwayService.TransferRunwayDataAsync();
            return Ok("Veriler başarıyla aktarıldı!");
        }
    }
}
