using CoffeePointOfSale.Configuration;
using CoffeePointOfSale.Services.FormFactory;
using System.IO;
using System.Windows.Forms;
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
using CoffeePointOfSale.Services.DrinkMenu;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormCreateOrder : Base.FormNoCloseBase
    {
        decimal subtotal = 0;
        int whipped = 1;
        int shotexpresso = 1;
        int shotvanilla = 1;
        int iced = 1;
        int milked = 1;
        int almond = 1;

       //1366, 768

        private IAppSettings _appSettings;
        private IDrinkMenuService _drinkMenuService;
        
        
        public FormCreateOrder(IAppSettings appSettings, IDrinkMenuService drinkMenuService) : base(appSettings)
        {
            InitializeComponent();
            _appSettings = appSettings;
            _drinkMenuService = drinkMenuService;
            
        }
        

        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            SetTitle("Create Order");
            ExampleOneSimpleClassObject();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            //Add this onload. 
           // groupBox1.Show();
           // if (Drink.Text.Length > 0)
           // {
           //     Cl2.Text = "1x - "+comboBox1.Text;
           // }
           /// else
           // {
           //     Drink.Text = "1x - " + comboBox1.Text;
           // }

           
            
       
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox2.Checked)
            {
                if (Cl2.Text.Length > 0)
                {
                    Cl2.Text = Cl2.Text + Environment.NewLine + "   " + shotexpresso + checkBox2.Text;
                }
                else
                {
                    Cl1.Text = Cl1.Text + Environment.NewLine + "   " + shotexpresso + checkBox2.Text;
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
                if (Cl2.Text.Length > 0)
                {
                    Cl2.Text = Cl2.Text + Environment.NewLine + "   " + whipped + checkBox1.Text;
                }
                else
                {
                    Cl1.Text = Cl1.Text + Environment.NewLine + "   " + whipped + checkBox1.Text;// "
                                                                                                 // " 1Whip Cream
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
                if (Cl2.Text.Length > 0)
                {
                    Cl2.Text = Cl2.Text + Environment.NewLine + "   " + shotvanilla + checkBox3.Text;
                }
                else
                {
                    Cl1.Text = Cl1.Text + Environment.NewLine + "   " + shotvanilla + checkBox3.Text;
                }
            }
            
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                if (Cl2.Text.Length > 0)
                {
                    Cl2.Text = Cl2.Text + Environment.NewLine + "   " + iced + checkBox4.Text;
                }
                else
                {
                    Cl1.Text = Cl1.Text + Environment.NewLine + "   " + iced + checkBox4.Text;
                }
            }
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                if (Cl2.Text.Length > 0)
                {
                    Cl2.Text = Cl2.Text + Environment.NewLine + "   " + milked + checkBox5.Text;
                }
                else
                {
                    Cl1.Text = Cl1.Text + Environment.NewLine + "   " + milked + checkBox5.Text;
                }
            }
           
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) {
                if (Cl2.Text.Length > 0)
                {
                    Cl2.Text = Cl2.Text + Environment.NewLine + "   " + almond + checkBox6.Text;
                }
                else
                {
                    Cl1.Text = Cl1.Text + Environment.NewLine + "   " + almond + checkBox6.Text;
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
            if(Cl1.Text.Contains("Whip Cream") == true)
            {
                int first = Cl1.Text.IndexOf('W')-2;
                string first1 = Cl1.Text.Remove(first, 12);
                Cl1.Text = first1+ whipped + "Whip Cream" + Environment.NewLine;
                Cl1.Text = Cl1.Text.TrimStart();
            }
            // "
            // " 2Whip Cream
            //   

            // Cl1.Text.Replace("1Whip Cream", whipped+"Whip Cream");
            //find the character location of 1x whipped cream and then replace it with 2x whipped cream. 
            // find a way to get order
            //Also, find a way to get 



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
        private void ComputeTotal()
        {
            var tax = _appSettings;
        }
        private void Update()

        {
            StreamWriter sw = null;
            try
            {
                string filePath = @"C:\Users\omowu\Source\Repos\swe\ReadFile\Textfile1.txt";
                sw=new StreamWriter(filePath);
                using (sw)
                {
                    sw.WriteLine("sw");
                }
            }
            catch (Exception)
            {
               
            }
           





            //C:\Users\omowu\Source\Repos\swe\Source\CoffeePointOfSale\ReadFile

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ExampleOneSimpleClassObject()
        {
            var drinkList = _drinkMenuService.Drinks.List;
            for(int i = 0; i < drinkList.Count; i++)
            {
                comboBox1.Items.Add(drinkList[i].Name);
            }
            
        }
    }


}
