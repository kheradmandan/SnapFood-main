using SnapFood.Application.Services.General;
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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void tlsMainBtnLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.ShowDialog();
        }

        private void tlsMainFormExitBtn_Click(object sender, EventArgs e)
        {
              
            
        }

        private void tlsCustomerSignupMenu_Click(object sender, EventArgs e)
        {
            UserRegisterForm CustomerRegForm= new UserRegisterForm();
            CustomerRegForm.ShowDialog();
        }

        private void tlsRestaurantSignupMenu_Click(object sender, EventArgs e)
        {
            RestaurantRegisterForm restaurantRegForm = new RestaurantRegisterForm();
            restaurantRegForm.ShowDialog();

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var t = GeneralVariable.restaurantService.SelectAll();
            dgvUserList.DataSource = t;
        }
    }
}
