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
    public partial class Form1 : Form
    {
        //Счётчик количества экземпляров класса
        int i = 0;
        //Объявляем массив экземпляров классов
        People[] plp = new People[10];

        public Form1()
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
            public People(string fn, string ln, int a) { fname = fn; lname = ln; age = a;}   
                       
            //Метод класса для вывода информации в listbox
            public void GetInfo(ListBox listbox1)
            {
                listbox1.Items.Add($"Имя {fname}");
                listbox1.Items.Add($"Фамилия {lname}");
                listbox1.Items.Add($"Возраст {age}");                
            }
        }

        //ВВвод новых экземпляров класса
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            i++;
            //Используя конструктор, вводим данные из textbox в поля экземплярра класса         
            plp[i] = new People(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text));          
            //Метод вывода добавленного экземпляра класса в ListBox
            plp[i].GetInfo(listBox1);
            //Увеличиваем счётчик на единицу, что бы использовать данную переменную как индекс массива экземпляра классов.
            

        }

        //Вывод всех экземпляров класса
        private void button2_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            
           for(int p = 1; p<=i; p++)
            {
                MessageBox.Show(p.ToString());
                plp[p].GetInfo(listBox1);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
