namespace Pizzanova
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrder));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbtnLarge = new System.Windows.Forms.RadioButton();
            this.rdbtnMedium = new System.Windows.Forms.RadioButton();
            this.rdbtnSmall = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbtnThick = new System.Windows.Forms.RadioButton();
            this.rdbtnThin = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbtnOut = new System.Windows.Forms.RadioButton();
            this.rdbtnIn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnOrderBill = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbtnLarge);
            this.groupBox1.Controls.Add(this.rdbtnMedium);
            this.groupBox1.Controls.Add(this.rdbtnSmall);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Marker", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // rdbtnLarge
            // 
            this.rdbtnLarge.AutoSize = true;
            this.rdbtnLarge.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnLarge.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnLarge.Location = new System.Drawing.Point(15, 102);
            this.rdbtnLarge.Name = "rdbtnLarge";
            this.rdbtnLarge.Size = new System.Drawing.Size(74, 28);
            this.rdbtnLarge.TabIndex = 2;
            this.rdbtnLarge.TabStop = true;
            this.rdbtnLarge.Tag = "15";
            this.rdbtnLarge.Text = "Large";
            this.rdbtnLarge.UseVisualStyleBackColor = false;
            // 
            // rdbtnMedium
            // 
            this.rdbtnMedium.AutoSize = true;
            this.rdbtnMedium.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnMedium.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnMedium.Location = new System.Drawing.Point(15, 68);
            this.rdbtnMedium.Name = "rdbtnMedium";
            this.rdbtnMedium.Size = new System.Drawing.Size(93, 28);
            this.rdbtnMedium.TabIndex = 1;
            this.rdbtnMedium.TabStop = true;
            this.rdbtnMedium.Tag = "10";
            this.rdbtnMedium.Text = "Medium";
            this.rdbtnMedium.UseVisualStyleBackColor = false;
            // 
            // rdbtnSmall
            // 
            this.rdbtnSmall.AutoSize = true;
            this.rdbtnSmall.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnSmall.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSmall.Location = new System.Drawing.Point(15, 34);
            this.rdbtnSmall.Name = "rdbtnSmall";
            this.rdbtnSmall.Size = new System.Drawing.Size(75, 28);
            this.rdbtnSmall.TabIndex = 0;
            this.rdbtnSmall.TabStop = true;
            this.rdbtnSmall.Tag = "5";
            this.rdbtnSmall.Text = "Small";
            this.rdbtnSmall.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rdbtnThick);
            this.groupBox2.Controls.Add(this.rdbtnThin);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(57, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 104);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Crust Type";
            // 
            // rdbtnThick
            // 
            this.rdbtnThick.AutoSize = true;
            this.rdbtnThick.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnThick.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnThick.Location = new System.Drawing.Point(15, 68);
            this.rdbtnThick.Name = "rdbtnThick";
            this.rdbtnThick.Size = new System.Drawing.Size(114, 28);
            this.rdbtnThick.TabIndex = 1;
            this.rdbtnThick.TabStop = true;
            this.rdbtnThick.Tag = "10";
            this.rdbtnThick.Text = "Thick Crust";
            this.rdbtnThick.UseVisualStyleBackColor = false;
            // 
            // rdbtnThin
            // 
            this.rdbtnThin.AutoSize = true;
            this.rdbtnThin.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnThin.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnThin.Location = new System.Drawing.Point(15, 34);
            this.rdbtnThin.Name = "rdbtnThin";
            this.rdbtnThin.Size = new System.Drawing.Size(108, 28);
            this.rdbtnThin.TabIndex = 0;
            this.rdbtnThin.TabStop = true;
            this.rdbtnThin.Tag = "5";
            this.rdbtnThin.Text = "Thin Crust";
            this.rdbtnThin.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 25);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Tag = "5";
            this.checkBox1.Text = "Extra Chees";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(11, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 25);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Tag = "2";
            this.checkBox2.Text = "Mushrooms";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(11, 85);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(90, 25);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Tag = "2";
            this.checkBox3.Text = "Tomatos";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.Color.Transparent;
            this.checkBox4.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(130, 85);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(127, 25);
            this.checkBox4.TabIndex = 9;
            this.checkBox4.Tag = "4";
            this.checkBox4.Text = "Green Peepers";
            this.checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.Color.Transparent;
            this.checkBox5.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.Location = new System.Drawing.Point(130, 55);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(75, 25);
            this.checkBox5.TabIndex = 10;
            this.checkBox5.Tag = "5";
            this.checkBox5.Text = "Olives";
            this.checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.Color.Transparent;
            this.checkBox6.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(130, 25);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 25);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Tag = "8";
            this.checkBox6.Text = "Onion";
            this.checkBox6.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox4);
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Marker", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(220, 129);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 130);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.rdbtnOut);
            this.groupBox4.Controls.Add(this.rdbtnIn);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(220, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 75);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Where To Eat?";
            // 
            // rdbtnOut
            // 
            this.rdbtnOut.AutoSize = true;
            this.rdbtnOut.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnOut.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnOut.Location = new System.Drawing.Point(146, 34);
            this.rdbtnOut.Name = "rdbtnOut";
            this.rdbtnOut.Size = new System.Drawing.Size(99, 28);
            this.rdbtnOut.TabIndex = 1;
            this.rdbtnOut.TabStop = true;
            this.rdbtnOut.Text = "Take Out";
            this.rdbtnOut.UseVisualStyleBackColor = false;
            // 
            // rdbtnIn
            // 
            this.rdbtnIn.AutoSize = true;
            this.rdbtnIn.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnIn.Font = new System.Drawing.Font("Segoe Marker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnIn.Location = new System.Drawing.Point(15, 34);
            this.rdbtnIn.Name = "rdbtnIn";
            this.rdbtnIn.Size = new System.Drawing.Size(77, 28);
            this.rdbtnIn.TabIndex = 0;
            this.rdbtnIn.TabStop = true;
            this.rdbtnIn.Tag = "";
            this.rdbtnIn.Text = "Eat In";
            this.rdbtnIn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 38);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Price:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalPrice.Location = new System.Drawing.Point(250, 460);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(46, 54);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "$";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Firebrick;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(887, 434);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(155, 49);
            this.btnOrder.TabIndex = 16;
            this.btnOrder.Text = "Order NOW";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnOrderBill
            // 
            this.btnOrderBill.Enabled = false;
            this.btnOrderBill.FlatAppearance.BorderSize = 0;
            this.btnOrderBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderBill.Location = new System.Drawing.Point(887, 489);
            this.btnOrderBill.Name = "btnOrderBill";
            this.btnOrderBill.Size = new System.Drawing.Size(155, 39);
            this.btnOrderBill.TabIndex = 17;
            this.btnOrderBill.Text = "Order Bill";
            this.btnOrderBill.UseVisualStyleBackColor = true;
            this.btnOrderBill.Click += new System.EventHandler(this.btnOrderBill_Click);
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 540);
            this.Controls.Add(this.btnOrderBill);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrder";
            this.Text = "Pizzanova";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbtnLarge;
        private System.Windows.Forms.RadioButton rdbtnMedium;
        private System.Windows.Forms.RadioButton rdbtnSmall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbtnThick;
        private System.Windows.Forms.RadioButton rdbtnThin;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbtnOut;
        private System.Windows.Forms.RadioButton rdbtnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnOrderBill;
    }
}