using SnapFood.Context.FoodContext;
using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public class OrderService 
    {
        private readonly FoodContext _context;

        public OrderService(FoodContext context)
        {
            _context = context;
            var LstOrder = _context.Load<Order>("order");
            if (_context.Orders.Count() == 0 && LstOrder != null)
                _context.Orders = LstOrder;

        }
        public bool Delete(Guid id)
        {
            try
            {

                var query = _context.Orders.Single(p => p.Id.ToString() == id.ToString());
                _context.Orders.Remove(query);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return false;
            }
        }

        public Order FindById(Guid id)
        {
            try
            {
                var query = _context.Orders.SingleOrDefault(p => p.Id.ToString() == id.ToString());
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }

        public bool Insert(Order order)
        {

            try
            {
                var LstOrder = _context.Load<Order>("order");
                if (LstOrder != null)
                    _context.Orders = LstOrder;
                _context.Orders.Add(order);
                _context.save(_context.Orders, "order");
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"error insert: {ex.Message}");
                return false;

            }

        
        }

        public List<Order> Search(string parameter)
        {
            throw new NotImplementedException();
        }


        public bool Update(Order order)
        {
            throw new NotImplementedException();
       
        
        }

        public ICollection<Order> SelectAll()
        {
            {

                return _context.Orders;
            }
        
        }
        public ICollection<Order> SelectRstId(Guid Id)
        {

           return  _context.Orders.Where(p => p.RestaurantId.ToString() == Id.ToString()).ToList();

        }
        public string UserName(Guid userId)
        {
            var query= _context.Users.First(p => p.Id.ToString() == userId.ToString());
            return query.Name + " " + query.Family;
        }
    }
}
