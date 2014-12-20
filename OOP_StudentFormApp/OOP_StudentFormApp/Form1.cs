using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_StudentFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        //Student astudent2 = new Student();
        //Student astudent3 = new Student();
        List<Student> students = new List<Student>();
        String line = "Reg No     Get Full Name" + "\n";

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Student astudent1 = new Student();
            astudent1.regNo = Convert.ToInt32(regNoText.Text);
            astudent1.firstName = firstText.Text;
            astudent1.lastName = lastText.Text;
            students.Add(astudent1);
            regNoText.Text = String.Empty;
            firstText.Text = String.Empty;
            lastText.Text = String.Empty;

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {

            foreach (Student astudent in students)
            {
               
                line+=Convert.ToString(astudent.regNo) + "               " + astudent.GetFullName()+"\n";
            }
            MessageBox.Show(line);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            students.Clear();
            line = String.Empty;
            MessageBox.Show("All are deleted");
        }
    }
}
