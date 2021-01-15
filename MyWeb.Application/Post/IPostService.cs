using MyWeb.ViewModels.Post;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Application.Post
{
   public interface IPostService
    {
        Task<int> Create(BantinCreateRequest request);
    }
}
