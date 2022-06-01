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
      
        public Form1()
        {
            InitializeComponent();

        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateCustomer_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer(CusNewLastName.Text, CusNewFirstName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description=CusNewDescription.Text;
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusIsQualified.Text = cus.IsQualified.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            bool test=cus.IsQualified;
        }

    }
}
