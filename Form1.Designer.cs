namespace oop_6115261025_w09
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblWeight = new System.Windows.Forms.Label();
            this.llblHeight = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.taxCalculate = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.Label();
            this.tax = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(300, 157);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "คำนวณ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(38, 56);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(49, 17);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "น้ำหนัก";
            // 
            // llblHeight
            // 
            this.llblHeight.AutoSize = true;
            this.llblHeight.Location = new System.Drawing.Point(38, 107);
            this.llblHeight.Name = "llblHeight";
            this.llblHeight.Size = new System.Drawing.Size(44, 17);
            this.llblHeight.TabIndex = 2;
            this.llblHeight.Text = "ส่วนสูง";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(38, 163);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(76, 17);
            this.lblBMI.TabIndex = 3;
            this.lblBMI.Text = "ดัชนีมวลกาย";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(154, 53);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 4;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(154, 104);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 22);
            this.txtHeight.TabIndex = 5;
            // 
            // taxCalculate
            // 
            this.taxCalculate.Location = new System.Drawing.Point(300, 320);
            this.taxCalculate.Name = "taxCalculate";
            this.taxCalculate.Size = new System.Drawing.Size(104, 23);
            this.taxCalculate.TabIndex = 6;
            this.taxCalculate.Text = "คำนาณภาษี";
            this.taxCalculate.UseVisualStyleBackColor = true;
            this.taxCalculate.Click += new System.EventHandler(this.taxCalculate_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(41, 223);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(23, 17);
            this.name.TabIndex = 7;
            this.name.Text = "ชื่อ";
            // 
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.Location = new System.Drawing.Point(41, 275);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(55, 17);
            this.salary.TabIndex = 8;
            this.salary.Text = "เงินเดือน";
            this.salary.Click += new System.EventHandler(this.label2_Click);
            // 
            // tax
            // 
            this.tax.AutoSize = true;
            this.tax.Location = new System.Drawing.Point(41, 326);
            this.tax.Name = "tax";
            this.tax.Size = new System.Drawing.Size(31, 17);
            this.tax.TabIndex = 9;
            this.tax.Text = "ภาษี";
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(154, 220);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 22);
            this.lblName.TabIndex = 10;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(154, 275);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 22);
            this.txtSalary.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 450);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tax);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.name);
            this.Controls.Add(this.taxCalculate);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.lblBMI);
            this.Controls.Add(this.llblHeight);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label llblHeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button taxCalculate;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label tax;
        private System.Windows.Forms.TextBox lblName;
        private System.Windows.Forms.TextBox txtSalary;
    }
}

