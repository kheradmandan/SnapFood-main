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
    public partial class PrintFactorFrm : Form
    {
        public Guid OrderId;
        List<OrderItem> _Orderitem = new List<OrderItem>();
        public PrintFactorFrm()
        {
            InitializeComponent();
            
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
        private void CalcTotalPrice()
        {
            long totalfactor = _Orderitem.Sum(i => i.Count * i.Price);
            SumInvoiceLable.Text = "جمع کل : " + DividedPrice(totalfactor.ToString());
        }

        private void PrintFactorFrm_Load(object sender, EventArgs e)
        {
            dvgInvoicedetails.AutoGenerateColumns = false;
            Order _Order = GeneralVariable.orderService.FindById(OrderId);
            _Orderitem = GeneralVariable.orderItemService.FindByOrderId(OrderId);
            Restaurant _res = GeneralVariable.restaurantService.FindById(_Order.RestaurantId);
            User _user = GeneralVariable.userService.FindById(_Order.UserId);
            lblFullName.Text = "نام و نام خانوادگی : " + _user.Name + " " + _user.Family;
            lblTell.Text = "شماره موبایل : ";
            lblAdr.Text = "آدرس " + _user.Adress;
            lblResName.Text = " نام رستوران : " + _res.RestaurantName;
            lblResAdr.Text = "آدرس رستوران : " + _res.Adress;
            dvgInvoicedetails.DataSource = _Orderitem;
            CalcTotalPrice();
        }
    }
}
