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
    public partial class LstFactorForms : Form
    {
        public LstFactorForms()
        {
            InitializeComponent();
            dgvRestaurantFactor.AutoGenerateColumns = false;
        }

        private void btnFoodSelect_Click(object sender, EventArgs e)
        {
           
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
