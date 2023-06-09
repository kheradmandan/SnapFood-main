using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public interface IOrderService
    {
        Order FindById(Guid id);
        List<Order> Search(string parameter);
        bool Insert(Order order);
        bool Update(Order order);
        bool Delete(Guid id);
        ICollection<Order> SelectAll();
    }
}
