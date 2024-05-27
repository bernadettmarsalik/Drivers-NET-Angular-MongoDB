using Drivers.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Drivers.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DriversController : ControllerBase {
  
private readonly ILogger<DriversController> _logger;
private readonly DriverService _driverService;

public DriversController(ILogger<DriversController> logger,
DriverService driverService) {
  _logger = logger;
  _driverService = driverService;
}

[HttpGet]
public async Task<IActionResult> GetDrivers() 
{
  var drivers = await _driverService.GetAsync();
  return Ok(drivers);
}

}