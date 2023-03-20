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
            txtUser.Focus();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            bool checkUser = false, checkPass = false, checkLogin = false;
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
            if (repository.GetUsers().Where(c => c.UserName == txtUser.Text || c.Email == txtUser.Text).Count() == 0) {
                MessageBox.Show("Cannot find user.");
                txtUser.Clear();
                txtPass.Clear();
                ActiveControl = txtUser;
                return;
            }
            else checkLogin = true;
            if(checkUser && checkPass && checkLogin) {
                User user = repository.GetUserByLogin(txtUser.Text.Trim(), txtPass.Text.Trim());
                if (user != null) {
                    if(user.UserName == "admin") {
                        Form6 frmAdmin = new Form6(user);
                        frmAdmin.ShowDialog();
                        return;
                    }
                    Form3 frm = new Form3(user);
                    frm.ShowDialog();
                    return;
                }
                else MessageBox.Show("Username or password incorrect.");
            }
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2();
            form2.FormClosed += new FormClosedEventHandler(focus_Close);
            form2.ShowDialog();
            return;
        }

        private void focus_Close(object? sender, EventArgs e) {
            txtUser.Select();
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