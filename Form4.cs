using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzanova
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();

            checkBox1.CheckedChanged += chBox_CheckedChanged;
            checkBox2.CheckedChanged += chBox_CheckedChanged;
            checkBox3.CheckedChanged += chBox_CheckedChanged;
            checkBox4.CheckedChanged += chBox_CheckedChanged;
            checkBox5.CheckedChanged += chBox_CheckedChanged;
            checkBox6.CheckedChanged += chBox_CheckedChanged;

            rdbtnThin.CheckedChanged += rbCrustType_CheckedChanged;
            rdbtnThick.CheckedChanged += rbCrustType_CheckedChanged;

            rdbtnSmall.CheckedChanged += rbSize_CheckedChanged;
            rdbtnMedium.CheckedChanged += rbSize_CheckedChanged;
            rdbtnLarge.CheckedChanged += rbSize_CheckedChanged;

            rdbtnOut.CheckedChanged += rbWhereToEat_CheckedChanged;
            rdbtnIn.CheckedChanged += rbWhereToEat_CheckedChanged;
        }

        protected int totalPrice = 0;
        int sizePrice = 0;
        int crustTypePrice = 0;
        int ToppingsPrice = 0;
        bool isOrderConfirmed = false;
        string txtSize = "", txtCrustType = "", txtWhereToEat = "", txtToppings = "";

        private void UpdateSizePrice(int newSizePrice)
        {
            totalPrice -= sizePrice;
            sizePrice = newSizePrice;

            totalPrice += sizePrice;
        }

        private void UpdateSizeText(string rbText)
        {
            txtSize = rbText;
        }

        private void rbSize_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                int newSizePrice = Convert.ToInt32(rb.Tag);

                UpdateSizePrice(newSizePrice);

                UpdateSizeText(rb.Text);

                UpdateTotalPrice();
            }
        }
        
        private void rbCrustType_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                int newcrustTypePrice = Convert.ToInt32(rb.Tag);

                totalPrice -= crustTypePrice;
                crustTypePrice = newcrustTypePrice;

                totalPrice += crustTypePrice;

                txtCrustType = rb.Text;

                UpdateTotalPrice();
            }
        }

        private void chBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chBox = sender as CheckBox;

            if (chBox.Checked)
            {
                int newToppingsPrice = Convert.ToInt32(chBox.Tag);

                totalPrice -= ToppingsPrice;
                ToppingsPrice += newToppingsPrice;

                totalPrice += ToppingsPrice;

                txtToppings += chBox.Text + "\n";

                UpdateTotalPrice();
            }
        }

        private void rbWhereToEat_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked)
            {
                txtWhereToEat = rb.Text;
            }
        }

        public void UpdateTotalPrice()
        {
            lblTotalPrice.Text = totalPrice.ToString() + " $";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!isOrderConfirmed)
            {
                DialogResult Result = MessageBox.Show(
                    "Confirm Order?",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (Result == DialogResult.Yes)
                {
                    btnOrderBill.Enabled = true;
                    isOrderConfirmed = true;
                }
            }
            else
            {
                DialogResult Result = MessageBox.Show(
                    "Order Confirmed",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                btnOrderBill.Enabled = true;
                btnOrder.Enabled = false;
            }
        }

        private void btnOrderBill_Click(object sender, EventArgs e)
        {
            Form frm = new frmBill(txtSize, txtCrustType, txtWhereToEat, totalPrice, txtToppings);

            frm.ShowDialog();
        }
    }
}