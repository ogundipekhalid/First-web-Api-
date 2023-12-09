using System.Threading.Tasks;
using LinkedOut.Dtos.RequestModels;
using LinkedOut.Interface.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace First_web_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoleController : ControllerBase
    {
            private readonly IRoleService _roleService;
            public RoleController(IRoleService roleService)
            {
                _roleService = roleService;
            }
            [HttpPost]
            public async Task<IActionResult> Post([FromForm]CreateRoleRequestModel request)
            {
                var isSuccessful = await _roleService.CreateRole(request);
                if (isSuccessful.Success == false)
                {
                    return BadRequest(isSuccessful);
                }
                return Ok(isSuccessful);
            }
    }
}