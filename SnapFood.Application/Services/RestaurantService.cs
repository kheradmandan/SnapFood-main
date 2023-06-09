using SnapFood.Application.Services.General;
using SnapFood.Context.FoodContext;
using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public class RestaurantService : IRestaurantService
    {

        private readonly FoodContext _context;

        public RestaurantService(FoodContext context)
        {
            _context = context;

            var LstRestaurant = _context.Load<Restaurant>("restaurant");
            if (_context.Restaurants.Count() == 0 && LstRestaurant != null)
                _context.Restaurants = LstRestaurant;
        }
        public bool Delete(Guid id)
        {
            try
            {

                var query = _context.Restaurants.Single(p => p.Id.ToString() == id.ToString());
                _context.Restaurants.Remove(query);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return false;
            }
        }

        public Restaurant FindById(Guid id)
        {
            try
            {
                var query = _context.Restaurants.SingleOrDefault(p => p.Id.ToString() == id.ToString());
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }

        public bool Insert(Restaurant restaurant)
        {
            try
            {
                var Lstrestaurant = _context.Load<Restaurant>("restaurant");
                if (Lstrestaurant != null)
                    _context.Restaurants = Lstrestaurant;
                _context.Restaurants.Add(restaurant);
                _context.save(_context.Restaurants, "restaurant");
                return true;



            }
            catch (Exception ex)
            {

                Console.WriteLine($"error insert: {ex.Message}");
                return false;

            }
        }

        public List<Restaurant> Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public ICollection<Restaurant> SelectAll()
        {
            // return _context.Load<Restaurant>("restaurant");
            return _context.Restaurants;
        }
        public List<Restaurant> SreachRes()
        {
           List<Restaurant> rest= (from res in _context.Restaurants
            join f in _context.Foods on res.Id equals f.RestaurantId
            where f.Name.Length>0
            select res).Distinct().ToList();
            return rest;
        }
        public bool Update(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }
     
       
    }
}
