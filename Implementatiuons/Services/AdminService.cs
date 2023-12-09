using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using LinkedOut.Dtos;
using LinkedOut.Dtos.RequestModels;
using LinkedOut.Dtos.ResponseModel;
using LinkedOut.Entites;
using LinkedOut.Entites.Identity;
using LinkedOut.Interface.Repository;
using LinkedOut.Interface.Services;
using Microsoft.AspNetCore.Hosting;

namespace LinkedOut.Implementations.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUserRepository _userRepository;
        private readonly IAdminRepository _adminRepository;
        private readonly  IWebHostEnvironment _webHostEnvironment;
        private readonly IRoleRepository _roleRepository;
        public AdminService(IUserRepository userRepository, IAdminRepository adminRepository,IWebHostEnvironment webHostEnvironment,IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
            _userRepository = userRepository;
            _adminRepository = adminRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<BaseResponse> AddAdmin(CreateAdminRequestModel model)
        {
            var admin = await _adminRepository.GetAsync(a => a.User.Email == model.Email);
            if (admin != null)
            {
                return new BaseResponse()
                {
                    Message = "Admin Already Exist",
                    Success = false,
                };
            }
            var user = new User
            {
                Email = model.Email,
                Password = model.Password,
            };
            var adduser = await _userRepository.CreateAsync(user);
            
            var imageName = "";
            // if(model.ProfileImage != null)
            // {
            //     var imgPath = _webHostEnvironment.WebRootPath;
            //     var imagePath  = Path.Combine(imgPath,"Images");
            //     Directory.CreateDirectory(imagePath);
            //     var imageType = model.ProfileImage.ContentType.Split('/')[1];
            //     imageName = $"{Guid.NewGuid()}.{imageType}";
            //     var fullPath = Path.Combine(imagePath,imageName);
            //     using(var fileStream = new FileStream(fullPath,FileMode.Create))
            //     {
            //         model.ProfileImage.CopyTo(fileStream);
            //     }
            // }
            var role = await _roleRepository.GetAsync(x => x.Name == model.RoleName);
            if(role == null)
            {
                return new BaseResponse
                {
                    Message = "Role not found",
                    Success = false
                };
            }
            var admins = new Admin 
            {
                UserId = adduser.Id,
                User = adduser,
                RoleId = role.Id,
                Role = role,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Username = model.UserName,
                PhoneNumber = model.PhoneNumber,
                IsDeleted = false,
                PrifileImage = model.ProfileImage,
                DateOfBirth = model.DateOfBirth,
            };
            var addAdmin = await _adminRepository.CreateAsync(admins);
            return new BaseResponse
            {
                Message = "Admin Added Successfully",
                Success = true,
            };

        }

        public async Task<BaseResponse> DeleteAdmin(int Id)
        {
            var admin = await _adminRepository.GetAsync(admins => admins.IsDeleted == false && admins.Id == Id);
            if (admin == null )
            {
                return new BaseResponse
                {
                    Message = "Admin not found",
                    Success = false
                };
            }

            admin.IsDeleted = true;
            await _adminRepository.UpdateAsync(admin);
            return new BaseResponse
            {
                Message = "Administrator Successfully Deleted",
                Success = true
            };
        }


        public async Task<AdminsResponseModel> GetAllAdmin()
        {
            var admins = await _adminRepository.GetAllAdminsAsync();
            if(admins == null)
            {
                return new AdminsResponseModel
                {
                    Message = "No Admin yet",
                    Success = false
                };
            }
            return new AdminsResponseModel
            {
                 Message = "Admins Found",
                 Success = true,
                Data = admins.Select(x => new AdminDto
                {
                    Id = x.Id,
                    UserName = x.Username,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Email = x.User.Email,
                    PhoneNumber = x.PhoneNumber,
                    PrifileImage = x.PrifileImage,
                    RoleDto = new RoleDto
                    {
                        Name = x.Role.Name,
                        Description = x.Role.Description
                    }
                }).ToList()
            };
        }
        public async Task<AdminResponseModel> FindAdminAsync(LoginRequestModel model)
        {
            var admin = await _adminRepository.GetAsync(x => x.User.Email == model.Email && x.User.Password == model.Password);
            if(admin == null)
            {
                return new AdminResponseModel
                {
                    Message = "Admin Acount not found",
                    Success = false
                };
            }
            return new AdminResponseModel
            {
                Message = "You've logged-in As an Admin Successfully",
                Success = true,
                Data = new AdminDto
                {
                    Id = admin.Id,
                    UserName = admin.Username,
                    FirstName = admin.FirstName,
                    LastName = admin.LastName
                }
            };
        }
    }
}