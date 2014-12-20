using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementApp
{
    public partial class CustomerQueueManagementUI : Form
    {
        Queue<Customer> aCustomer = new Queue<Customer>();
       //List<Customer> aCustomer = new List<Customer>();
        int count = 0;
        public CustomerQueueManagementUI()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {
            count++; 


            Customer customer1 = new Customer();
            customer1.name = nameTextBox.Text;
            customer1.complain = complainTextBox.Text;

            aCustomer.Enqueue(customer1);
                  
            customer1.serialNo = count; 
                     
           ListViewItem li = new ListViewItem();
           li.Text = (count.ToString());
           li.SubItems.Add(customer1.name);
           li.SubItems.Add(customer1.complain);           
           waitingListView.Items.Add(li);
           

            MessageBox.Show(nameTextBox.Text+ " your serial number is "+ customer1.serialNo);

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            Customer customer1 = new Customer();
           
           customer1= aCustomer.Dequeue();
            serialNoTextBox.Text = Convert.ToString(customer1.serialNo);
            dequeueNameTextBox.Text = customer1.name;
            dequeueComplainTextBox.Text = customer1.complain;
           
            
            waitingListView.Items.RemoveAt(0);
           
        }
    }
}
