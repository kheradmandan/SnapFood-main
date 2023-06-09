using SnapFood.Context.FoodContext;
using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services
{
    public class UserService 
    {
        private readonly FoodContext _context;

        public UserService(FoodContext context)
        {
            _context = context;
            var LstUser = _context.Load<User>("user");
            if (_context.Users.Count() == 0 && LstUser != null)
                _context.Users = LstUser;

            //_context.Users=_context.Load<User>("user");
        }


        public bool Delete(Guid id)
        {
            try
            {
                var query = _context.Users.Single(p => p.Id.ToString() == id.ToString());
                _context.Users.Remove(query);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return false;
            }
        }

        public User FindById(Guid id)
        {
            try
            {
                var query = _context.Users.First(p => p.Id.ToString() == id.ToString());
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }
        public User FindByNationalCode(string nationalCode)
        {
            try
            {
                var query = _context.Users.First(p => p.NationalCode == nationalCode);
                return query;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error Delete: {ex.Message}");
                return null;
            }
        }

        public bool Insert(User user)
        {
            try
            {
                var LstUser = _context.Load<User>("user");
                if (LstUser != null)
                    _context.Users = LstUser;
                _context.Users.Add(user);
                _context.save(_context.Users, "user");
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine($"error insert: {ex.Message}");
                return false;

            }
        }

        public ICollection<User> Search(string parameter)
        {
            throw new NotImplementedException();
        }

        public ICollection<User> SelectAll()
        {
            {
                //var LstUser = _context.Load<User>("user");

                //if (_context.Users.Count() == 0 && LstUser != null)
                //    _context.Users = LstUser;
                return _context.Users;
            }
            // return _context.Load<User>("user");
        }

        public bool Update(Guid Id, string name, string family)
        {
            try
            {// name , family
                

                var query = this.FindById(Id);
                query.Name = name;
                query.Family = family;
           
                //this.Delete(Id);
                //this.Insert(query);
                return true;
            }
            catch (Exception )
            {
                throw;           
            }


            
        }
    }
}
