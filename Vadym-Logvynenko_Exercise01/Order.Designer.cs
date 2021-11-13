namespace Vadym_Logvynenko_Exercise01
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrderForm = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.cmbCustomerType = new System.Windows.Forms.ComboBox();
            this.lblPurchaseType = new System.Windows.Forms.Label();
            this.rbnEducational = new System.Windows.Forms.RadioButton();
            this.rbnBusiness = new System.Windows.Forms.RadioButton();
            this.lblListOfProducts = new System.Windows.Forms.Label();
            this.chbMouse = new System.Windows.Forms.CheckBox();
            this.chbKeyboard = new System.Windows.Forms.CheckBox();
            this.chbPrinter = new System.Windows.Forms.CheckBox();
            this.lblMousePrice = new System.Windows.Forms.Label();
            this.lblKeyboardPrice = new System.Windows.Forms.Label();
            this.lblPrinterPrice = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblSubTotalResult = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblDiscountResult = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTaxResult = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutputResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOrderForm
            // 
            this.lblOrderForm.AutoSize = true;
            this.lblOrderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderForm.Location = new System.Drawing.Point(266, 9);
            this.lblOrderForm.Name = "lblOrderForm";
            this.lblOrderForm.Size = new System.Drawing.Size(219, 25);
            this.lblOrderForm.TabIndex = 0;
            this.lblOrderForm.Text = "Product Order Form";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(12, 67);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(12, 116);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 166);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(10, 221);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(108, 64);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(108, 110);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 166);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(108, 218);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerType.Location = new System.Drawing.Point(10, 270);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(234, 14);
            this.lblCustomerType.TabIndex = 9;
            this.lblCustomerType.Text = "Customer Type: (Student, Adult, Teacher)";
            // 
            // cmbCustomerType
            // 
            this.cmbCustomerType.FormattingEnabled = true;
            this.cmbCustomerType.Items.AddRange(new object[] {
            "Student",
            "Adult",
            "Teacher"});
            this.cmbCustomerType.Location = new System.Drawing.Point(12, 301);
            this.cmbCustomerType.Name = "cmbCustomerType";
            this.cmbCustomerType.Size = new System.Drawing.Size(231, 21);
            this.cmbCustomerType.TabIndex = 10;
            this.cmbCustomerType.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerType_SelectedIndexChanged);
            // 
            // lblPurchaseType
            // 
            this.lblPurchaseType.AutoSize = true;
            this.lblPurchaseType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseType.Location = new System.Drawing.Point(332, 64);
            this.lblPurchaseType.Name = "lblPurchaseType";
            this.lblPurchaseType.Size = new System.Drawing.Size(91, 14);
            this.lblPurchaseType.TabIndex = 11;
            this.lblPurchaseType.Text = "Purchase Type:";
            // 
            // rbnEducational
            // 
            this.rbnEducational.AutoSize = true;
            this.rbnEducational.Location = new System.Drawing.Point(271, 114);
            this.rbnEducational.Name = "rbnEducational";
            this.rbnEducational.Size = new System.Drawing.Size(81, 17);
            this.rbnEducational.TabIndex = 12;
            this.rbnEducational.TabStop = true;
            this.rbnEducational.Text = "Educational";
            this.rbnEducational.UseVisualStyleBackColor = true;
            // 
            // rbnBusiness
            // 
            this.rbnBusiness.AutoSize = true;
            this.rbnBusiness.Location = new System.Drawing.Point(407, 112);
            this.rbnBusiness.Name = "rbnBusiness";
            this.rbnBusiness.Size = new System.Drawing.Size(67, 17);
            this.rbnBusiness.TabIndex = 13;
            this.rbnBusiness.TabStop = true;
            this.rbnBusiness.Text = "Business";
            this.rbnBusiness.UseVisualStyleBackColor = true;
            // 
            // lblListOfProducts
            // 
            this.lblListOfProducts.AutoSize = true;
            this.lblListOfProducts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListOfProducts.Location = new System.Drawing.Point(599, 59);
            this.lblListOfProducts.Name = "lblListOfProducts";
            this.lblListOfProducts.Size = new System.Drawing.Size(136, 19);
            this.lblListOfProducts.TabIndex = 14;
            this.lblListOfProducts.Text = "List of Products:";
            // 
            // chbMouse
            // 
            this.chbMouse.AutoSize = true;
            this.chbMouse.Location = new System.Drawing.Point(584, 93);
            this.chbMouse.Name = "chbMouse";
            this.chbMouse.Size = new System.Drawing.Size(58, 17);
            this.chbMouse.TabIndex = 15;
            this.chbMouse.Text = "Mouse";
            this.chbMouse.UseVisualStyleBackColor = true;
            this.chbMouse.CheckedChanged += new System.EventHandler(this.chbMouse_CheckedChanged);
            // 
            // chbKeyboard
            // 
            this.chbKeyboard.AutoSize = true;
            this.chbKeyboard.Location = new System.Drawing.Point(584, 143);
            this.chbKeyboard.Name = "chbKeyboard";
            this.chbKeyboard.Size = new System.Drawing.Size(71, 17);
            this.chbKeyboard.TabIndex = 16;
            this.chbKeyboard.Text = "Keyboard";
            this.chbKeyboard.UseVisualStyleBackColor = true;
            this.chbKeyboard.CheckedChanged += new System.EventHandler(this.chbKeyboard_CheckedChanged);
            // 
            // chbPrinter
            // 
            this.chbPrinter.AutoSize = true;
            this.chbPrinter.Location = new System.Drawing.Point(584, 198);
            this.chbPrinter.Name = "chbPrinter";
            this.chbPrinter.Size = new System.Drawing.Size(56, 17);
            this.chbPrinter.TabIndex = 17;
            this.chbPrinter.Text = "Printer";
            this.chbPrinter.UseVisualStyleBackColor = true;
            this.chbPrinter.CheckedChanged += new System.EventHandler(this.chbPrinter_CheckedChanged);
            // 
            // lblMousePrice
            // 
            this.lblMousePrice.AutoSize = true;
            this.lblMousePrice.Location = new System.Drawing.Point(690, 94);
            this.lblMousePrice.Name = "lblMousePrice";
            this.lblMousePrice.Size = new System.Drawing.Size(40, 13);
            this.lblMousePrice.TabIndex = 18;
            this.lblMousePrice.Text = "$30.00";
            // 
            // lblKeyboardPrice
            // 
            this.lblKeyboardPrice.AutoSize = true;
            this.lblKeyboardPrice.Location = new System.Drawing.Point(690, 144);
            this.lblKeyboardPrice.Name = "lblKeyboardPrice";
            this.lblKeyboardPrice.Size = new System.Drawing.Size(40, 13);
            this.lblKeyboardPrice.TabIndex = 19;
            this.lblKeyboardPrice.Text = "$50.00";
            // 
            // lblPrinterPrice
            // 
            this.lblPrinterPrice.AutoSize = true;
            this.lblPrinterPrice.Location = new System.Drawing.Point(690, 199);
            this.lblPrinterPrice.Name = "lblPrinterPrice";
            this.lblPrinterPrice.Size = new System.Drawing.Size(40, 13);
            this.lblPrinterPrice.TabIndex = 20;
            this.lblPrinterPrice.Text = "$80.00";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(506, 252);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(56, 13);
            this.lblSubTotal.TabIndex = 21;
            this.lblSubTotal.Text = "Sub Total:";
            // 
            // lblSubTotalResult
            // 
            this.lblSubTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotalResult.Location = new System.Drawing.Point(584, 242);
            this.lblSubTotalResult.Name = "lblSubTotalResult";
            this.lblSubTotalResult.Size = new System.Drawing.Size(157, 23);
            this.lblSubTotalResult.TabIndex = 22;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(349, 309);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(52, 13);
            this.lblDiscount.TabIndex = 23;
            this.lblDiscount.Text = "Discount:";
            // 
            // lblDiscountResult
            // 
            this.lblDiscountResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDiscountResult.Location = new System.Drawing.Point(407, 299);
            this.lblDiscountResult.Name = "lblDiscountResult";
            this.lblDiscountResult.Size = new System.Drawing.Size(100, 23);
            this.lblDiscountResult.TabIndex = 24;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(581, 309);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(51, 13);
            this.lblTax.TabIndex = 25;
            this.lblTax.Text = "Tax (5%):";
            // 
            // lblTaxResult
            // 
            this.lblTaxResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxResult.Location = new System.Drawing.Point(641, 299);
            this.lblTaxResult.Name = "lblTaxResult";
            this.lblTaxResult.Size = new System.Drawing.Size(100, 23);
            this.lblTaxResult.TabIndex = 26;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(422, 372);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total:";
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalResult.Location = new System.Drawing.Point(462, 362);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(279, 23);
            this.lblTotalResult.TabIndex = 28;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(15, 343);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 29;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(168, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(10, 388);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(49, 13);
            this.lblOutput.TabIndex = 31;
            this.lblOutput.Text = "Output:";
            // 
            // txtOutputResult
            // 
            this.txtOutputResult.Location = new System.Drawing.Point(12, 413);
            this.txtOutputResult.Multiline = true;
            this.txtOutputResult.Name = "txtOutputResult";
            this.txtOutputResult.Size = new System.Drawing.Size(729, 99);
            this.txtOutputResult.TabIndex = 32;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 541);
            this.Controls.Add(this.txtOutputResult);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblTotalResult);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTaxResult);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblDiscountResult);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblSubTotalResult);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblPrinterPrice);
            this.Controls.Add(this.lblKeyboardPrice);
            this.Controls.Add(this.lblMousePrice);
            this.Controls.Add(this.chbPrinter);
            this.Controls.Add(this.chbKeyboard);
            this.Controls.Add(this.chbMouse);
            this.Controls.Add(this.lblListOfProducts);
            this.Controls.Add(this.rbnBusiness);
            this.Controls.Add(this.rbnEducational);
            this.Controls.Add(this.lblPurchaseType);
            this.Controls.Add(this.cmbCustomerType);
            this.Controls.Add(this.lblCustomerType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblOrderForm);
            this.Name = "frmOrder";
            this.Text = "Product Order System";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderForm;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.ComboBox cmbCustomerType;
        private System.Windows.Forms.Label lblPurchaseType;
        private System.Windows.Forms.RadioButton rbnEducational;
        private System.Windows.Forms.RadioButton rbnBusiness;
        private System.Windows.Forms.Label lblListOfProducts;
        private System.Windows.Forms.CheckBox chbMouse;
        private System.Windows.Forms.CheckBox chbKeyboard;
        private System.Windows.Forms.CheckBox chbPrinter;
        private System.Windows.Forms.Label lblMousePrice;
        private System.Windows.Forms.Label lblKeyboardPrice;
        private System.Windows.Forms.Label lblPrinterPrice;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblSubTotalResult;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblDiscountResult;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxResult;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutputResult;
    }
}

