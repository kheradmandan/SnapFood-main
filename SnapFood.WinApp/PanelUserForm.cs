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
    public partial class PanelUserForm : Form
    { 
            public Guid userId;
            Guid OrderId;
            List<OrderItem> Lstorders = new List<OrderItem>();
            Guid ResId;
            public PanelUserForm()
            {
                InitializeComponent();
                OrderId = Guid.NewGuid();
                dgvBasket.AutoGenerateColumns = false;
            }
            public int TabIndex { get; set; }

            private void AddResturant()
            {
                var restaurants = GeneralVariable.restaurantService.SreachRes();
                TabIndex = 1;
                int LocationX;
                int LocationY;

                LocationY = -155;
                int btnCount = (PnlRes.Width - 3) / 170;
                int SpaceWidth = (PnlRes.Width - 3) - (btnCount * 170);
                SpaceWidth = (SpaceWidth / btnCount) + 170;
                LocationX = -1 * (SpaceWidth - 2);
                foreach (var item in restaurants)
                {
                    LocationX = (LocationX + SpaceWidth) > PnlRes.Width ? 2 : LocationX + SpaceWidth;
                    if (TabIndex % btnCount == 1)
                    {
                        LocationX = 2;
                        LocationY += 176;
                    }
                    System.Windows.Forms.Button btnRes = new Button();
                    PnlRes.Controls.Add(btnRes);
                    btnRes.Location = new System.Drawing.Point(LocationX, LocationY);
                    btnRes.BackColor = System.Drawing.Color.White;
                    btnRes.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    btnRes.Image = global::SnapFood.WinApp.Properties.Resources.food8;
                    btnRes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
                    btnRes.Name = "btnRes_" + item.Id;
                    btnRes.Size = new System.Drawing.Size(170, 170);
                    btnRes.TabIndex = TabIndex;
                    btnRes.Text = item.RestaurantName;
                    btnRes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
                    btnRes.UseVisualStyleBackColor = false;
                    //btnRes.Location = new System.Drawing.Point(LocationX, LocationY);
                    //btnRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(c1+5*c3)))), ((int)(((byte)(c2 + 5 * c3)))), ((int)(((byte)(c1 + 5 * c3)))));
                    //btnRes.Name = "btnRes_" + item.Id;
                    //btnRes.Size = new System.Drawing.Size(84, 78);
                    //btnRes.TabIndex = TabIndex;
                    //btnRes.Text = item.RestaurantName;
                    //btnRes.UseVisualStyleBackColor = false;

                    btnRes.Click += new System.EventHandler(btnRes_Click);
                    TabIndex++;
                }

            }
            private void btnRes_Click(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                lblRes.Text = "نام رستوران : " + btn.Text;
                ResId = Guid.Parse(btn.Name.Replace("btnRes_", ""));
                AddFood(ResId);
            }
            private void AddFood(Guid ResId)
            {
                int ControlCount = PnlFood.Controls.Count;
                for (int i = 0; i < ControlCount; i++)
                {
                    this.PnlFood.Controls.RemoveAt(0);
                }

                var foods = GeneralVariable.foodService.SearchByRestaurantId(ResId);
                foreach (var item in foods)
                {
                    System.Windows.Forms.Panel PnlF = new Panel();
                    System.Windows.Forms.Panel PnlDiv = new Panel();
                    System.Windows.Forms.TableLayoutPanel tablePanelFood = new TableLayoutPanel();

                    System.Windows.Forms.Label lblPrice = new Label();
                    System.Windows.Forms.Label LblFoodName = new Label();
                    System.Windows.Forms.Button btnAdd = new Button();
                    System.Windows.Forms.PictureBox pictureBox1 = new PictureBox();


                    PnlF.Dock = System.Windows.Forms.DockStyle.Top;
                    PnlF.Location = new System.Drawing.Point(0, 0);
                    PnlF.Name = "PnlF_" + item.Id.ToString();
                    PnlF.Size = new System.Drawing.Size(355, 141);
                    PnlF.TabIndex = 0;

                    LblFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                    LblFoodName.AutoSize = true;
                    LblFoodName.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    LblFoodName.Location = new System.Drawing.Point(88, 3);
                    LblFoodName.Margin = new System.Windows.Forms.Padding(3);
                    LblFoodName.Name = "LblFoodName_" + item.Id.ToString();
                    LblFoodName.Padding = new System.Windows.Forms.Padding(4, 20, 10, 4);
                    LblFoodName.Size = new System.Drawing.Size(264, 62);
                    LblFoodName.TabIndex = 0;
                    LblFoodName.Text = item.Name;


                    lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                    lblPrice.AutoSize = true;
                    lblPrice.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
                    lblPrice.Location = new System.Drawing.Point(88, 91);
                    lblPrice.Margin = new System.Windows.Forms.Padding(3);
                    lblPrice.Name = "lblPrice_" + item.Id.ToString();
                    lblPrice.Padding = new System.Windows.Forms.Padding(4, 8, 10, 8);
                    lblPrice.Size = new System.Drawing.Size(264, 46);
                    lblPrice.TabIndex = 3;
                    lblPrice.Text = item.Price.ToString() + " تومان";

                    pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
                    pictureBox1.Image = global::SnapFood.WinApp.Properties.Resources.food13;
                    pictureBox1.Location = new System.Drawing.Point(3, 3);
                    pictureBox1.Name = "pictureBox1_" + item.Id.ToString();
                    pictureBox1.Size = new System.Drawing.Size(79, 82);
                    pictureBox1.TabIndex = 1;
                    pictureBox1.TabStop = false;


                    btnAdd.BackColor = System.Drawing.Color.White;
                    btnAdd.ForeColor = System.Drawing.Color.DeepPink;
                    btnAdd.Location = new System.Drawing.Point(15, 103);
                    btnAdd.Margin = new System.Windows.Forms.Padding(10);
                    btnAdd.Name = "btnAdd_" + item.Id.ToString();
                    btnAdd.Size = new System.Drawing.Size(73, 34);
                    btnAdd.TabIndex = 2;
                    btnAdd.Text = "افزودن";
                    btnAdd.UseVisualStyleBackColor = false;
                    btnAdd.Click += new System.EventHandler(FoodAdd_Click);

                    tablePanelFood.ColumnCount = 2;
                    tablePanelFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.07527F));
                    tablePanelFood.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.92473F));
                    tablePanelFood.Controls.Add(lblPrice, 0, 1);
                    tablePanelFood.Controls.Add(LblFoodName, 0, 0);
                    tablePanelFood.Controls.Add(pictureBox1, 1, 0);
                    tablePanelFood.Controls.Add(btnAdd, 1, 1);
                    tablePanelFood.Dock = System.Windows.Forms.DockStyle.Fill;
                    tablePanelFood.Location = new System.Drawing.Point(0, 0);
                    tablePanelFood.Name = "tablePanelFood_" + item.Id.ToString();
                    tablePanelFood.RowCount = 2;
                    tablePanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.12057F));
                    tablePanelFood.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.87943F));
                    tablePanelFood.Size = new System.Drawing.Size(355, 141);
                    tablePanelFood.TabIndex = 0;

                    PnlDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    PnlDiv.Dock = System.Windows.Forms.DockStyle.Top;
                    PnlDiv.Location = new System.Drawing.Point(0, 141);
                    PnlDiv.Name = "panel2";
                    PnlDiv.Size = new System.Drawing.Size(355, 2);
                    PnlDiv.TabIndex = 1;

                    PnlFood.Controls.Add(PnlDiv);
                    PnlFood.Controls.Add(PnlF);
                    PnlF.Controls.Add(tablePanelFood);

                }

            }
            private void PanelUserForm_Load(object sender, EventArgs e)

            {
                lblUser.Text = "نام کاربر: " + GeneralVariable.CurrentUser.Name;
            lblWellcome.Text = GeneralVariable.CurrentUser.Name + " " + GeneralVariable.CurrentUser.Family + " عزیز خوش آمدید";
                AddResturant();
                var restaurants = GeneralVariable.restaurantService.SelectAll();

            }
            private void FoodAdd_Click(object sender, EventArgs e)
            {
                Button btn = (Button)sender;
                Guid foodId = Guid.Parse(btn.Name.Replace("btnAdd_", ""));

                var food = GeneralVariable.foodService.FindById(foodId);
                int _index = Lstorders.FindIndex(i => i.FoodId == foodId);
                if (_index > -1)
                    Lstorders[_index].Count = Lstorders[_index].Count + 1;
                else
                    Lstorders.Add(new OrderItem { Id = Guid.NewGuid(), OrderId = this.OrderId, Count = 1, FoodId = foodId, Name = food.Name, Price = food.Price });
                dgvBasket.DataSource = null;
                dgvBasket.DataSource = Lstorders;
                CalcTotalPrice();
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
                long totalfactor = Lstorders.Sum(i => i.Count * i.Price);
                lblSum.Text = DividedPrice(totalfactor.ToString());
            }


            private void btnOk_Click(object sender, EventArgs e)
            {
                try
            {
                Order _order = new Order();
                _order.Id = this.OrderId;
                _order.RestaurantId = ResId;
                _order.UserId = GeneralVariable.CurrentUser.Id;

                foreach (OrderItem item in Lstorders)
                {
                    GeneralVariable.orderItemService.Insert(item);
                    _order.OrderItems.Add(item);
                }
                GeneralVariable.orderService.Insert(_order);
                MessageBox.Show("ثبت فاکتور با موفقیت انجام شد");
                
                PrintFactorFrm printFactorFrm = new PrintFactorFrm();
                printFactorFrm.OrderId = this.OrderId;
                printFactorFrm.ShowDialog();
                clearForm();
            }
            catch (Exception ex)
                {

                    MessageBox.Show("ثبت فاکتور با خطا مواجه شد");
                }
            }

        private void clearForm()
        {
            this.OrderId = Guid.NewGuid();
            Lstorders.Clear();
            dgvBasket.DataSource = null;
            CalcTotalPrice();
        }

        private void dgvBasket_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    int RowIndex = e.RowIndex;
                    if (dgvBasket.Columns[e.ColumnIndex].Name == "delete") //if (e.ColumnIndex == 2)
                    {

                        dgvBasket.Rows[e.RowIndex].Selected = false;
                        Guid Id = Guid.Parse(dgvBasket.CurrentRow.Cells["FoodId"].Value.ToString());

                        Lstorders.Remove(Lstorders.First(i => i.FoodId == Id));
                        //dgvCart.Rows.Remove(dgvCart.CurrentRow);
                        CalcTotalPrice();
                        dgvBasket.DataSource = null;
                        dgvBasket.DataSource = Lstorders;

                    }
                    dgvBasket.Rows[e.RowIndex].Selected = false;
                }
                catch (Exception ex)
                {
                }

            }

            
        }
    }
