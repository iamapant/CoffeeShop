using BusinessObject.Models;
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
        User u = new User();
        //This form is for 'user shopping page'. DO NOT change name until it's design is finalized
        public Form3(User user) {
            InitializeComponent();
            u = user;
        }

        private void Form3_Load(object sender, EventArgs e) {
            try {

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnProfile_Click(object sender, EventArgs e) {

        }

        private void btnCart_Click(object sender, EventArgs e) {

        }
    }
}
