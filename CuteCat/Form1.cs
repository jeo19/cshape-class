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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(0);
            arrayList.Add(1);
            arrayList.Add(3);

            arrayList.Insert(2, 2);
            arrayList.Remove(2);// Remove array item with a value is 2.
            arrayList.RemoveAt(1);// Remove array index is 1.
            //arrayList[0]; 0
            //arrayList[1]; 1
            //arrayList[2]; 2
            //arratList[3]; 3
            int sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                int num = (int)arrayList[i];//Assign the type to force.
                sum += num;
            }
            int[] intArray = new int[5];
            ArrayList arrayList1 = new ArrayList();
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            int sum2 = 0;
            for (int i = 0; i < intList.Count; i++)
            {
                int value = intArray[i];
                sum2 += value;
            }
            foreach (int value in intList)
            {
                sum2 += value;//The result is the same as above
            }
        }
    }
}
