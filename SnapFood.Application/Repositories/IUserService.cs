using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public interface IUserService
    {
        User FindById(Guid id);
        List<User> Search(string parameter);
        bool Insert(User user);
        bool Update(User user);
        bool Delete(Guid id);
        ICollection<User> SelectAll();

    }
}
