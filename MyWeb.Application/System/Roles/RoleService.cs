using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyWeb.ViewModels.System.Roles;
using MyWebLapTop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Application.System.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<AppRole> _roleManager;
        public RoleService(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<List<RolesViewModels>> GetAll()
        {
            var
                 roles = await _roleManager.Roles.Select(x => new RolesViewModels()
                 {
                     Id=x.Id,
                     Name=x.Name,
                     Description=x.Description,
                     
                 }).ToListAsync();
            return roles;
        }
    }
}
