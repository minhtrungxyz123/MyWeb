using MyWeb.ViewModels.Sales;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Application.Oder
{
   public interface IOrderService
    {
        Task<int> Create(OrderDetailViewModel request);
    }
}
