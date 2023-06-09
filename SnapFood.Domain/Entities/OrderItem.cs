using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Domain.Entities
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid FoodId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public long Price { get; set; }
    }
}
