using SnapFood.Application.Services;
using SnapFood.Application.Services.General;
using SnapFood.Domain.Entities;
using SnapFood.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapFood.WinApp
{
    public partial class RestaurantRegisterForm : Form
    {
        public RestaurantRegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var Rst = new Restaurant();
            Rst.Id = Guid.NewGuid();
            Rst.RestaurantName = TxtRestName.Text;
            Rst.RestaurantOwner = TxtOwner.Text;
            Rst.WorkTimeFrom = TxtTimeFrom.Text;
            Rst.WorkTimeTo = TxtTimeTo.Text;
            Rst.Adress = TxtRestAddress.Text;
            GeneralVariable.restaurantService.Insert(Rst);
            MessageBox.Show("رستوران با موفقیت ذخیره شد ");

            var user = new User();
            user.Id = Guid.NewGuid();
            user.Name = txtAdmin.Text;
            user.Family = TxtAdminFamily.Text;
            user.Adress = TxtAdminAddress.Text;
            user.NationalCode = TxtAdminNationalCode.Text;
            user.Role = UserRole.Restaurant;
            user.Restaurants.Add(Rst);
            GeneralVariable.userService.Insert(user);
            MessageBox.Show("کاربر با موفقیت ذخیره شد ");











            this.Hide();

           // UserRegisterForm userRegisterFormForm = new UserRegisterForm();
           // restaurantPanelForm.restaurantId = Rst.Id;
          //  userRegisterFormForm.Show();       


            // RestaurantPanelForm restaurantPanelForm = new RestaurantPanelForm();
            // restaurantPanelForm.restaurantId = Rst.Id;
            // restaurantPanelForm.Show();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
