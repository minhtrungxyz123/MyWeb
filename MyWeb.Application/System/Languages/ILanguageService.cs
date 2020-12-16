using MyWeb.ViewModels.Common;
using MyWeb.ViewModels.System.Languages;
using MyWeb.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<LanguageViewModel>>> GetAll();
    }
}