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
    public partial class frmBill : Form
    {
        string _Size, _CrustType, _WhereToEat, _Toppings;
        int _TotalPrice;
        public frmBill(string size, string crustType,string whereToEat, int totalPrice, string toppings)
        {
            InitializeComponent();

            this.Size = new Size(540, 960);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this._Size = size;
            this._CrustType = crustType;
            this._WhereToEat = whereToEat;
            this._TotalPrice = totalPrice;
            this._Toppings = toppings;

            DisplayBill();
        }

        private void DisplayBill()
        {
            lblSize.Text += _Size;
            lblCrustType.Text += _CrustType;
            lblWhere.Text += _WhereToEat;
            lblTotalPrice.Text += Convert.ToString(_TotalPrice) + " $";
            lblToppings.Text += _Toppings;
        }
    }
}