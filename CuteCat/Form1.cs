using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CuteCat
{
    public partial class Form1 : Form
    {
        private List<Customer> Customers = new List<Customer>();
        public Form1()
        {
            InitializeComponent();

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {


            Customer cus = new Customer(CusNewLastName.Text, CusNewFirstName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CustomerList.Items.Add(cus.FullName);
            //ShowDetails(CustomerArray[CustomerArrayIndex]);
            Customers.Add(cus);
        }
        private void ShowDetails(Customer cus)
        {
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string fullName = CustomerList.SelectedItem.ToString();
            foreach (Customer cus in Customers)
            {
                if (cus.FullName == fullName)
                {
                    ShowDetails(cus);
                    break;
                }
            }
        }


    }
}
