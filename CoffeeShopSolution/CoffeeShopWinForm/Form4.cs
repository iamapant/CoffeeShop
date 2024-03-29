﻿using BusinessObject.Models;
using DataAccess.Repositories.Inteface;
using DataAccess.Repositories.Repo;
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
    public partial class Form4 : Form {
        ICartRepository cartRepository = new CartRepository();
        User u = new User();
        //This form is for 'user cart and purchase'. DO NOT change name until it's design is finalized
        public Form4(User user) {
            InitializeComponent();
            u = user;
        }

        private void Form4_Load(object sender, EventArgs e) {
            string a = cartRepository.GetCartByUserId(u.UserId).First().Note;
            MessageBox.Show(a.Length.ToString());
        }
    }
}
