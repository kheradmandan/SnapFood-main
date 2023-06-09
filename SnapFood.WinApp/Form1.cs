using SnapFood.Application.Services;
using SnapFood.Application.Services.General;
using SnapFood.Context.FoodContext;
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
 
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneralVariable.userService.Insert(new User()
            {
                Id = Guid.NewGuid(),
                Name = "test",
                Family = "test1",
                Adress = "test2",
                Mobile = "0912",
                Role = Domain.Enum.UserRole.Customer
            });

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GeneralVariable.userService.SelectAll();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


