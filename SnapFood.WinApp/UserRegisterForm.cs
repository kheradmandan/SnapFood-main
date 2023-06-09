
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
    public partial class UserRegisterForm : Form
    {
        public UserRegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.Id = Guid.NewGuid();
            user.Name = TxtName.Text;
            user.Family = TxtFamily.Text;
            user.Adress = TxtAddress.Text;
            user.NationalCode = TxtNationalCode.Text;
            user.Role = UserRole.Customer;
            GeneralVariable.userService.Insert(user);
            MessageBox.Show("کاربر با موفقیت ذخیره شد ");
            this.Hide();
           // new UserPanelForm().Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
