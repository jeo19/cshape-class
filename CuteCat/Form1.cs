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
            for(int i=0; i<arrayList.Count; i++)
            {
                int num = (int)arrayList[i];//Assign the type to force.
                sum += num;
            }
            int[] intArray = new int[5];
            ArrayList arrayList1 = new ArrayList();
            List<int> intList = new List<int>();
        }
    }
}
