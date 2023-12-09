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
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _roleRepository;
        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }

        public async Task<BaseResponse> CreateRole(CreateRoleRequestModel model)
        {
            var role = await _roleRepository.ExistsAsync(x => x.Name == model.Name);
            if(role)
            {
                return new BaseResponse
                {
                    Message = "Role Already Exist",
                    Success = false
                };
            }

            var rol = new Role
            {
                Name = model.Name,
                Description = model.Description,
            };
           await _roleRepository.CreateAsync(rol);
           return new BaseResponse
           {
                Message = "Role Created Successfully",
                Success = true
           };
        }

        public async Task<RoleResponseModel> GetRoleByAdminUsername(string name)
        {
            var role = await _roleRepository.GetRoleByAdminUsername(name);
            if(role == null)
            {
                return new RoleResponseModel
                {
                    Message = "No role found for this Admin",
                    Success = false
                };
            }
            return new RoleResponseModel
            {
                Message = "Role found",
                Success = true,
                Data = new RoleDto
                {
                    Name = role.Name,
                    Description = role.Description
                }
            };

        }
        public async Task<RolesResponseModel> GetAllRoles(string name)
        {
            var roles = await _roleRepository.GetAllRoles(name);
            if(roles == null)
            {
                return new RolesResponseModel
                {
                    Message = "No role found for this Admin",
                    Success = false
                };
            }
            return new RolesResponseModel
            {
                Message = "Role found",
                Success = true,
                Data = roles.Select(x => new RoleDto
                {
                    Name = x.Name,
                    Description = x.Description
                }).ToList()
            };

        }
    }
}