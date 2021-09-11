using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP2211_Asgn5
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

	public class Person
	{
		// Fields
		private string _fullname;
		private string _addressln1;
		private string _addressln2;
		private string _city;
		private string _country;
		private string _postalcode;
		private string _telephone;

		// Constructor
		public Person()
		{
			_fullname = "";
			_addressln1 = "";
			_addressln2 = "";
			_city = "";
			_country = "";
			_postalcode = "";
			_telephone = "";
		}

		// Make Fullname
		public string Fullname
		{
			get { return _fullname; }
			set { _fullname = value; }
		}

		// Make AddressLn1
		public string AddressLn1
		{
			get { return _addressln1; }
			set { _addressln1 = value; }
		}

		// Make AddressLn2
		public string AddressLn2
		{
			get { return _addressln2; }
			set { _addressln2 = value; }
		}

		// Make City
		public string City
		{
			get { return _city; }
			set { _city = value; }
		}

		// Make Country
		public string Country
		{
			get { return _country; }
			set { _country = value; }
		}

		// Make PostalCode
		public string PostalCode
		{
			get { return _postalcode; }
			set { _postalcode = value; }
		}

		// Make Telephone
		public string Telephone
		{
			get { return _telephone; }
			set { _telephone = value; }
		}
	}

	class Customer : Person
    {
		// Field
		private bool _mailingList;

		// Constructor
		public Customer()
		{
			_mailingList = false;
		}

		// Mailing List Property
		public bool MailingList 
        {
			get { return _mailingList; }
			set { _mailingList = value; }
        }
	}

	class PreferredCustomer : Customer
    {
		// Constants
		private double DISCOUNT_5 = 0.05;
		private double DISCOUNT_6 = 0.06;
		private double DISCOUNT_7 = 0.07;
		private double DISCOUNT_10 = 0.1;

		// Fields
		private double _sumPurchases;
		private double _discount;

		// Constructor
		public PreferredCustomer()
        {
			_sumPurchases = 0;
			_discount = 0;
		}

		// Make SumPurchaes
		public double SumPurchases
        {
			get { return _sumPurchases;  }
			set { _sumPurchases = value; }
        }

		// Make Discount
		public double Discount
        {	
			get
			{	// When $500 spent, discount is 5%
				if (_sumPurchases >= 500 && _sumPurchases < 1000)
				{
					_discount = DISCOUNT_5;


				}
				// When $1000 spent, discount is 6%
				else if (_sumPurchases >= 1000 && _sumPurchases < 1500)
				{
					_discount = DISCOUNT_6;

				}
				// When $1500 spent, discount is 7%
				else if (_sumPurchases >= 1500 && _sumPurchases < 2000)
				{
					_discount = DISCOUNT_7;

				}
				// When $2000 or more spent, discount is 10%
				else if (_sumPurchases >= 2000)
				{
					_discount = DISCOUNT_10;
				}
				return _discount; }
			
        }

    }

	
}
