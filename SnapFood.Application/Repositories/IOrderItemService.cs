using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public interface IOrderItemService
    {
        OrderItem FindById(Guid id);
        List<OrderItem> Search(string parameter);
        bool Insert(OrderItem orderItem);
        bool Update(OrderItem orderItem);
        bool Delete(Guid id);
        ICollection<OrderItem> SelectAll();
    }
}
