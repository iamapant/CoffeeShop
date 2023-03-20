namespace CoffeeShopWinForm {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lbName = new Label();
            lbPwd = new Label();
            lbPwdCfm = new Label();
            lbEmail = new Label();
            txtName = new TextBox();
            txtPwdCfm = new TextBox();
            txtPwd = new TextBox();
            txtEmail = new TextBox();
            lbTitle = new Label();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(27, 70);
            lbName.Name = "lbName";
            lbName.Size = new Size(63, 15);
            lbName.TabIndex = 10;
            lbName.Text = "Username:";
            // 
            // lbPwd
            // 
            lbPwd.AutoSize = true;
            lbPwd.Location = new Point(27, 102);
            lbPwd.Name = "lbPwd";
            lbPwd.Size = new Size(60, 15);
            lbPwd.TabIndex = 9;
            lbPwd.Text = "Password:";
            // 
            // lbPwdCfm
            // 
            lbPwdCfm.AutoSize = true;
            lbPwdCfm.Location = new Point(27, 139);
            lbPwdCfm.Name = "lbPwdCfm";
            lbPwdCfm.Size = new Size(107, 15);
            lbPwdCfm.TabIndex = 6;
            lbPwdCfm.Text = "Confirm Password:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(27, 172);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(44, 15);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "E-mail:";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(183, 23);
            txtName.TabIndex = 0;
            // 
            // txtPwdCfm
            // 
            txtPwdCfm.Location = new Point(138, 136);
            txtPwdCfm.Name = "txtPwdCfm";
            txtPwdCfm.PasswordChar = '*';
            txtPwdCfm.Size = new Size(183, 23);
            txtPwdCfm.TabIndex = 2;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(138, 99);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.Size = new Size(183, 23);
            txtPwd.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(183, 23);
            txtEmail.TabIndex = 3;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(138, 18);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(124, 30);
            lbTitle.TabIndex = 8;
            lbTitle.Text = "Create user";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(169, 211);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // Form2
            // 
            AcceptButton = btnCreate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 246);
            Controls.Add(btnCreate);
            Controls.Add(lbTitle);
            Controls.Add(txtEmail);
            Controls.Add(txtPwd);
            Controls.Add(txtPwdCfm);
            Controls.Add(txtName);
            Controls.Add(lbEmail);
            Controls.Add(lbPwdCfm);
            Controls.Add(lbPwd);
            Controls.Add(lbName);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbPwd;
        private Label lbPwdCfm;
        private Label lbEmail;
        private TextBox txtName;
        private TextBox txtPwdCfm;
        private TextBox txtPwd;
        private TextBox txtEmail;
        private Label lbTitle;
        private Button btnCreate;
    }
}