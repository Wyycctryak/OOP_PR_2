using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_LB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            float x;
            float y;
            float width;
            float heigth;


            if (!float.TryParse(tbxX.Text, out x) || x < 0)
            {
                MessageBox.Show("Проверьте данные!", "Ошибка ввода");
                Clear();
                return;
            }
            if (!float.TryParse(tbxY.Text, out y) || y < 0)
            {
                MessageBox.Show("Проверьте данные!", "Ошибка ввода");
                Clear();
                return;
            }
            if (!float.TryParse(tbxWidth.Text, out width) || width < 0 || x + width >= 180 || x + width / 2 >= 253)
            {
                MessageBox.Show("Проверьте данные!", "Ошибка ввода");
                Clear();
                return;
            }
            if (!float.TryParse(tbxHeight.Text, out heigth) || heigth < 0 || y + heigth >= 270 || y - heigth <= 0)
            {
                MessageBox.Show("Проверьте данные!", "Ошибка ввода");
                Clear();
                return;
            }
            if (comboBox1.Text == "Прямоугольник")
            {
                Rectangle Rec = new Rectangle(Convert.ToInt32(tbxX.Text), Convert.ToInt32(tbxY.Text), Convert.ToInt32(tbxWidth.Text), Convert.ToInt32(tbxHeight.Text));
                Rec.Draw(pictureBox1, Color.Black);
                MessageBox.Show($"Площадь прямоугольника\nS= {Rec.Area()} пикс.кв.");
            }
            else if (comboBox1.Text == "Равнобедренный треугольник")
            {
                Triangle Tri = new Triangle(Convert.ToInt32(tbxX.Text), Convert.ToInt32(tbxY.Text), Convert.ToInt32(tbxWidth.Text), Convert.ToInt32(tbxHeight.Text));
                Tri.Draw(pictureBox1, Color.Black);
                MessageBox.Show($"Площадь равнобедренного треугольника\nS= {Tri.Area()} пикс.кв.");
            }
            else
            {
                MessageBox.Show("Выберите элемент!", "Ошибка ввода");
                ClearcmbX();
                return;
            }


        }
        private void Clear()
        {
            tbxX.Text = "";
            tbxY.Text = "";
            tbxWidth.Text = "";
            tbxHeight.Text = "";
        }
        private void ClearcmbX()
        {
            comboBox1.Text = "";
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

    }
}
