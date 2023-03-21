namespace CoffeeShopWinForm {
    partial class Form3 {
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
            fpCatalog = new FlowLayoutPanel();
            btnProfile = new Button();
            btnCart = new Button();
            SuspendLayout();
            // 
            // fpCatalog
            // 
            fpCatalog.AutoScroll = true;
            fpCatalog.Location = new Point(0, 41);
            fpCatalog.Name = "fpCatalog";
            fpCatalog.Size = new Size(543, 533);
            fpCatalog.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(12, 12);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(75, 23);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCart
            // 
            btnCart.Location = new Point(456, 12);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(75, 23);
            btnCart.TabIndex = 2;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = true;
            btnCart.Click += btnCart_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 574);
            Controls.Add(btnCart);
            Controls.Add(btnProfile);
            Controls.Add(fpCatalog);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fpCatalog;
        private Button btnProfile;
        private Button btnCart;
    }
}