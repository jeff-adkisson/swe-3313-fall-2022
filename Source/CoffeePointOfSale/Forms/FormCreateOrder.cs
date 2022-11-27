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
using System.Collections;
using CheckBox = System.Windows.Forms.CheckBox;

namespace CoffeePointOfSale.Forms.Base
{
    public partial class FormCreateOrder : Base.FormNoCloseBase

    {
        decimal subtotal = 0;
        decimal fsubtotal = 0; 
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
            Drink.Text = comboBox1.Text;
           
            comboBox2.Items.Clear();

            ArrayList alist = new ArrayList();

            var drinkList = _drinkMenuService.DrinkMenu.Drinks;
         
            for (int i = 0; i < drinkList.Count; i++)
            {
                if (drinkList[i].Name == comboBox1.Text)
                {
                    for(int j = 0; j < drinkList[i].Customizations.Count; j++)
                    {
                        comboBox2.Items.Add(drinkList[i].Customizations[j].Name);

                    }
                }
            }

            

            
            


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



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void Customization_Click(object sender, EventArgs e)
        {
            
        }

       

        


       

        private void button2_Click(object sender, EventArgs e)
        {
            Cl6.Text = Drink.Text + Environment.NewLine + Cl1.Text;
            Cl1.Text = "";
            if(Cl6.Text.Length > 0 )
            {
               tax.Text =  "Tax: " +  _appSettings.Tax.Rate.ToString();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Cl6.Text.Length != 0)
            {
                Hide();
                FormFactory.Get<FormPayment>().Show();
            }
           
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

        
        private void ComputeTotal()
        {
            var tax = _appSettings;
        }
       

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ExampleOneSimpleClassObject()
        {
            var drinkList = _drinkMenuService.DrinkMenu.Drinks;
            for(int i = 0; i < drinkList.Count; i++)
            {
                comboBox1.Items.Add(drinkList[i].Name);
            }
            
            
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Drink_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {


            var drinkList = _drinkMenuService.DrinkMenu.Drinks;

            for (int i = 0; i < drinkList.Count; i++)
            {
                if (drinkList[i].Name == comboBox1.Text)
                {
                    
                    for (int j = 0; j < drinkList[i].Customizations.Count; j++)
                    {
                        if (comboBox2.Text == drinkList[i].Customizations[j].Name)
                        {
                            int quantity = int.Parse(comboBox3.Text);
                            Cl1.Text = Cl1.Text + Environment.NewLine + comboBox3.Text + "x" + comboBox2.Text + (drinkList[i].Customizations[j].Price*quantity);
                            subtotal =  (drinkList[i].Customizations[j].Price * quantity);
                        }

                    }
                    subtotal = subtotal + drinkList[i].BasePrice;
                }
            }
            
           
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cl1.Text = "";
            Drink.Text = "";
        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void tax_Click(object sender, EventArgs e)
        {

        }
    }


}
