using System.Threading.Tasks;
using LinkedOut.Dtos.RequestModels;
using LinkedOut.Dtos.ResponseModel;

namespace LinkedOut.Interface.Services
{
    public interface IRoleService
    {
        Task<BaseResponse> CreateRole(CreateRoleRequestModel model);
        Task<RolesResponseModel> GetAllRoles(string name);
        Task<RoleResponseModel> GetRoleByAdminUsername(string name);
    }
}