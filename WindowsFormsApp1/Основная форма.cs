using ChildrenSportSchool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ff = new StudentsForm(new Students { Birthday = DateTime.Now });
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox1.Items.Add(ff.Students);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Students)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = listBox1.SelectedItem is Students;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ff = new TeachersForm(new Teacher { BithdayTeacher = DateTime.Now });
            if (ff.ShowDialog(this) == DialogResult.OK)
            {
                listBox2.Items.Add(ff.Teacher);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem is Teacher)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = listBox2.SelectedItem is Teacher;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "Направление|*.sporttype" };

            if (sfd.ShowDialog(this) != DialogResult.OK)
                return;

            var sport = new SportTypeSchool()
            {
                TimePractice = dateTimePicker1.Value,
                Registr = listBox2.Items.OfType<Teacher>().ToList(),
                Journal = listBox1.Items.OfType<Students>().ToList(),
                Place = textBox2.Text,
                FirstName = textBox1.Text
            };

            switch (comboBox1.SelectedValue?.ToString())
            {
                case "Легкая атлетика":
                    sport.SportType = SportType.Athletics;
                    break;
                case "Бадминтон":
                    sport.SportType = SportType.Badminton;
                    break;
                case "Баскетбол":
                    sport.SportType = SportType.Basketball;
                    break;
                case "Чирлидинг":
                    sport.SportType = SportType.Cheerliding;
                    break;
                case "Современные танцы":
                    sport.SportType = SportType.Dance;
                    break;
                case "Подводное плавание":
                    sport.SportType = SportType.Diving;
                    break;
                case "Футбол":
                    sport.SportType = SportType.Football;
                    break;
                case "Художественная гимнастика":
                    sport.SportType = SportType.Gymnastics;
                    break;
                case "Водное поло":
                    sport.SportType = SportType.Polo;
                    break;
                case "Гребля":
                    sport.SportType = SportType.Rowing;
                    break;
                default:
                    sport.SportType = SportType.Swimming;
                    break;
            }

            var xs = new XmlSerializer(typeof(SportType));

            var file = File.Create(sfd.FileName);

            xs.Serialize(file, sport);
            file.Close();
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "Направление | *.sporttype" };

            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            var xs = new XmlSerializer(typeof(SportTypeSchool));
            var file = File.OpenRead(ofd.FileName);
            var sport = (SportTypeSchool)xs.Deserialize(file);
            file.Close();

            textBox1.Text = SportTypeSchool.FirstName;
            textBox2.Text = SportTypeSchool.Place;
            dateTimePicker1.Value = SportTypeSchool.TimePractice;
            switch (sport.SportType)
            {
                case SportType.Athletics:
                    comboBox1.Text = "Легкая атлетика";
                    break;
                case SportType.Badminton:
                    comboBox1.Text = "Бадминтон";
                    break;
                case SportType.Basketball:
                    comboBox1.Text = "Баскетбол";
                    break;
                case SportType.Cheerliding:
                    comboBox1.Text = "Чирлидинг";
                    break;
                case SportType.Dance:
                    comboBox1.Text = "Современные танцы";
                    break;
                case SportType.Diving:
                    comboBox1.Text = "Подводное плавание";
                    break;
                case SportType.Football:
                    comboBox1.Text = "Футбол";
                    break;
                case SportType.Gymnastics:
                    comboBox1.Text = "Художественная гимнастика";
                    break;
                case SportType.Polo:
                    comboBox1.Text = "Водное поло";
                    break;
                case SportType.Rowing:
                    comboBox1.Text = "Гребля";
                    break;
                case SportType.Swimming:
                    comboBox1.Text = "Плавание";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            foreach (var students in sport.Journal)
            {
                listBox1.Items.Add(students);
            }
            foreach (var teacher in sport.Registr )
            {
                listBox2.Items.Add(teacher);
            }
        }
    }
}
