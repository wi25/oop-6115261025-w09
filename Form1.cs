using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_6115261025_w09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double height = double.Parse(txtHeight.Text.ToString()) / 100;
            double weight = double.Parse(txtWeight.Text.ToString());
            double bmi = BMI.calculate(weight, height);
            lblBMI.Text = bmi.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void taxCalculate_Click(object sender, EventArgs e)
        {
            double salary = double.Parse(txtSalary.Text.ToString());
            double tax = Tax.getTax(salary * 12);
            this.tax.Text = tax.ToString();
        }
    }
}
