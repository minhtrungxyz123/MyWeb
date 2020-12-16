using MyWeb.ViewModels.Common;
using MyWeb.ViewModels.System.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RolesViewModels>>> GetAll();
    }
}
