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
    public partial class RstPanelForm : Form
    {
        public Guid restaurantId;
        public Guid foodID = Guid.Empty;
        public RstPanelForm()
        {
            InitializeComponent();
            SidPanel.Height = BtnHome.Height;
            SidPanel.Top = BtnHome.Top;
        }

        private void resturanPanelNew_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

          //  SidPanel.Height = BtnAdd.Height;
          //  SidPanel.Top = BtnAdd.Top;

            InsertMenuForm insertMenuForm = new InsertMenuForm();
            insertMenuForm.Show();
        
  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidPanel.Height = BtnFood.Height;
            SidPanel.Top = BtnFood.Top;
            RstFoodsForm updateMenuForm = new RstFoodsForm();
            updateMenuForm.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            SidPanel.Height = BtnHome.Height;
            SidPanel.Top = BtnHome.Top;
        }

        private void BtnFactor_Click(object sender, EventArgs e)
        {
            RstOrderForm Ordersform = new RstOrderForm();
           // updateMenuForm.restaurantId = restaurantId;
            Ordersform.Show();
            SidPanel.Height = BtnFactor.Height;
            SidPanel.Top = BtnFactor.Top;

        }

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            SidPanel.Height = BtnCustomer.Height;
            SidPanel.Top = BtnCustomer.Top;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
