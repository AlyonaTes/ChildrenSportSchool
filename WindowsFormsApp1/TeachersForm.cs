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
    public partial class TeachersForm : Form
    {
        public TeachersForm(Teacher teacher)
        {
            Teacher = teacher;
            InitializeComponent();
        }

        public TeachersForm()
        {
         
        }

        public Teacher Teacher { get; set; }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Teacher.NameTeacher;
            dateTimePicker1.Value = Teacher.BithdayTeacher;
            textBox2.Text = Teacher.Education;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher.NameTeacher = textBox1.Text;
            Teacher.BithdayTeacher = dateTimePicker1.Value;
            Teacher.Education = textBox2.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
