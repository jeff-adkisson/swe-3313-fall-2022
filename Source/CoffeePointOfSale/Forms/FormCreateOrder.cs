using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormCreateOrder : Base.FormNoCloseBase
    {

        public FormCreateOrder()
        {
            InitializeComponent();
        }

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.Text= comboBox1.Text;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Cl1.Text = Cl1.Text + Environment.NewLine + checkBox2.Text;
            }
            else
            {
                Cl2.Text = "";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Cl1.Text = Cl1.Text + Environment.NewLine + checkBox1.Text;
            }
            else
            {
                Cl1.Text = "";
            }
        }

        private void Customization_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Cl1.Text = Cl1.Text + Environment.NewLine + checkBox3.Text;
            }
            else
            {
                Cl3.Text = "";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Cl1.Text = Cl1.Text + Environment.NewLine + checkBox4.Text;
            }
            else
            {
                Cl4.Text = "";
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Cl1.Text = Cl1.Text + Environment.NewLine + checkBox5.Text;
            }
            else
            {
                Cl5.Text = "";
            }
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) {
                Cl1.Text = Cl1.Text + Environment.NewLine + checkBox6.Text;
            }
            else
            {
                Cl6.Text = "";
                
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cl1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormPayment>().Show();
        }
    }
}
