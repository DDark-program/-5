using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_2;

namespace Практ_4
{
    public partial class Form1 : Form
    {
        int onepair = 0;
        int twopair = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            Pair pair1 = new Pair(Convert.ToInt32(txtA.Text), Convert.ToInt32(txtB.Text));
            Pair pair2 = new Pair(Convert.ToInt32(txtThree.Text), Convert.ToInt32(txtFour.Text));

            Pair sumPair = Pair.SumPair(pair1, pair2);
            MessageBox.Show("Значение ab + cd = " + sumPair.First + ":" + sumPair.Second);
            MessageBox.Show("Значение a+b = " + pair1.Sum());
            MessageBox.Show("Значение a+b = " + pair2.Sum());
        }

        private void btnCalc2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            int c = Convert.ToInt32(txtC.Text);
            int res = Pair.SumField(a, b, c);
            MessageBox.Show("Значение a+b+c = " + res);
        }

        private void btnCalc3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOne.Text);
            int b = Convert.ToInt32(txtTwo.Text);
            int c = Convert.ToInt32(txtThree.Text);
            int d = Convert.ToInt32(txtFour.Text);
            Pair.SumPair(a, b, c, d, out onepair, out twopair);
            MessageBox.Show("Значение (a+c+f),(b+d+j) = " + "(" + onepair + ';' + twopair + ")");
        }

        private void btnCalc4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtOne.Text);
            int b = Convert.ToInt32(txtTwo.Text);
            int c = Convert.ToInt32(txtThree.Text);
            int d = Convert.ToInt32(txtFour.Text);
            int f = Convert.ToInt32(txtFive.Text);
            int j = Convert.ToInt32(txtSix.Text);
            Pair.SumPair(a, b, c, d, f, j, out onepair, out twopair);
            MessageBox.Show("Значение (a+c),(b+d) = " + "(" + onepair + ';' + twopair + ")");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Подъяблонский Данила Владимирович+ \n" +
                "Создать класс Pair (пара чисел). Создать необходимые методы и свойства.\n" +
                " Определить методы метод сложения полей и операцию сложения пар (а, b) + (с, d) = (а + c, b + d).\n" +
                " Создать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы ИСП-31 Подъяблонский Данила Владимирович+ \n" +
                "Создать класс Pair (пара чисел). Создать необходимые методы и свойства.\n" +
                " Определить методы метод сложения полей и операцию сложения пар (а, b) + (с, d) = (а + c, b + d).\n" +
                " Создать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
