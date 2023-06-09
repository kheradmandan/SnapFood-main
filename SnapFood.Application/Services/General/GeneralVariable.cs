using SnapFood.Context.FoodContext;
using SnapFood.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapFood.Application.Services.General
{
    public static class GeneralVariable
    {
        public  static FoodContext dbContex = new FoodContext();        
        public  static User CurrentUser = new User();
        public static UserService userService = new UserService(dbContex);
        public static RestaurantService restaurantService = new RestaurantService(dbContex);
        public static OrderService orderService = new OrderService(dbContex);
        public static OrderItemService orderItemService = new OrderItemService(dbContex);
        public static FoodService foodService = new FoodService(dbContex);

    }
}
