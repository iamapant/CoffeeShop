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
    public partial class Form8 : Form {
        Dictionary<string, int> list = new Dictionary<string, int>();
        public string note { get; set; }
        public int price { get; set; } = 0;
        //This form is for 'item options'. DO NOT change name until it's design is finalized
        public Form8(Panel p) {
            InitializeComponent();
            if (p == null) throw new Exception("Cannot find item");
            try {
                picItem.Image = p.Controls.OfType<PictureBox>().FirstOrDefault().Image;
                lbItem.Text = p.Controls.OfType<Label>().FirstOrDefault().Text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); Close(); }
        }

        private void Form8_Load(object sender, EventArgs e) {
            list = AddList();
            List<Label> labels = Controls.OfType<Label>().ToList();
            labels.AddRange(gbAdd.Controls.OfType<Label>().ToList());
            labels.AddRange(gbIce.Controls.OfType<Label>().ToList());
            labels.AddRange(gbSize.Controls.OfType<Label>().ToList());
            labels.AddRange(gbSugar.Controls.OfType<Label>().ToList());

            foreach (var item in list) {
                //if (labels.Find(l => l.Name == "lbPrice_" + item.Key) == null) MessageBox.Show(item.Key);
                try {
                    if (item.Value < 0) labels.FirstOrDefault(l => l.Name == "lbPrice_" + item.Key).Text = item.Value + ".000";
                    else if (item.Value == 0) labels.FirstOrDefault(l => l.Name == "lbPrice_" + item.Key).Text = "+0";
                    else labels.FirstOrDefault(l => l.Name == "lbPrice_" + item.Key).Text = "+" + item.Value + ".000";
                }
                catch { continue; }
            }
        }

        private Dictionary<string, int> AddList() {
            Dictionary<string, int> list = new Dictionary<string, int>();
            list.Add("Sm", -3);
            list.Add("Lg", 0);
            list.Add("XLg", 8);
            list.Add("TranChau", 8);
            list.Add("KemCheese", 18);
            list.Add("TranChauTrang", 12);
            list.Add("TranChauHoangKim", 12);
            list.Add("Pudding", 12);
            list.Add("ThachCaPhe", 12);
            list.Add("ThachDua", 12);
            list.Add("ThachTraiCay", 12);
            list.Add("DauDo", 12);
            list.Add("NhaDam", 12);
            return list;
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            var added = gbAdd.Controls.OfType<CheckBox>().ToList();
            foreach (var item in gbSize.Controls.OfType<RadioButton>().ToList()) {
                if (item.Checked) {
                    note += "Size = " + item.Text + ";";
                    price += list.FirstOrDefault(c => c.Key == item.Name.Substring(2)).Value;
                }
            }
            foreach (var item in gbIce.Controls.OfType<RadioButton>().ToList()) {
                if (item.Checked) {
                    note += "Ice = " + item.Text + ";";
                }
            }
            foreach (var item in gbSugar.Controls.OfType<RadioButton>().ToList()) {
                if (item.Checked) {
                    note += "Sugar = " + item.Text + ";";
                }
            }
            if (txtAddedNote.Text.Length > 0) {
                note += "note = " + txtAddedNote.Text + ";";
            }
            List<string> addList = new List<string>();
            foreach (var item in added) {
                if (item.Checked) {
                    price += list.FirstOrDefault(c => c.Key == item.Name.Substring(3)).Value;
                    addList.Add(list.FirstOrDefault(c => c.Key == item.Name.Substring(3)).Key);
                }
            }
            if (addList.Count > 0) {
                note += "Add = ";
                for (int i = 0; i < addList.Count; i++) {
                    note += addList[i];
                    if (i != addList.Count - 1) note += ", ";
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
