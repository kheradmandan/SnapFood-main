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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //بررسی نوع کاربر و هدایت به فرم مربوطه

            var nationalCode = UserNameTextBox.Text;
            User query = GeneralVariable.userService.FindByNationalCode(nationalCode);
            if (query != null)
            {
                if (query.Role == UserRole.Customer)
                {
                    PanelUserForm userPanelFormForm = new PanelUserForm();
                    userPanelFormForm.userId = query.Id;
                    GeneralVariable.CurrentUser = (User)query;
                    userPanelFormForm.ShowDialog();
                };
                if (query.Role == UserRole.Restaurant)
                {

                    RstPanelForm rstPanelForm = new RstPanelForm();
                    // restaurantPanelForm.restaurantId = query.Restaurants.First().Id;
                    rstPanelForm.restaurantId = query.Restaurants.First().Id;
                    GeneralVariable.CurrentUser = (User)query;
                    this.Hide();
                    rstPanelForm.ShowDialog();
                   
                };
                this.Hide();
            }

            //var EnterUser =
            //var user = new User();
            //user.Id = Guid.NewGuid();
            //user.Name = TxtName.Text;
            //user.Family = TxtFamily.Text;
            //user.Adress = TxtAddress.Text;
            //user.NationalCode = TxtNationalCode.Text;
            //GeneralVariable.userService.Insert(user);


            ///////////////////////////////////////////////////
            ////RestaurantPanelForm
            //GeneralVariable.restaurantService.Insert(Rst);
            //this.Hide();

            //RestaurantPanelForm restaurantPanelForm = new RestaurantPanelForm();
            //restaurantPanelForm.restaurantId = Rst.Id;
            //restaurantPanelForm.Show();
            /////////////////////////////////////////////////////
            //// UserPanelForm
            //GeneralVariable.restaurantService.Insert(Rst);
            //this.Hide();

            //UserPanelForm userPanelFormForm = new UserPanelForm();
            //restaurantPanelForm.userId = Rst.Id;
            //userPanelFormForm.Show();
        }
    }
}
