using BusinessObject.Models;
using DataAccess;
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
    public partial class Form2 : Form {
        UserRepository repository = new UserRepository();
        //This form is for 'creating user account'. DO NOT change name until it's design is finalized
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            bool check = false;
            try {
                checkEmpty();
                matchPasswordAndName();
                checkExists();
                check = true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            if (check) {
                User u = new User {
                    UserName = txtName.Text,
                    Password = txtPwd.Text,
                    Email = txtEmail.Text
                };
                repository.AddUser(u);
                MessageBox.Show("User created.");
                this.Close();
            }
        }

        private void checkEmpty() {
            bool check = false;
            if (txtName == null) { check = true; }
            if (txtPwd == null) { check = true; }
            if (txtEmail == null) { check = true; }
            if (txtPwdCfm == null) { check = true; }
            if (check) throw new Exception("Field(s) must not be empty!");
        }

        private void matchPasswordAndName() {
            if (txtPwd.Text != txtPwdCfm.Text) throw new Exception("Password do not match.");
            if (txtName.Text.Length < 6 || txtName.Text.Length > 40) throw new Exception("Username must be between 6 and 40 characters.");
            if (txtPwd.Text.Length < 6 || txtPwd.Text.Length > 40) throw new Exception("Password must be between 6 and 40 characters.");
        }

        private void checkExists() {
            if (repository.GetUsers().Where(c => c.UserName == txtName.Text).Count() != 0) throw new Exception("Username already used.");
            if (repository.GetUsers().Where(c => c.Email == txtEmail.Text).Count() != 0) throw new Exception("Email already used.");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e) {

        }
    }
}
