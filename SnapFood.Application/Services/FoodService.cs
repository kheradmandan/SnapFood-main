using SnapFood.Context.FoodContext;
using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public class FoodService
    {
        private readonly FoodContext _context;

        public FoodService(FoodContext context)
        {
            _context = context;
            var LstFood = _context.Load<Food>("food");
            if (_context.Foods.Count() == 0 && LstFood != null)
                _context.Foods = LstFood;

        }

        public bool Delete(Guid id)
        {
            try
            {

                var query = _context.Foods.First(p => p.Id.ToString() == id.ToString());
                _context.Foods.Remove(query);
                _context.save(_context.Foods, "food");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return false;
            }
        }

        public Food FindById(Guid id)
        {
            try
            {
                var u = _context.Foods;
                var query = _context.Foods.First(p => p.Id.ToString() == id.ToString());
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }

        public bool Insert(Food food)
        {
            try
            {


                var Lstfoods = _context.Load<Food>("food");
                if (Lstfoods != null)
                    _context.Foods = Lstfoods;
                _context.Foods.Add(food);
                _context.save(_context.Foods, "food");
                return true;

            }
            catch (Exception ex)
            {

                Console.WriteLine($"error insert: {ex.Message}");
                return false;

            }
        }

        public List<Food> Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public ICollection<Food> SearchByRestaurantId(Guid restaurantId)
        {
            var Lstrestaurant = _context.Load<Food>("food");

            // if (_context.Foods.Count() == 0 && Lstrestaurant != null)
            //  _context.Foods = Lstrestaurant;
            return _context.Foods.Where(p => p.RestaurantId.ToString() == restaurantId.ToString()).ToList();


        }
        public ICollection<Food> SelectAll()
        {
            return _context.Foods;
        }

        public bool Update(Food food)
        {
            try
            {
                var query = _context.Foods.Where(p => p.Id.ToString() == food.Id.ToString()).ToList();
                query.First().Name = food.Name;
                query.First().Price = food.Price;
                _context.save(_context.Foods, "food");
                //  var query =
                // this.FindById(food.Id).Name = food.Name;
                // this.FindById(food.Id).Price = food.Price;
                // query.Name = food.Name;
                //  query.Price = food.Price;
                //   this.Insert()
                // _context.update<Food>(_context.Foods, "food");
                return true;



                // _context.Foods.Where(p => p.Id.ToString() == food.Id.ToString()).ToList();


            }
            catch (Exception ex)
            {


                Console.WriteLine($"error insert: {ex.Message}");
                return false;
            }

        }
    }
}
