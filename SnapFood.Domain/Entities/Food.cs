using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Domain.Entities
{
    public class Food
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public Guid RestaurantId { get; set; }

        // To test
    }
}
