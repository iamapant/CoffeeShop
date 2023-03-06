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
    public partial class Form6 : Form {
        //This form is for 'admin user'. DO NOT change name until it's design is finalized
        User admin;
        public Form6(User admin) {
            InitializeComponent();
            this.admin = admin;
        }

        private void Form6_Load(object sender, EventArgs e) {
            label1.Text = admin.UserName;
        }
    }
}
