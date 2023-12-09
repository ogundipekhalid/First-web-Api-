using System.Threading.Tasks;
using LinkedOut.Dtos.RequestModels;
using LinkedOut.Dtos.ResponseModel;

namespace LinkedOut.Interface.Services
{
    public interface IAdminService
    {
        Task<BaseResponse> AddAdmin(CreateAdminRequestModel model);
        Task<BaseResponse> DeleteAdmin(int Id);
        Task<AdminsResponseModel> GetAllAdmin();
        Task<AdminResponseModel> FindAdminAsync(LoginRequestModel model);
    }
}