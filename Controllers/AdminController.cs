using System.Threading.Tasks;
using LinkedOut.Dtos.RequestModels;
using LinkedOut.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace First_web_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
            private readonly IAdminService _adminService;
            public AdminController(IAdminService adminService)
            {
                _adminService = adminService;
            }
            [HttpPost("RegisterAdmin")]
            public async Task<IActionResult> RegisterAdmin([FromBody]CreateAdminRequestModel request)
            {
                var isSuccessful = await _adminService.AddAdmin(request);
                if (isSuccessful.Success == false)
                {
                    return BadRequest(isSuccessful);
                }
                return Ok(isSuccessful);
            }
            [HttpGet("GetAllAdmins")]
            public async Task<IActionResult> GetAllAdmins()
            {
                var admins = await _adminService.GetAllAdmin();
                if(admins.Success == false)
                {
                    return BadRequest(admins);
                }
                return Ok(admins);
            }

            [HttpPost("LoginAsAdmin")]
            public async Task<IActionResult> LoginAsAdmin([FromForm]LoginRequestModel request)
            {
                var admin = await _adminService.FindAdminAsync(request);
                if(admin.Success == false)
                {
                    return BadRequest(admin);
                }
                return Ok(admin);
            }
    }
}