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
    public partial class RstFoodsForm : Form
    {
     
        public Guid foodID = Guid.Empty;
        public RstFoodsForm()
        {
            InitializeComponent();
        }

        private void MenuUpdateButton_Click(object sender, EventArgs e)
        {

        }

        public void showGrid()
        {
            var RstFoods = GeneralVariable.foodService.SearchByRestaurantId(GeneralVariable.CurrentUser.Restaurants.First().Id);
            foreach (var item in RstFoods)
            {
                DgvFoods.Rows.Add(item.Id, item.Name, item.Price);
            }
        }
        private void UpdateMenuForm_Load(object sender, EventArgs e)
        {
            TxtNam.Enabled = false;
            TxtPrice.Enabled = false;
            TxtNam.BackColor = Color.FromArgb(210, 202, 202);
            TxtPrice.BackColor = Color.FromArgb(210, 202, 202);

            showGrid();



          //  DataGridStyle(DgvFoods);
          // var t = ShowFoods();

            //  DgvFoods.DataSource = ShowFoods();
            //  MessageBox.Show(GeneralVariable.CurrentUser.Restaurants.First().Id.ToString());
        }
        private void DataGridStyle(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 236, 253);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor= Color.FromArgb(44, 78, 134);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.BackgroundColor= Color.FromArgb(0, 75, 103);
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor= Color.FromArgb(0, 75, 103);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataGridStyle(DgvFoods);
            //var t = ShowFoods();
            //DgvFoods.DataSource = t;




        }
        public ICollection<Food> ShowFoods()
        {
            return GeneralVariable.foodService.SearchByRestaurantId(GeneralVariable.CurrentUser.Restaurants.First().Id);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            var Name = TxtNam.Text;
            var Price = Convert.ToInt32( TxtPrice.Text);
           
            var food = new Food();            
            food.Name = Name;
            food.Price = Price;
            food.RestaurantId = GeneralVariable.CurrentUser.Restaurants.First().Id;
            if (foodID == Guid.Empty)
            {
                food.Id = Guid.NewGuid();
                DgvFoods.Rows.Add(food.Id, food.Name, food.Price);
                GeneralVariable.foodService.Insert(food);
            }
            else
            {
                DgvFoods.Rows.Clear();
                food.Id = foodID;
                GeneralVariable.foodService.Update(food);
                showGrid();
            }

          //  food.RestaurantId = GeneralVariable.CurrentUser.Restaurants.First().Id;
          //  DgvFoods.Rows.Add(food.Id, food.Name, food.Price);
           // GeneralVariable.foodService.Insert(food);


            TxtNam.Text = "";
            TxtPrice.Text = "";

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //ch
            TxtNam.Enabled = true;
            TxtPrice.Enabled = true;
            TxtNam.BackColor = Color.FromArgb(255, 255, 255);
            TxtPrice.BackColor = Color.FromArgb(255, 255, 255);
            //var foodId = Guid.Parse(DgvFoods.SelectedRows[0].Cells[0].Value.ToString());
            //var FoodQuery = GeneralVariable.foodService.FindById(foodId);
            //foodID = FoodQuery.Id;
            //TxtNam.Text = FoodQuery.Name;
            //TxtPrice.Text = FoodQuery.Price.ToString();
        }

        private void DgvFoods_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            foodID = Guid.Parse(DgvFoods.SelectedRows[0].Cells[0].Value.ToString());
            TxtNam.Text = DgvFoods.SelectedRows[0].Cells[1].Value.ToString();
            TxtPrice.Text = DgvFoods.SelectedRows[0].Cells[2].Value.ToString();
            var FoodQuery = GeneralVariable.foodService.FindById(foodID);
            TxtNam.Enabled = false;
            TxtPrice.Enabled = false;
            TxtNam.BackColor = Color.FromArgb(210, 202, 202);
            TxtPrice.BackColor = Color.FromArgb(210, 202, 202);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DgvFoods.Rows.Clear();       
            GeneralVariable.foodService.Delete(foodID);
            showGrid();
        }
    }
}
