using SnapFood.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Adress { get; set; }
        public string Mobile { get; set; }
        public string NationalCode { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; } = new Collection<Restaurant>();
    }
}
