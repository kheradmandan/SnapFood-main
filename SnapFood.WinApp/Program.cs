using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using SnapFood.Application.Services.General;
using SnapFood.Context.FoodContext;

namespace SnapFood.WinApp
{
    static class Program
    {
       
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //GeneralVariable.restaurantService.
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            //System.Windows.Forms.Application.Run(new LoginForm());
            System.Windows.Forms.Application.Run(new MainForm());
            //  System.Windows.Forms.Application.Run(new RestaurantRegisterForm());
        }
    }
}
