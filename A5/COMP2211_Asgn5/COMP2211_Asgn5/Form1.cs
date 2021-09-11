using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2211_Asgn5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // GetCustomerData method accepts a Customer object as an arg.
        // Then data is assigned which is entered by the user to the obj params.
        private void GetCustomerData (Customer customer)
        {
            // Get Customer Name
            customer.Fullname = fullnameTextBox.Text;

            // Get Customer Adr Ln 1
            customer.AddressLn1 = adrLn1TextBox.Text;

            // Get Customer Adr Ln 2
            customer.AddressLn2 = adrLn2TextBox.Text;

            // Get Customer City
            customer.City = cityTextBox.Text;

            // Get Cusstomer Country
            customer.Country = countryTextBox.Text;

            // Get Customer Postal Code
            customer.PostalCode = postalCodeTextBox.Text;

            // Get Customer Telephone
            customer.Telephone = telephoneTextBox.Text;

            // Get Customer Mailing List Information
            customer.MailingList = checkBoxMailingList.Checked;
            
        }

        // GetPreferredCustomerData method will retrieve the PreferedCustomer data
        private void GetPreferredCustomerData (PreferredCustomer prefcustomer)
        {
            // Temp variables
            double sumPurchases;

            // Get Total Purchase
            if (double.TryParse(purchasesTextBox.Text, out sumPurchases))
            {
                prefcustomer.SumPurchases = sumPurchases;
                
            } else
            {
                // Display Error Message
                MessageBox.Show("Invalid Total Purchases amount, please enter numbers.");
            }
        }


        private void createObjectButton_Click(object sender, EventArgs e)
        {
            // Create Customer Object
            Customer newCustomer = new Customer();

            // Create PreferredCustomer Object
            PreferredCustomer newPreferredCustomer = new PreferredCustomer();

            // Get Customer data
            GetCustomerData(newCustomer);
            GetPreferredCustomerData(newPreferredCustomer);

            // Display Customer data
            nameLabelOutput.Text = newCustomer.Fullname;
            adrLn1OutputLabel.Text = newCustomer.AddressLn1;
            adrLn2OutputLabel.Text = newCustomer.AddressLn2;
            cityOutputLabel.Text = newCustomer.City;
            countryOutputLabel.Text = newCustomer.Country;
            postalCodeOutputLabel.Text = newCustomer.PostalCode;
            telephoneOutputLabel.Text = newCustomer.Telephone;
            mailingListOutputLabel.Text = newCustomer.MailingList.ToString();

            // Display PreferredCustomer data
            purchasesOutputLabel.Text = newPreferredCustomer.SumPurchases.ToString("c");
            discountOutputLabel.Text = newPreferredCustomer.Discount.ToString("p");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close Form
            this.Close();
        }
    }
}
