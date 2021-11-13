using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vadym_Logvynenko_Exercise01
{
    public partial class frmOrder : Form
    {
        public double subTotal;
        public double discountResult;
        bool disc = false;
        double subTotalResult;
        double taxResult;


        public frmOrder()
        {
            InitializeComponent();
        }

        private void cmbCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCustomerType.Text == "Student" || cmbCustomerType.Text == "Teacher")
            {
                disc = true;
                lblDiscountResult.Text = (subTotal * 0.15).ToString("C");
                discountResult = subTotal * 0.15;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }
            else
            {
                disc = false;
                lblDiscountResult.Text = "0%";
                discountResult = subTotal * 0;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }
        }

        private void chbMouse_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMouse.Checked)
                subTotal += 30;
            else
                subTotal -= 30;
            if (disc)
            {
                lblDiscountResult.Text = (subTotal * 0.15).ToString("C");
                discountResult = subTotal * 0.15;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }
            else
            {
                lblDiscountResult.Text = "0%";
                discountResult = subTotal * 0;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }            
        }

        private void chbKeyboard_CheckedChanged(object sender, EventArgs e)
        {
            if (chbKeyboard.Checked)
                subTotal += 50;
            else
                subTotal -= 50;
            if (disc)
            {
                lblDiscountResult.Text = (subTotal * 0.15).ToString("C");
                discountResult = subTotal * 0.15;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }
            else
            {
                lblDiscountResult.Text = "0%";
                discountResult = subTotal * 0;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }            
        }

        private void chbPrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPrinter.Checked)
                subTotal += 80;
            else
                subTotal -= 80;
            if (disc)
            {
                lblDiscountResult.Text = (subTotal * 0.15).ToString("C");
                discountResult = subTotal * 0.15;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }
            else
            {
                lblDiscountResult.Text = "0%";
                discountResult = subTotal * 0;
                subTotalResult = subTotal - discountResult;
                lblSubTotalResult.Text = subTotalResult.ToString("C");
                taxResult = subTotalResult * 0.05;
                lblTaxResult.Text = taxResult.ToString("C");
                lblTotalResult.Text = (subTotalResult + taxResult).ToString("C");
            }            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string customerType;
            if (rbnEducational.Checked)
                customerType = "Educational";
            else
                customerType = "Business";


            txtOutputResult.Text = "Customer name: " + txtCustomerName.Text + "; E-mail: " + txtEmail.Text + "; Purchase Type: " + customerType + "; Total: " + lblTotalResult.Text;
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            rbnEducational.Checked = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutputResult.Text = "";
        }
    }
}
