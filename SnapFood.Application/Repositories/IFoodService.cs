using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public interface IFoodService
    {
        Food FindById(Guid id);
        List<Food> Search(string parameter);
        bool Insert(Food food);
        bool Update(Food food);
        bool Delete(Guid id);
        ICollection<Food> SelectAll();
    }
}
