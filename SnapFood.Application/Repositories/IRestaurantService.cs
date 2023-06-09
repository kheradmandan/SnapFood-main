using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public interface IRestaurantService
    {
        Restaurant FindById(Guid id);
        List<Restaurant> Search(string parameter);
        bool Insert(Restaurant restaurant);
        bool Update(Restaurant restaurant);
        bool Delete(Guid id);
        ICollection<Restaurant> SelectAll();
    }
}
