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
            DateTime birthday=new DateTime(2000,1,1);
            Customer cus = new Customer("Son", "HungMin", birthday);
            cus.Address = "123 whire blvd";
            CusFullName.Text = cus.FullName;
            CusAge.Text = cus.Age.ToString();
            CusIsQualified.Text = cus.IsQualified.ToString();
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            bool test=cus.IsQualified;
        }

    }
}
