namespace CoffeeShopWinForm {
    partial class Form8 {
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
            panel1 = new Panel();
            btnOrder = new Button();
            gbAddedNote = new GroupBox();
            txtAddedNote = new TextBox();
            gbSize = new GroupBox();
            lbPrice_XLg = new Label();
            lbPrice_Lg = new Label();
            lbPrice_Sm = new Label();
            rbXLg = new RadioButton();
            rbLg = new RadioButton();
            rbSm = new RadioButton();
            gbAdd = new GroupBox();
            lbPrice_NhaDam = new Label();
            lbPrice_DauDo = new Label();
            lbPrice_ThachTraiCay = new Label();
            lbPrice_ThachDua = new Label();
            lbPrice_ThachCaPhe = new Label();
            lbPrice_Pudding = new Label();
            lbPrice_TranChauHoangKim = new Label();
            cbxNhaDam = new CheckBox();
            cbxDauDo = new CheckBox();
            cbxThachTraiCay = new CheckBox();
            cbxThachDua = new CheckBox();
            cbxThachCaPhe = new CheckBox();
            cbxPudding = new CheckBox();
            cbxTranChauHoangKim = new CheckBox();
            lbPrice_TranChauTrang = new Label();
            cbxTranChauTrang = new CheckBox();
            lbPrice_KemCheese = new Label();
            lbPrice_TranChau = new Label();
            cbxKemCheese = new CheckBox();
            cbxTranChau = new CheckBox();
            gbSugar = new GroupBox();
            rbSug50 = new RadioButton();
            rbSug70 = new RadioButton();
            rbSug100 = new RadioButton();
            gbIce = new GroupBox();
            rbHot = new RadioButton();
            rbIce50 = new RadioButton();
            rbIce70 = new RadioButton();
            rbIce100 = new RadioButton();
            picItem = new PictureBox();
            lbItem = new Label();
            panel1.SuspendLayout();
            gbAddedNote.SuspendLayout();
            gbSize.SuspendLayout();
            gbAdd.SuspendLayout();
            gbSugar.SuspendLayout();
            gbIce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picItem).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(gbAddedNote);
            panel1.Controls.Add(gbSize);
            panel1.Controls.Add(gbAdd);
            panel1.Controls.Add(gbSugar);
            panel1.Controls.Add(gbIce);
            panel1.Location = new Point(0, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 359);
            panel1.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(75, 772);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(131, 38);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // gbAddedNote
            // 
            gbAddedNote.Controls.Add(txtAddedNote);
            gbAddedNote.Location = new Point(3, 656);
            gbAddedNote.Name = "gbAddedNote";
            gbAddedNote.Size = new Size(251, 100);
            gbAddedNote.TabIndex = 1;
            gbAddedNote.TabStop = false;
            gbAddedNote.Text = "groupBox1";
            // 
            // txtAddedNote
            // 
            txtAddedNote.Location = new Point(24, 22);
            txtAddedNote.Multiline = true;
            txtAddedNote.Name = "txtAddedNote";
            txtAddedNote.PlaceholderText = "Note";
            txtAddedNote.Size = new Size(210, 58);
            txtAddedNote.TabIndex = 0;
            // 
            // gbSize
            // 
            gbSize.Controls.Add(lbPrice_XLg);
            gbSize.Controls.Add(lbPrice_Lg);
            gbSize.Controls.Add(lbPrice_Sm);
            gbSize.Controls.Add(rbXLg);
            gbSize.Controls.Add(rbLg);
            gbSize.Controls.Add(rbSm);
            gbSize.Location = new Point(3, 3);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(251, 102);
            gbSize.TabIndex = 3;
            gbSize.TabStop = false;
            gbSize.Text = "Upsize";
            // 
            // lbPrice_XLg
            // 
            lbPrice_XLg.AutoSize = true;
            lbPrice_XLg.Location = new Point(189, 74);
            lbPrice_XLg.Name = "lbPrice_XLg";
            lbPrice_XLg.Size = new Size(34, 15);
            lbPrice_XLg.TabIndex = 5;
            lbPrice_XLg.Text = "0.000";
            // 
            // lbPrice_Lg
            // 
            lbPrice_Lg.AutoSize = true;
            lbPrice_Lg.Location = new Point(189, 51);
            lbPrice_Lg.Name = "lbPrice_Lg";
            lbPrice_Lg.Size = new Size(34, 15);
            lbPrice_Lg.TabIndex = 4;
            lbPrice_Lg.Text = "0.000";
            // 
            // lbPrice_Sm
            // 
            lbPrice_Sm.AutoSize = true;
            lbPrice_Sm.Location = new Point(189, 26);
            lbPrice_Sm.Name = "lbPrice_Sm";
            lbPrice_Sm.Size = new Size(34, 15);
            lbPrice_Sm.TabIndex = 3;
            lbPrice_Sm.Text = "0.000";
            // 
            // rbXLg
            // 
            rbXLg.AutoSize = true;
            rbXLg.Location = new Point(35, 72);
            rbXLg.Name = "rbXLg";
            rbXLg.Size = new Size(69, 19);
            rbXLg.TabIndex = 2;
            rbXLg.Text = "Cực Lớn";
            rbXLg.UseVisualStyleBackColor = true;
            // 
            // rbLg
            // 
            rbLg.AutoSize = true;
            rbLg.Checked = true;
            rbLg.Location = new Point(35, 47);
            rbLg.Name = "rbLg";
            rbLg.Size = new Size(45, 19);
            rbLg.TabIndex = 1;
            rbLg.TabStop = true;
            rbLg.Text = "Lớn";
            rbLg.UseVisualStyleBackColor = true;
            // 
            // rbSm
            // 
            rbSm.AutoSize = true;
            rbSm.Location = new Point(35, 22);
            rbSm.Name = "rbSm";
            rbSm.Size = new Size(66, 19);
            rbSm.TabIndex = 0;
            rbSm.Text = "Thường";
            rbSm.UseVisualStyleBackColor = true;
            // 
            // gbAdd
            // 
            gbAdd.Controls.Add(lbPrice_NhaDam);
            gbAdd.Controls.Add(lbPrice_DauDo);
            gbAdd.Controls.Add(lbPrice_ThachTraiCay);
            gbAdd.Controls.Add(lbPrice_ThachDua);
            gbAdd.Controls.Add(lbPrice_ThachCaPhe);
            gbAdd.Controls.Add(lbPrice_Pudding);
            gbAdd.Controls.Add(lbPrice_TranChauHoangKim);
            gbAdd.Controls.Add(cbxNhaDam);
            gbAdd.Controls.Add(cbxDauDo);
            gbAdd.Controls.Add(cbxThachTraiCay);
            gbAdd.Controls.Add(cbxThachDua);
            gbAdd.Controls.Add(cbxThachCaPhe);
            gbAdd.Controls.Add(cbxPudding);
            gbAdd.Controls.Add(cbxTranChauHoangKim);
            gbAdd.Controls.Add(lbPrice_TranChauTrang);
            gbAdd.Controls.Add(cbxTranChauTrang);
            gbAdd.Controls.Add(lbPrice_KemCheese);
            gbAdd.Controls.Add(lbPrice_TranChau);
            gbAdd.Controls.Add(cbxKemCheese);
            gbAdd.Controls.Add(cbxTranChau);
            gbAdd.Location = new Point(3, 364);
            gbAdd.Name = "gbAdd";
            gbAdd.Size = new Size(251, 286);
            gbAdd.TabIndex = 2;
            gbAdd.TabStop = false;
            gbAdd.Text = "Thêm";
            // 
            // lbPrice_NhaDam
            // 
            lbPrice_NhaDam.AutoSize = true;
            lbPrice_NhaDam.Location = new Point(189, 261);
            lbPrice_NhaDam.Name = "lbPrice_NhaDam";
            lbPrice_NhaDam.Size = new Size(34, 15);
            lbPrice_NhaDam.TabIndex = 19;
            lbPrice_NhaDam.Text = "0.000";
            // 
            // lbPrice_DauDo
            // 
            lbPrice_DauDo.AutoSize = true;
            lbPrice_DauDo.Location = new Point(189, 236);
            lbPrice_DauDo.Name = "lbPrice_DauDo";
            lbPrice_DauDo.Size = new Size(34, 15);
            lbPrice_DauDo.TabIndex = 18;
            lbPrice_DauDo.Text = "0.000";
            // 
            // lbPrice_ThachTraiCay
            // 
            lbPrice_ThachTraiCay.AutoSize = true;
            lbPrice_ThachTraiCay.Location = new Point(189, 211);
            lbPrice_ThachTraiCay.Name = "lbPrice_ThachTraiCay";
            lbPrice_ThachTraiCay.Size = new Size(34, 15);
            lbPrice_ThachTraiCay.TabIndex = 17;
            lbPrice_ThachTraiCay.Text = "0.000";
            // 
            // lbPrice_ThachDua
            // 
            lbPrice_ThachDua.AutoSize = true;
            lbPrice_ThachDua.Location = new Point(189, 186);
            lbPrice_ThachDua.Name = "lbPrice_ThachDua";
            lbPrice_ThachDua.Size = new Size(34, 15);
            lbPrice_ThachDua.TabIndex = 16;
            lbPrice_ThachDua.Text = "0.000";
            // 
            // lbPrice_ThachCaPhe
            // 
            lbPrice_ThachCaPhe.AutoSize = true;
            lbPrice_ThachCaPhe.Location = new Point(189, 161);
            lbPrice_ThachCaPhe.Name = "lbPrice_ThachCaPhe";
            lbPrice_ThachCaPhe.Size = new Size(34, 15);
            lbPrice_ThachCaPhe.TabIndex = 15;
            lbPrice_ThachCaPhe.Text = "0.000";
            // 
            // lbPrice_Pudding
            // 
            lbPrice_Pudding.AutoSize = true;
            lbPrice_Pudding.Location = new Point(189, 136);
            lbPrice_Pudding.Name = "lbPrice_Pudding";
            lbPrice_Pudding.Size = new Size(34, 15);
            lbPrice_Pudding.TabIndex = 14;
            lbPrice_Pudding.Text = "0.000";
            // 
            // lbPrice_TranChauHoangKim
            // 
            lbPrice_TranChauHoangKim.AutoSize = true;
            lbPrice_TranChauHoangKim.Location = new Point(189, 111);
            lbPrice_TranChauHoangKim.Name = "lbPrice_TranChauHoangKim";
            lbPrice_TranChauHoangKim.Size = new Size(34, 15);
            lbPrice_TranChauHoangKim.TabIndex = 13;
            lbPrice_TranChauHoangKim.Text = "0.000";
            // 
            // cbxNhaDam
            // 
            cbxNhaDam.AutoSize = true;
            cbxNhaDam.Location = new Point(35, 257);
            cbxNhaDam.Name = "cbxNhaDam";
            cbxNhaDam.Size = new Size(75, 19);
            cbxNhaDam.TabIndex = 12;
            cbxNhaDam.Text = "Nha đam";
            cbxNhaDam.UseVisualStyleBackColor = true;
            // 
            // cbxDauDo
            // 
            cbxDauDo.AutoSize = true;
            cbxDauDo.Location = new Point(35, 232);
            cbxDauDo.Name = "cbxDauDo";
            cbxDauDo.Size = new Size(64, 19);
            cbxDauDo.TabIndex = 11;
            cbxDauDo.Text = "Đậu đỏ";
            cbxDauDo.UseVisualStyleBackColor = true;
            // 
            // cbxThachTraiCay
            // 
            cbxThachTraiCay.AutoSize = true;
            cbxThachTraiCay.Location = new Point(35, 207);
            cbxThachTraiCay.Name = "cbxThachTraiCay";
            cbxThachTraiCay.Size = new Size(99, 19);
            cbxThachTraiCay.TabIndex = 10;
            cbxThachTraiCay.Text = "Thạch trái cây";
            cbxThachTraiCay.UseVisualStyleBackColor = true;
            // 
            // cbxThachDua
            // 
            cbxThachDua.AutoSize = true;
            cbxThachDua.Location = new Point(35, 182);
            cbxThachDua.Name = "cbxThachDua";
            cbxThachDua.Size = new Size(81, 19);
            cbxThachDua.TabIndex = 9;
            cbxThachDua.Text = "Thạch dừa";
            cbxThachDua.UseVisualStyleBackColor = true;
            // 
            // cbxThachCaPhe
            // 
            cbxThachCaPhe.AutoSize = true;
            cbxThachCaPhe.Location = new Point(35, 157);
            cbxThachCaPhe.Name = "cbxThachCaPhe";
            cbxThachCaPhe.Size = new Size(98, 19);
            cbxThachCaPhe.TabIndex = 8;
            cbxThachCaPhe.Text = "Thạch Cà Phê";
            cbxThachCaPhe.UseVisualStyleBackColor = true;
            // 
            // cbxPudding
            // 
            cbxPudding.AutoSize = true;
            cbxPudding.Location = new Point(35, 132);
            cbxPudding.Name = "cbxPudding";
            cbxPudding.Size = new Size(71, 19);
            cbxPudding.TabIndex = 7;
            cbxPudding.Text = "Pudding";
            cbxPudding.UseVisualStyleBackColor = true;
            // 
            // cbxTranChauHoangKim
            // 
            cbxTranChauHoangKim.AutoSize = true;
            cbxTranChauHoangKim.Location = new Point(35, 107);
            cbxTranChauHoangKim.Name = "cbxTranChauHoangKim";
            cbxTranChauHoangKim.Size = new Size(137, 19);
            cbxTranChauHoangKim.TabIndex = 6;
            cbxTranChauHoangKim.Text = "Trân châu hoàng kim";
            cbxTranChauHoangKim.UseVisualStyleBackColor = true;
            // 
            // lbPrice_TranChauTrang
            // 
            lbPrice_TranChauTrang.AutoSize = true;
            lbPrice_TranChauTrang.Location = new Point(189, 86);
            lbPrice_TranChauTrang.Name = "lbPrice_TranChauTrang";
            lbPrice_TranChauTrang.Size = new Size(34, 15);
            lbPrice_TranChauTrang.TabIndex = 5;
            lbPrice_TranChauTrang.Text = "0.000";
            // 
            // cbxTranChauTrang
            // 
            cbxTranChauTrang.AutoSize = true;
            cbxTranChauTrang.Location = new Point(35, 82);
            cbxTranChauTrang.Name = "cbxTranChauTrang";
            cbxTranChauTrang.Size = new Size(108, 19);
            cbxTranChauTrang.TabIndex = 4;
            cbxTranChauTrang.Text = "Trân châu trắng";
            cbxTranChauTrang.UseVisualStyleBackColor = true;
            // 
            // lbPrice_KemCheese
            // 
            lbPrice_KemCheese.AutoSize = true;
            lbPrice_KemCheese.Location = new Point(189, 61);
            lbPrice_KemCheese.Name = "lbPrice_KemCheese";
            lbPrice_KemCheese.Size = new Size(34, 15);
            lbPrice_KemCheese.TabIndex = 3;
            lbPrice_KemCheese.Text = "0.000";
            // 
            // lbPrice_TranChau
            // 
            lbPrice_TranChau.AutoSize = true;
            lbPrice_TranChau.Location = new Point(189, 36);
            lbPrice_TranChau.Name = "lbPrice_TranChau";
            lbPrice_TranChau.Size = new Size(34, 15);
            lbPrice_TranChau.TabIndex = 2;
            lbPrice_TranChau.Text = "0.000";
            // 
            // cbxKemCheese
            // 
            cbxKemCheese.AutoSize = true;
            cbxKemCheese.Location = new Point(35, 57);
            cbxKemCheese.Name = "cbxKemCheese";
            cbxKemCheese.Size = new Size(89, 19);
            cbxKemCheese.TabIndex = 1;
            cbxKemCheese.Text = "Kem cheese";
            cbxKemCheese.UseVisualStyleBackColor = true;
            // 
            // cbxTranChau
            // 
            cbxTranChau.AutoSize = true;
            cbxTranChau.Location = new Point(35, 32);
            cbxTranChau.Name = "cbxTranChau";
            cbxTranChau.Size = new Size(100, 19);
            cbxTranChau.TabIndex = 0;
            cbxTranChau.Text = "Trân châu đen";
            cbxTranChau.UseVisualStyleBackColor = true;
            // 
            // gbSugar
            // 
            gbSugar.Controls.Add(rbSug50);
            gbSugar.Controls.Add(rbSug70);
            gbSugar.Controls.Add(rbSug100);
            gbSugar.Location = new Point(3, 245);
            gbSugar.Name = "gbSugar";
            gbSugar.Size = new Size(251, 113);
            gbSugar.TabIndex = 1;
            gbSugar.TabStop = false;
            gbSugar.Text = "Đường";
            // 
            // rbSug50
            // 
            rbSug50.AutoSize = true;
            rbSug50.Location = new Point(35, 82);
            rbSug50.Name = "rbSug50";
            rbSug50.Size = new Size(86, 19);
            rbSug50.TabIndex = 2;
            rbSug50.Text = "Đường 50%";
            rbSug50.UseVisualStyleBackColor = true;
            // 
            // rbSug70
            // 
            rbSug70.AutoSize = true;
            rbSug70.Location = new Point(35, 57);
            rbSug70.Name = "rbSug70";
            rbSug70.Size = new Size(86, 19);
            rbSug70.TabIndex = 1;
            rbSug70.Text = "Đường 70%";
            rbSug70.UseVisualStyleBackColor = true;
            // 
            // rbSug100
            // 
            rbSug100.AutoSize = true;
            rbSug100.Checked = true;
            rbSug100.Location = new Point(35, 31);
            rbSug100.Name = "rbSug100";
            rbSug100.Size = new Size(92, 19);
            rbSug100.TabIndex = 0;
            rbSug100.TabStop = true;
            rbSug100.Text = "Đường 100%";
            rbSug100.UseVisualStyleBackColor = true;
            // 
            // gbIce
            // 
            gbIce.Controls.Add(rbHot);
            gbIce.Controls.Add(rbIce50);
            gbIce.Controls.Add(rbIce70);
            gbIce.Controls.Add(rbIce100);
            gbIce.Location = new Point(3, 111);
            gbIce.Name = "gbIce";
            gbIce.Size = new Size(251, 128);
            gbIce.TabIndex = 0;
            gbIce.TabStop = false;
            gbIce.Text = "Đá";
            // 
            // rbHot
            // 
            rbHot.AutoSize = true;
            rbHot.Location = new Point(35, 97);
            rbHot.Name = "rbHot";
            rbHot.Size = new Size(45, 19);
            rbHot.TabIndex = 3;
            rbHot.Text = "Hot";
            rbHot.UseVisualStyleBackColor = true;
            // 
            // rbIce50
            // 
            rbIce50.AutoSize = true;
            rbIce50.Location = new Point(35, 72);
            rbIce50.Name = "rbIce50";
            rbIce50.Size = new Size(64, 19);
            rbIce50.TabIndex = 2;
            rbIce50.Text = "Đá 50%";
            rbIce50.UseVisualStyleBackColor = true;
            // 
            // rbIce70
            // 
            rbIce70.AutoSize = true;
            rbIce70.Location = new Point(35, 47);
            rbIce70.Name = "rbIce70";
            rbIce70.Size = new Size(64, 19);
            rbIce70.TabIndex = 1;
            rbIce70.Text = "Đá 70%";
            rbIce70.UseVisualStyleBackColor = true;
            // 
            // rbIce100
            // 
            rbIce100.AutoSize = true;
            rbIce100.Checked = true;
            rbIce100.Location = new Point(35, 22);
            rbIce100.Name = "rbIce100";
            rbIce100.Size = new Size(70, 19);
            rbIce100.TabIndex = 0;
            rbIce100.TabStop = true;
            rbIce100.Text = "Đá 100%";
            rbIce100.UseVisualStyleBackColor = true;
            // 
            // picItem
            // 
            picItem.Location = new Point(49, 21);
            picItem.Name = "picItem";
            picItem.Size = new Size(184, 165);
            picItem.SizeMode = PictureBoxSizeMode.CenterImage;
            picItem.TabIndex = 1;
            picItem.TabStop = false;
            // 
            // lbItem
            // 
            lbItem.AutoSize = true;
            lbItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbItem.Location = new Point(92, 201);
            lbItem.Name = "lbItem";
            lbItem.Size = new Size(92, 21);
            lbItem.TabIndex = 2;
            lbItem.Text = "Item name";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 618);
            Controls.Add(lbItem);
            Controls.Add(picItem);
            Controls.Add(panel1);
            Name = "Form8";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form8";
            Load += Form8_Load;
            panel1.ResumeLayout(false);
            gbAddedNote.ResumeLayout(false);
            gbAddedNote.PerformLayout();
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbAdd.ResumeLayout(false);
            gbAdd.PerformLayout();
            gbSugar.ResumeLayout(false);
            gbSugar.PerformLayout();
            gbIce.ResumeLayout(false);
            gbIce.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox gbSugar;
        private RadioButton rbSug50;
        private RadioButton rbSug70;
        private RadioButton rbSug100;
        private GroupBox gbIce;
        private RadioButton rbHot;
        private RadioButton rbIce50;
        private RadioButton rbIce70;
        private RadioButton rbIce100;
        private Button btnOrder;
        private GroupBox gbAddedNote;
        private TextBox txtAddedNote;
        private GroupBox gbSize;
        private Label lbPrice_XLg;
        private Label lbPrice_Lg;
        private Label lbPrice_Sm;
        private RadioButton rbXLg;
        private RadioButton rbLg;
        private RadioButton rbSm;
        private GroupBox gbAdd;
        private Label lbPrice_NhaDam;
        private Label lbPrice_DauDo;
        private Label lbPrice_ThachTraiCay;
        private Label lbPrice_ThachDua;
        private Label lbPrice_ThachCaPhe;
        private Label lbPrice_Pudding;
        private Label lbPrice_TranChauHoangKim;
        private CheckBox cbxNhaDam;
        private CheckBox cbxDauDo;
        private CheckBox cbxThachTraiCay;
        private CheckBox cbxThachDua;
        private CheckBox cbxThachCaPhe;
        private CheckBox cbxPudding;
        private CheckBox cbxTranChauHoangKim;
        private Label lbPrice_TranChauTrang;
        private CheckBox cbxTranChauTrang;
        private Label lbPrice_KemCheese;
        private Label lbPrice_TranChau;
        private CheckBox cbxKemCheese;
        private CheckBox cbxTranChau;
        private PictureBox picItem;
        private Label lbItem;
    }
}