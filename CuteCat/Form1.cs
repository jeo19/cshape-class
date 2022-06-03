using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuteCat
{
    public partial class Form1 : Form
    {
        private Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;
        public Form1()
        {
            InitializeComponent();

        }
 
        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            

            CustomerArray[CustomerArrayIndex] = new Customer(CusNewLastName.Text, CusNewFirstName.Text, DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description=CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FullName);
            //ShowDetails(CustomerArray[CustomerArrayIndex]);
            CustomerArrayIndex++;
        }
        private void ShowDetails(Customer cus)
        {
            CusFullName.Text=cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string fullName=CustomerList.SelectedItem.ToString();
            for(int i=0;i < CustomerArrayIndex; i++)
            {
                if (CustomerArray[i].FullName.Equals(fullName))
                {
                    ShowDetails(CustomerArray[i]);
                }
            }
        }
    }
}
