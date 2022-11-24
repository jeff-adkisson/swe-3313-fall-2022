using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormCreateOrder : Base.FormNoCloseBase
    {
        decimal subtotal = 0;
        int whipped = 0;
        int shotexpresso = 0;
        int shotvanilla = 0;
        int iced = 0;
        int milked = 0;
        int almond = 0;

       

        private IAppSettings _appSettings;
        
        
        public FormCreateOrder(IAppSettings appSettings)
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
            groupBox1.Show();
           // Cl1.Text= "1x  - "+comboBox1.Text;
            
       
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked)
            {
                Cl1.Text = Cl1.Text  + Environment.NewLine+ "   "+ shotexpresso+ checkBox2.Text;
            }
            else
            {
                if (Cl1.Text.Contains(checkBox2.Text))
                {
                    Cl1.Text = Cl1.Text.Replace(checkBox2.Text,"");
                }
               
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
                Cl1.Text = Cl1.Text + Environment.NewLine+ "   " +whipped +checkBox1.Text;
            }
            else
            {
                if (Cl1.Text.Contains(checkBox1.Text))
                {

                    Cl1.Text = Cl1.Text.Replace(checkBox1.Text, "");
                }
            }
        }

        private void Customization_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                Cl1.Text = Cl1.Text  + Environment.NewLine + "   "+shotvanilla+checkBox3.Text;
            }
            else
            {
                if (Cl1.Text.Contains(checkBox3.Text))
                {
                    Cl1.Text = Cl1.Text.Replace(checkBox3.Text, "");
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                Cl1.Text = Cl1.Text +  Environment.NewLine + "   " + iced +checkBox4.Text;
            }
            else
            {
                if (Cl1.Text.Contains(checkBox4.Text))
                {
                    Cl1.Text = Cl1.Text.Replace(checkBox4.Text, "");
                }
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Cl1.Text = Cl1.Text  + Environment.NewLine + "   " +milked+ checkBox5.Text;
            }
            else
            {
                if (Cl1.Text.Contains(checkBox5.Text))
                {
                    Cl1.Text = Cl1.Text.Replace(checkBox5.Text, "");
                }
            }
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) {
                Cl1.Text = Cl1.Text +  Environment.NewLine + "   " + almond+ checkBox6.Text;
            }
            else
            {
                if (Cl1.Text.Contains(checkBox6.Text))
                {
                    Cl1.Text = Cl1.Text.Replace(checkBox6.Text, "");
                }

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

        private void Whippedp_Click(object sender, EventArgs e)
        {
            whipped++;

        }

        private void Whippedm_Click(object sender, EventArgs e)
        {
            whipped--;
        }

        private void Shotp_Click(object sender, EventArgs e)
        {
            shotexpresso++;
        }
        private void Shotm_Click(object sender, EventArgs e)
        {
            shotexpresso--;
        }

        private void SVp_Click(object sender, EventArgs e)
        {
            shotvanilla++;
        }
        private void SVm_Click(Object sender, EventArgs e)
        {
            shotvanilla--;
        }

        private void Icep_Click(object sender, EventArgs e)
        {
            iced++;
        }

        private void Icem_Click(object sender, EventArgs e)
        {
            iced--;
        }

        private void Milkp_Click(object sender, EventArgs e)
        {
            milked++;
        }

        private void Milkm_Click(object sender, EventArgs e)
        {
            milked--;
        }

        private void Almondp_Click(object sender, EventArgs e)
        {
            almond++;
        }

        private void Almondm_Click(object sender, EventArgs e)
        {
            almond--;
        }
    }


}
