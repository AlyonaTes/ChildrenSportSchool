using System;
using ChildrenSportSchool; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class StudentsForm : Form
    {
        public StudentsForm(Students students)
        {
            Students = students;
            InitializeComponent();
        }

        public StudentsForm()
        {
            
        }

        public  Students Students { get; set; }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Students.Name;
            dateTimePicker1.Value = Students.Birthday;
            textBox2.Text = Students.PlaceEducation;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Students.Name = textBox1.Text;
            Students.Birthday = dateTimePicker1.Value;
            Students.PlaceEducation = textBox2.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
