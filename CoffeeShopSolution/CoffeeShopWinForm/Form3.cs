using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using DataAccess.Repositories.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopWinForm {
    public partial class Form3 : Form {
        IItemRepository repository = new ItemRepository();
        CoffeeShopContext context = new CoffeeShopContext();
        User u = new User();
        //This form is for 'user shopping page'. DO NOT change name until it's design is finalized
        public Form3(User user) {
            InitializeComponent();
            u = user;
            context.Items.Load();
        }

        private void Form3_Load(object sender, EventArgs e) {
            try {
                foreach (var item in repository.GetItems()) {
                    if (item.Stock > 0) {
                        Panel p1 = NewPanel(repository.GetItemById(item.ItemId));
                        fpCatalog.Controls.Add(p1);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private Panel NewPanel(Item? item) {
            Panel p = new Panel();
            p.Size = new Size(243, 264);
            p.Name = "p" + item.ItemId;
            Label label = new Label { Location = new Point(91, 188), Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point), Name = "lb" + item.ItemId, Text = item.ItemName };
            Button btn = new Button { Location = new Point(144, 218), Size = new Size(85, 23), Name = "btn" + item.ItemId, Text = "Add to cart" };
            NumericUpDown amt = new NumericUpDown { Location = new Point(18, 218), Name = "num" + item.ItemId, Size = new Size(120, 23), Value = 1, Maximum = item.Stock };
            PictureBox pic = new PictureBox { Image = Properties.Resources.banbaro, Location = new Point(29, 16), Size = new Size(184, 165), Name = "pic" + item.ItemId, SizeMode = PictureBoxSizeMode.CenterImage };
            p.Controls.Add(label);
            p.Controls.Add(btn);
            p.Controls.Add(amt);
            p.Controls.Add(pic);
            btn.Click += btnAddToCart_Click;
            return p;
        }

        private void btnAddToCart_Click(object sender, EventArgs e) {
            try {
                var btn = (Button)sender;
                int id = int.Parse(btn.Name.Substring(3));
                string note = null;
                int price = 0;
                Form8 frmGetOptions = new Form8((Panel)this.Controls.Find("p" + id, true).FirstOrDefault());
                var result = frmGetOptions.ShowDialog();
                if (result == DialogResult.OK) {
                    note = frmGetOptions.note;
                    price = frmGetOptions.price;
                }
                var numeric = (NumericUpDown)this.Controls.Find("num" + id, true).FirstOrDefault();
                int amount = (int)numeric.Value;
                if (amount > 0) {
                    try {
                        ICartRepository cart = new CartRepository();
                        cart.AddCartItem(u.UserId, id, amount, note, price);
                        MessageBox.Show("Cart updated.");
                    }
                    catch (Exception ex) {
                        MessageBox.Show($"Item {0}does not have enough of stock.", repository.GetItemById(id).ItemName);
                        if (repository.GetItemById(id).Stock <= 0) this.Controls.Remove(this.Controls.Find("p" + id, true).FirstOrDefault());
                    }
                }
                else {
                    MessageBox.Show($"Please specify the amount of {0}(s) you want to add to your cart in the number box.", repository.GetItemById(id).ItemName);
                    numeric.Focus();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e) {

        }

        private void btnCart_Click(object sender, EventArgs e) {
            Form4 frmCart = new Form4(u);
            frmCart.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e) {
            DialogResult = DialogResult.OK;
            Application.Exit();
        }
    }
}
