using SnapFood.Context.FoodContext;
using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public class OrderItemService : IOrderItemService
    {
        private readonly FoodContext _context;

        public OrderItemService(FoodContext context)
        {
            _context = context;
            var LstOrderItem = _context.Load<OrderItem>("orderItem");
            if (_context.OrderItems.Count() == 0 && LstOrderItem != null)
                _context.OrderItems = LstOrderItem;
        }

        public bool Delete(Guid id)
        {
            try
            {

                var query = _context.OrderItems.Single(p => p.Id.ToString() == id.ToString());
                _context.OrderItems.Remove(query);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return false;
            }
        }

        public OrderItem FindById(Guid id)
        {
            try
            {
                var query = _context.OrderItems.SingleOrDefault(p => p.Id.ToString() == id.ToString());
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }
        public List<OrderItem> FindByOrderId(Guid Orderid)
        {
            try
            {
                List<OrderItem> query = _context.OrderItems.Where(p => p.OrderId == Orderid).ToList();
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }

        public bool Insert(OrderItem orderItem)
        {
            try
            {

                var LstOrderItem = _context.Load<OrderItem>("orderItem");
                if (LstOrderItem != null)
                    _context.OrderItems = LstOrderItem;
                _context.OrderItems.Add(orderItem);
                _context.save(_context.OrderItems, "orderItem");
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine($"error insert: {ex.Message}");
                return false;

            }
        }

        public List<OrderItem> Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderItem> SelectAll()
        {
            return _context.OrderItems;
        }

        public bool Update(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderItem> SelectOrderItemsId(Guid IdOrder)
        {
            return _context.OrderItems.Where(p => p.OrderId.ToString() == IdOrder.ToString()).ToList();
        }
    }
}
