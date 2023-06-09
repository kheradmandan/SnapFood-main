using SnapFood.Application.Services.General;
using SnapFood.Domain.Entities;
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
    public partial class UserPanelForm : Form
    {
        public Guid userId;
        List<OrderItem> Lstorders = new List<OrderItem>();
        Guid OrderId;
        public UserPanelForm()
        {
            InitializeComponent();
            OrderId = Guid.NewGuid();
            dgvCart.AutoGenerateColumns = false;
        }

        private void UserPanelForm_Load(object sender, EventArgs e)

        {
            SumCartLable.Text = "0";
            var restaurants = GeneralVariable.restaurantService.SelectAll();
            foreach (var item in restaurants)
            {
                dgvRestauranList.Rows.Add(item.RestaurantName, item.RestaurantOwner, item.Adress, item.Id);
            }
           

        }

        private void btnFoodSelect_Click(object sender, EventArgs e)
        {
            var foodId = dgvRestaurantMenu.SelectedRows[0].Cells[2].Value.ToString();
            var food = GeneralVariable.foodService.FindById(Guid.Parse(foodId));
            // dgvCart.Rows.Add( food.Name, food.Price, food.Id);
            //SumCartLable.Text = (Convert.ToInt32( SumCartLable.Text) + food.Price).ToString();
            int _index = Lstorders.FindIndex(i => i.FoodId == Guid.Parse(foodId));
            if (_index > -1)
                Lstorders[_index].Count = Lstorders[_index].Count + 1;
            else
                Lstorders.Add(new OrderItem {Id=Guid.NewGuid(), OrderId = this.OrderId, Count = 1, FoodId = Guid.Parse(foodId), Name = food.Name, Price = food.Price });
            dgvCart.DataSource = null;
            dgvCart.DataSource = Lstorders;

            CalcTotalPrice();
        }

        private void CalcTotalPrice()
        {
            long totalfactor = Lstorders.Sum(i => i.Count * i.Price);
            SumCartLable.Text = DividedPrice(totalfactor.ToString());
        }

        private string DividedPrice(string number)
        {
            number = number.Replace(",", "");
            string price = number.LastIndexOf('.') != -1 ? number.Substring(0, number.LastIndexOf('.')) : number;
            var chars = price.ToCharArray();
            if (number.Length > 3)
            {


                Array.Reverse(chars);
                string t = "";

                for (int i = 0; i < chars.Count(); i++)
                {
                    if (i > 0 && i % 3 == 0)
                    {
                        t = t + ",";
                        t = t + chars[i].ToString();
                    }
                    else
                        t = t + chars[i].ToString();
                }
                chars = t.ToCharArray();
                Array.Reverse(chars);

            }
            return new string(chars);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvRestauranList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvRestaurantMenu.Rows.Clear();
            var restaurantId = dgvRestauranList.SelectedRows[0].Cells[3].Value.ToString();
            var foods = GeneralVariable.foodService.SearchByRestaurantId(Guid.Parse(restaurantId));

            foreach (var item in foods)
            {
                dgvRestaurantMenu.Rows.Add(item.Name, item.Price, item.Id);
            }
        }

        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
         Guid Id = Guid.Parse(dgvCart.CurrentRow.Cells["FoodId"].Value.ToString());

            Lstorders.Remove(Lstorders.First(i => i.FoodId == Id));
            //dgvCart.Rows.Remove(dgvCart.CurrentRow);
            CalcTotalPrice();
            dgvCart.DataSource = null;
            dgvCart.DataSource = Lstorders;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnFinalOrder_Click(object sender, EventArgs e)
        {
            try
            {
                Order _order = new Order();
                _order.Id = this.OrderId;
                _order.RestaurantId = Guid.Parse(dgvRestauranList.SelectedRows[0].Cells["clmnId"].Value.ToString());
                _order.UserId = GeneralVariable.CurrentUser.Id;
                
                foreach (OrderItem item in Lstorders)
                {
                    GeneralVariable.orderItemService.Insert(item); 
                    _order.OrderItems.Add(item);
                }
                GeneralVariable.orderService.Insert(_order);

 
                MessageBox.Show("ثبت فاکتور با موفقیت انجام شد");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
              //  MessageBox.Show("ثبت فاکتور با خطا مواجه شد" );
            }
            
        }

        private void dgvRestauranList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
  }
}
