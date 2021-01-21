using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        class People
        {
            //Поля класса
            public string fname;
            public string lname;
            public int age;

            // Конструктор класса, принимающий значения 3 переменных
            public People(string fn, string ln, int a) { fname = fn; lname = ln; age = a; }

            //Метод класса для вывода информации в listbox
            public void GetInfo()
            {
                MessageBox.Show($"Имя {fname}");
                MessageBox.Show($"Фамилия {lname}");
                MessageBox.Show($"Возраст {age}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            People Sam = new People(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));
            Sam.GetInfo();
        }

    }
}
