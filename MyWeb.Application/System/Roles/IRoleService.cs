using MyWeb.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Application.System.Roles
{
   public interface IRoleService
    {
        Task<List<RolesViewModels>> GetAll();
    }
}
