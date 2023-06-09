using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Domain.Entities
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantOwner { get; set; }

        public string WorkTimeFrom { get; set; }
        public string WorkTimeTo{ get; set; }
        public string Adress { get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}
