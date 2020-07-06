using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //для обработки исключений
            try
            {
                //запоминание в программе силы тока
                double I = Convert.ToDouble(textBox1.Text);
                //запоминание в программе напряжения
                double U = Convert.ToDouble(textBox2.Text);
                //расчет по формуле сопротивления
                label3.Text = "Ответ: " + U / I + " Ом";
            }
            catch
            {
                //сообщение об ошибке
                MessageBox.Show("Введите корректные данные ", "Ошибка");
            }
        }
    }
}
