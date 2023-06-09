using SnapFood.Application.Services.General;
using SnapFood.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnapFood.WinApp
{
    public partial class RestaurantPanelForm : Form
    {
        public Guid restaurantId ;
        public Guid foodID = Guid.Empty;
        public RestaurantPanelForm()
        {
            InitializeComponent();
        }

        private void UpdateMenuButton_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(restaurantId.ToString());
            var food = new Food();
            food.Id = foodID;
            if (foodID == Guid.Empty )
            {
                food.Id = Guid.NewGuid();
            }
            food.Name = TxtFood.Text;
            food.Price = Convert.ToInt32(TxtPrice.Text);
            food.RestaurantId = restaurantId;
            DgvFood.Rows.Add(food.Id, TxtFood.Text, TxtPrice.Text);        
            GeneralVariable.foodService.Insert(food);
            TxtFood.Text = "";
            TxtPrice.Text = "";
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

           var foodId = Guid.Parse( DgvFood.SelectedRows[0].Cells[0].Value.ToString());
           var FoodQuery = GeneralVariable.foodService.FindById(foodId);
            foodID = FoodQuery.Id;
            TxtFood.Text = FoodQuery.Name;
            TxtPrice.Text = FoodQuery.Price.ToString();


        }
        public ICollection<Food> ShowFoods()
        {
            return GeneralVariable.foodService.SearchByRestaurantId(restaurantId);
        }

        private void RestaurantPanelForm_Load(object sender, EventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            LstFactorForms lstFactorForms = new LstFactorForms();
            lstFactorForms.Show();
        }
    }
}
