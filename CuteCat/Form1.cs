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
        public Customer[] CustomerArray = new Customer[10];;
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

            CustomerArrayIndex++;
        }
        public void ShowDetails(Customer cus)
        {
            CusFullName.Text=cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();
        }
    }
}
