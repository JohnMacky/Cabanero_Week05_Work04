namespace Cabanero_Week05_Work04
{
    partial class ProductForm
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
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtboxmarkup = new System.Windows.Forms.TextBox();
            this.txtboxprice = new System.Windows.Forms.TextBox();
            this.txtboxcost = new System.Windows.Forms.TextBox();
            this.lblmarkup = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.lblorigin = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lbldesciption = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.lblbarcode = new System.Windows.Forms.Label();
            this.txtboxbarcode = new System.Windows.Forms.TextBox();
            this.txtboxname = new System.Windows.Forms.TextBox();
            this.cboxcategory = new System.Windows.Forms.ComboBox();
            this.txtboxdescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnabroad = new System.Windows.Forms.RadioButton();
            this.rbtnlocal = new System.Windows.Forms.RadioButton();
            this.cboxactive = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(490, 320);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 29;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(280, 320);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 28;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(145, 320);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 27;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtboxmarkup
            // 
            this.txtboxmarkup.Location = new System.Drawing.Point(546, 162);
            this.txtboxmarkup.Name = "txtboxmarkup";
            this.txtboxmarkup.Size = new System.Drawing.Size(71, 20);
            this.txtboxmarkup.TabIndex = 26;
            // 
            // txtboxprice
            // 
            this.txtboxprice.Location = new System.Drawing.Point(455, 162);
            this.txtboxprice.Name = "txtboxprice";
            this.txtboxprice.Size = new System.Drawing.Size(71, 20);
            this.txtboxprice.TabIndex = 25;
            // 
            // txtboxcost
            // 
            this.txtboxcost.Location = new System.Drawing.Point(368, 162);
            this.txtboxcost.Name = "txtboxcost";
            this.txtboxcost.Size = new System.Drawing.Size(71, 20);
            this.txtboxcost.TabIndex = 24;
            // 
            // lblmarkup
            // 
            this.lblmarkup.AutoSize = true;
            this.lblmarkup.Location = new System.Drawing.Point(543, 133);
            this.lblmarkup.Name = "lblmarkup";
            this.lblmarkup.Size = new System.Drawing.Size(57, 13);
            this.lblmarkup.TabIndex = 23;
            this.lblmarkup.Text = "Markup(%)";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(452, 133);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(31, 13);
            this.lblprice.TabIndex = 22;
            this.lblprice.Text = "Price";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Location = new System.Drawing.Point(365, 133);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(28, 13);
            this.lblcost.TabIndex = 21;
            this.lblcost.Text = "Cost";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(365, 59);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(37, 13);
            this.lblstatus.TabIndex = 20;
            this.lblstatus.Text = "Status";
            // 
            // lblorigin
            // 
            this.lblorigin.AutoSize = true;
            this.lblorigin.Location = new System.Drawing.Point(142, 218);
            this.lblorigin.Name = "lblorigin";
            this.lblorigin.Size = new System.Drawing.Size(34, 13);
            this.lblorigin.TabIndex = 19;
            this.lblorigin.Text = "Origin";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(142, 190);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(49, 13);
            this.lblcategory.TabIndex = 18;
            this.lblcategory.Text = "Category";
            // 
            // lbldesciption
            // 
            this.lbldesciption.AutoSize = true;
            this.lbldesciption.Location = new System.Drawing.Point(142, 133);
            this.lbldesciption.Name = "lbldesciption";
            this.lbldesciption.Size = new System.Drawing.Size(60, 13);
            this.lbldesciption.TabIndex = 17;
            this.lbldesciption.Text = "Description";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(142, 98);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(35, 13);
            this.lblname.TabIndex = 16;
            this.lblname.Text = "Name";
            // 
            // lblbarcode
            // 
            this.lblbarcode.AutoSize = true;
            this.lblbarcode.Location = new System.Drawing.Point(142, 69);
            this.lblbarcode.Name = "lblbarcode";
            this.lblbarcode.Size = new System.Drawing.Size(47, 13);
            this.lblbarcode.TabIndex = 15;
            this.lblbarcode.Text = "Barcode";
            // 
            // txtboxbarcode
            // 
            this.txtboxbarcode.Location = new System.Drawing.Point(208, 69);
            this.txtboxbarcode.Name = "txtboxbarcode";
            this.txtboxbarcode.Size = new System.Drawing.Size(121, 20);
            this.txtboxbarcode.TabIndex = 30;
            // 
            // txtboxname
            // 
            this.txtboxname.Location = new System.Drawing.Point(208, 95);
            this.txtboxname.Name = "txtboxname";
            this.txtboxname.Size = new System.Drawing.Size(121, 20);
            this.txtboxname.TabIndex = 31;
            // 
            // cboxcategory
            // 
            this.cboxcategory.FormattingEnabled = true;
            this.cboxcategory.Location = new System.Drawing.Point(208, 187);
            this.cboxcategory.Name = "cboxcategory";
            this.cboxcategory.Size = new System.Drawing.Size(121, 21);
            this.cboxcategory.TabIndex = 32;
            // 
            // txtboxdescription
            // 
            this.txtboxdescription.Location = new System.Drawing.Point(208, 130);
            this.txtboxdescription.Multiline = true;
            this.txtboxdescription.Name = "txtboxdescription";
            this.txtboxdescription.Size = new System.Drawing.Size(121, 51);
            this.txtboxdescription.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnabroad);
            this.groupBox1.Controls.Add(this.rbtnlocal);
            this.groupBox1.Location = new System.Drawing.Point(208, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 57);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manufactured";
            // 
            // rbtnabroad
            // 
            this.rbtnabroad.AutoSize = true;
            this.rbtnabroad.Location = new System.Drawing.Point(94, 16);
            this.rbtnabroad.Name = "rbtnabroad";
            this.rbtnabroad.Size = new System.Drawing.Size(59, 17);
            this.rbtnabroad.TabIndex = 1;
            this.rbtnabroad.TabStop = true;
            this.rbtnabroad.Text = "Abroad";
            this.rbtnabroad.UseVisualStyleBackColor = true;
            // 
            // rbtnlocal
            // 
            this.rbtnlocal.AutoSize = true;
            this.rbtnlocal.Location = new System.Drawing.Point(3, 16);
            this.rbtnlocal.Name = "rbtnlocal";
            this.rbtnlocal.Size = new System.Drawing.Size(51, 17);
            this.rbtnlocal.TabIndex = 0;
            this.rbtnlocal.TabStop = true;
            this.rbtnlocal.Text = "Local";
            this.rbtnlocal.UseVisualStyleBackColor = true;
            // 
            // cboxactive
            // 
            this.cboxactive.AutoSize = true;
            this.cboxactive.Location = new System.Drawing.Point(417, 59);
            this.cboxactive.Name = "cboxactive";
            this.cboxactive.Size = new System.Drawing.Size(56, 17);
            this.cboxactive.TabIndex = 35;
            this.cboxactive.Text = "Active";
            this.cboxactive.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxactive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtboxdescription);
            this.Controls.Add(this.cboxcategory);
            this.Controls.Add(this.txtboxname);
            this.Controls.Add(this.txtboxbarcode);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtboxmarkup);
            this.Controls.Add(this.txtboxprice);
            this.Controls.Add(this.txtboxcost);
            this.Controls.Add(this.lblmarkup);
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblorigin);
            this.Controls.Add(this.lblcategory);
            this.Controls.Add(this.lbldesciption);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.lblbarcode);
            this.Name = "ProductForm";
            this.Text = "Product Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtboxmarkup;
        private System.Windows.Forms.TextBox txtboxprice;
        private System.Windows.Forms.TextBox txtboxcost;
        private System.Windows.Forms.Label lblmarkup;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label lblorigin;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lbldesciption;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblbarcode;
        private System.Windows.Forms.TextBox txtboxbarcode;
        private System.Windows.Forms.TextBox txtboxname;
        private System.Windows.Forms.ComboBox cboxcategory;
        private System.Windows.Forms.TextBox txtboxdescription;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnabroad;
        private System.Windows.Forms.RadioButton rbtnlocal;
        private System.Windows.Forms.CheckBox cboxactive;
    }
}