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

            CusList.Rows.Add(cus.FullName, cus.Age, cus.IsQualified);
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

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fullName =(string) CusList.Rows[e.RowIndex].Cells[0].Value;
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
