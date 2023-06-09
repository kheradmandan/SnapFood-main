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
    public partial class RstOrderItems : Form
    {
        public Guid OrderId = Guid.Empty;
        public RstOrderItems()
        {
            InitializeComponent();
        

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void RstOrderItems_Load(object sender, EventArgs e)
        {

            TxtName.Enabled = false;
            TxtFamily.Enabled = false;
            TxtMob.Enabled = false;
            TxtAdress.Enabled = false;
            TxtRstName.Enabled = false;
            TxtRstOwner.Enabled = false;
            TxtRstAdress.Enabled = false;


           // MessageBox.Show(OrderId.ToString());
            var order = GeneralVariable.orderService.FindById(OrderId);
            var orderItem= GeneralVariable.orderItemService.SelectOrderItemsId(OrderId);
            //userData           
            var user = GeneralVariable.userService.FindById(order.UserId);
            TxtName.Text = user.Name;
            TxtFamily.Text = user.Family;
            TxtMob.Text = user.Mobile;
            TxtAdress.Text = user.Adress;
            //RstData
            var Rst = GeneralVariable.restaurantService.FindById(order.RestaurantId);
            TxtRstName.Text = Rst.RestaurantName;
            TxtRstOwner.Text = Rst.RestaurantOwner;
            TxtRstAdress.Text = Rst.Adress;
            //Grid
            foreach (var item in orderItem)
            {
                DgvOrderItem.Rows.Add(item.Name,item.Count,item.Price);
            }



        }
    }
}
