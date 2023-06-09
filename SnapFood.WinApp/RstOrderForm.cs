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
    public partial class RstOrderForm : Form
    {
        public Guid currentOrderId = Guid.Empty;
        public RstOrderForm()
        {
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            showGridOrders();
            TxtName.Enabled = false;
            TxtFamily.Enabled = false;
            TxtMob.Enabled = false;
            TxtAdress.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public void showGridOrders()
        {
            var orderListCurrentUser = GeneralVariable.orderService.SelectRstId(GeneralVariable.CurrentUser.Restaurants.First().Id);
            // var orderItemAll = GeneralVariable.orderItemService.SelectAll();
            
            var UserName = "";
            DateTime date;
            long sum = 0;
         
            foreach (var order in orderListCurrentUser)
            {
                UserName = GeneralVariable.orderService.UserName(order.UserId);
                date = order.CreatedAt;
                var orderItemsCurrentUser = GeneralVariable.orderItemService.SelectOrderItemsId(order.Id);
                sum = 0;
                foreach (var orderItem in orderItemsCurrentUser)
                {
                    sum += orderItem.Price;
                }

                DvgOrders.Rows.Add(order.UserId, order.Id, UserName, date, sum);
            }

      
        }


        public void test()
        {
            //var list = (from m in new table1
            //    join f in new table2 on m.Id equals f.FId
            //            join d in new table3 on f.DId equals d.ID

            //            where d.rank == 1 && m.FactorId == 32
            //            select
            //                new
            //                {
            //                    d.ID,
            //                    d.name,
            //                    m.Price,
            //                    f.DateInsert,

            //                    Rid = f.Id
            //                }).Distinct()
            //    .ToList();
        }

        private void DvgOrders_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentOrderId = Guid.Parse(DvgOrders.SelectedRows[0].Cells[1].Value.ToString());
            var SelectedUserGuid = Guid.Parse(DvgOrders.SelectedRows[0].Cells[0].Value.ToString());
           var user = GeneralVariable.userService.FindById(SelectedUserGuid);
            TxtName.Text = user.Name;
            TxtFamily.Text = user.Family;
            TxtMob.Text = user.Mobile;
            TxtAdress.Text = user.Adress;

        }

        private void BtnFactorDetail_Click(object sender, EventArgs e)
        {
            RstOrderItems rstOrderItems = new RstOrderItems();
            rstOrderItems.OrderId = currentOrderId;
            rstOrderItems.Show();
        }
    }
}
