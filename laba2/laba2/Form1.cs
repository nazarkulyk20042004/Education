using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba2
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

        private void button1_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text);

            // Обчислюємо площу кругового сегмента
            double angle = 2 * Math.Acos((radius - height) / radius);
            double segmentArea = 0.5 * Math.Pow(radius, 2) * (angle - Math.Sin(angle));

            // Відображаємо результат в текстовому полі
            textBox3.Text = segmentArea.ToString();
        }
    }
}

