
﻿using CoffeePointOfSale.Services.Customer;
using CoffeePointOfSale.Services.DrinkInOrder__Customizations;

﻿using CoffeePointOfSale.Forms.Base;

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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using CoffeePointOfSale.Services.SalesHistory;
using System.Text.Json;
using CoffeePointOfSale.Services.Storage;

namespace CoffeePointOfSale.Forms
{
    public partial class FormPayment : Form
    {
        //The Customer making the order
        Customer customer;

        //variables to send to json file for sales data
        string dateTime;
        decimal tax;
        decimal subtotal;
        decimal total;
        int pointsEarned;
        string payment;
        string paymentDetails;

        string data; //= data from FormCreateOrder
        //string that will be sent to Customers.json
        string[] salesData;
        bool anonymous = true;
        
      



        public FormPayment()
        {
            InitializeComponent();
        }


        private void btnPayWithCredit_Click(object sender, EventArgs e)
        {
            Hide();
            FormFactory.Get<FormReceipt>().Show();
            //validate credit card
            if (!anonymous)
            {
                updatePoints();
                updateSalesData();
            }
        }
        private void btnPayWithRP_Click(object sender, EventArgs e)
        {
            if (anonymous)
            {
                Hide();
                //FormFactory.Get<FormError>().Show();
            }
            //if rewards points aren't enough, show error screen
            else 
            {
                updateSalesData();
                //subtract rewards points from total

            }
        }

        private void orderDataSort(string data)
        {
            ///sets data to the string sent from FormCreateOrder
            ///CreateOrder.ToString = data;         
            salesData = data.Split(',');

            //Indexes may need to be changed depending on what order the data is present in the string
            dateTime = salesData[1];
            tax = Convert.ToDecimal(salesData[2]);
            subtotal = Convert.ToDecimal(salesData[3]);
            total = Convert.ToDecimal(salesData[4]);
            payment = salesData[6];
            paymentDetails= salesData[7];
            //...etc, including drinksInOrder

            //string json = JsonConvert.SerializeObject(salesData);
        }

        private void updatePoints()
        {
            if(!anonymous) 
            {
                //code written assuming string sent by CreateOrder is in the same order as example Excel sheet from UML design 
                string[] subStrings = data.Split(',');
                decimal subTotal = Convert.ToDecimal(subStrings[5]);

                //math for adding rewards points (1pt per $1 rounding down)
                Math.Floor(subTotal);
                int newPoints = Convert.ToInt32(subTotal);
                pointsEarned = newPoints; 
                int currentPoints = customer.getRewardsPoints();
                currentPoints += newPoints;

            }
        }

        private void updateSalesData()
        {
            var order = new SalesHistory
            {
                DateTime = dateTime,
                Tax = tax,
                Subtotal = subtotal,
                Total = total,
                PointsEarned = pointsEarned,
                Payment = payment,
                PaymentDetails = paymentDetails
            };
            
            var serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            StorageService salesStorage = new StorageService
            {
                //salesStorage.Write("SalesHistory", order);
                //I hate my life
            };
            //salesStorage.GetFilename("Customers.cs");
            //salesStorage.Write<>("Order", order);

            //var json = JsonConvert.SerializeObject(order, serializerOptions);   ///Why does it need to be null? This is literally copied from his slides and linqpad demos what am I doing wrong??
            //json.Dump("Customers.cs");
        }
        
       
    }
}


//FormOrder will send an encapsulated string/ToString object with Drink order info (need to have FormCreateOrder first to work on this part)
//Payment will have to understand what financial info is in that to know how many rewards points to add/subtract
//Payment to Reciept: Update rewards points in Customers.JSON,
//Customers.JSON needs to be updated to account for sales/order history
//Info is sent to this one file
//=======
//        private void FormPayment_Load(object sender, EventArgs e)
//        {

//        }

//        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        private void textBox2_TextChanged(object sender, EventArgs e)
//        {

//        }

//        private void Return_Click(object sender, EventArgs e)
//        {
//            Hide();
//            FormFactory.Get<FormMain>().Show();
//        }
//    }
//}
//>>>>>>> main
