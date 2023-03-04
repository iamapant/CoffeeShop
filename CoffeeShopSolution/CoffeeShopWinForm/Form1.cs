using BusinessObject.Models;
using DataAccess;
using DataAccess.Repositories.Repo;
using Microsoft.IdentityModel.Tokens;

namespace CoffeeShopWinForm
{
    public partial class Form1 : Form {
        //This form is for 'initial login'. DO NOT change name until it's design is finalized
        UserRepository repository = new UserRepository();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            bool checkUser = false, checkPass = false;
            if (txtUser.Text.IsNullOrEmpty()) {
                txtUser.Focus();
                errLogin.SetError(txtUser, "Username must not be blank!");
            }
            else {
                errLogin.SetError(txtUser, "");
                checkUser= true;
            }
            if (txtPass.Text.IsNullOrEmpty()) {
                txtPass.Focus();
                errLogin.SetError(txtPass, "Password must not be blank!");
            }
            else {
                errLogin.SetError(txtPass, "");
                checkPass= true;
            }
            if(checkUser && checkPass) {
                User user = repository.GetUserByLogin(txtUser.Text.Trim(), txtPass.Text.Trim());
                if (user != null) { 
                    Form2 frm = new Form2(user);
                    frm.ShowDialog();
                }
                else MessageBox.Show("Cannot find user.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {

        }

        private void txtUser_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if(txtUser.Text.IsNullOrEmpty()) { 
                e.Cancel = true;
                txtUser.Focus();
                errLogin.SetError(txtUser, "Username must not be blank!");
            }
            else {
                errLogin.SetError(txtUser, "");
            }
        }

        private void txtPass_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            if (txtPass.Text.IsNullOrEmpty()) {
                
                errLogin.SetError(txtPass, "Password must not be blank!");
            }
            else {
                errLogin.SetError(txtPass, "");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
        }
    }
}