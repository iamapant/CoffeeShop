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
    public partial class Form2 : Form {
        User user;
        //This form is for 'creating user account'. DO NOT change name until it's design is finalized
        public Form2(User u) {
            InitializeComponent();
            user = u;
        }

        private void Form2_Load(object sender, EventArgs e) {
            lbUser.Text = user.UserName;
        }
    }
}
