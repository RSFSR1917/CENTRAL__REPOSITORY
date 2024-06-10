using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiguresWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            figure_comboBox.SelectedIndex = 0;
        }

        private void square_button_Click(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // прямоугольник
                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;

                case 1: // окружность
                    fig = new Circle((double)size1_numericUpDown.Value);
                    break;
                case 2: // квадрат
                    fig = new Square_((double)size1_numericUpDown.Value);
                    break;
                case 3: // треугольник
                    fig = new Triangle((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value);
                    break;
                case 4: // трапеция
                    fig = new Trapeze((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value, (double)size4_numericUpDown.Value);
                    break;
            }
            fig.Square();
            protocol_listBox.Items.Add(fig.ToString() + ": S=" + fig.Square());
        }
        private void perimeter_button_Click(object sender, EventArgs e)
        {
            Figure fig = null;
            switch (figure_comboBox.SelectedIndex)
            {
                case 0: // прямоугольник
                    fig = new Rect((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value);
                    break;

                case 1: // окружность
                    fig = new Circle((double)size1_numericUpDown.Value);
                    break;
                case 2: // квадрат
                    fig = new Square_((double)size1_numericUpDown.Value);
                    break;
                case 3: // треугольник
                    fig = new Triangle((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value);
                    break;
                case 4: // трапеция
                    fig = new Trapeze((double)size1_numericUpDown.Value, (double)size2_numericUpDown.Value, (double)size3_numericUpDown.Value, (double)size4_numericUpDown.Value);
                    break;
            }
            fig.Perimeter();
            protocol_listBox.Items.Add(fig.ToString() + ": P=" + fig.Perimeter());
        }
        private void figure_comboBox_TextChanged(object sender, EventArgs e)
        {
            if (figure_comboBox.SelectedIndex == 0)
            {
                size1_numericUpDown.Visible = true;
                size2_numericUpDown.Visible = true;
                size3_numericUpDown.Visible = false;
                size4_numericUpDown.Visible = false;
                label2.Text = "Длина";
                label3.Text = "Ширина";
                label4.Text = "";
                label5.Text = "";
                groupBox1.Height = 130;
                square_button.Location = new Point(square_button.Location.X, 149);
                perimeter_button.Location = new Point(perimeter_button.Location.X, 189);
            }
            if (figure_comboBox.SelectedIndex == 1)
            {
                size1_numericUpDown.Visible = true;
                size2_numericUpDown.Visible = false;
                size3_numericUpDown.Visible = false;
                size4_numericUpDown.Visible = false;
                label2.Text = "Радиус";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                groupBox1.Height = 110;
                square_button.Location = new Point(square_button.Location.X, 129);
                perimeter_button.Location = new Point(perimeter_button.Location.X, 169);
            }
            if (figure_comboBox.SelectedIndex == 2)
            {
                size1_numericUpDown.Visible = true;
                size2_numericUpDown.Visible = false;
                size3_numericUpDown.Visible = false;
                size4_numericUpDown.Visible = false;
                label2.Text = "Сторона";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
                groupBox1.Height = 110;
                square_button.Location = new Point(square_button.Location.X, 129);
                perimeter_button.Location = new Point(perimeter_button.Location.X, 169);
            }
            if (figure_comboBox.SelectedIndex == 3)
            {
                size1_numericUpDown.Visible = true;
                size2_numericUpDown.Visible = true;
                size3_numericUpDown.Visible = true;
                size4_numericUpDown.Visible = false;
                label2.Text = "Сторона А";
                label3.Text = "Сторона В";
                label4.Text = "Сторона С";
                label5.Text = "";
                groupBox1.Height = 150;
                size1_numericUpDown.Location = new Point(91, size1_numericUpDown.Location.Y);
                size2_numericUpDown.Location = new Point(91, size2_numericUpDown.Location.Y);
                size3_numericUpDown.Location = new Point(91, size3_numericUpDown.Location.Y);
                square_button.Location = new Point(square_button.Location.X, 169);
                perimeter_button.Location = new Point(perimeter_button.Location.X, 209);
            }
            if (figure_comboBox.SelectedIndex == 4)
            {
                size1_numericUpDown.Visible = true;
                size2_numericUpDown.Visible = true;
                size3_numericUpDown.Visible = true;
                size4_numericUpDown.Visible = true;
                label2.Text = "Сторона А";
                label3.Text = "Сторона В";
                label4.Text = "Сторона С";
                label5.Text = "Сторона D";
                groupBox1.Height = 170;
                size1_numericUpDown.Location = new Point(91, size1_numericUpDown.Location.Y);
                size2_numericUpDown.Location = new Point(91, size2_numericUpDown.Location.Y);
                size3_numericUpDown.Location = new Point(91, size3_numericUpDown.Location.Y);
                size4_numericUpDown.Location = new Point(91, size4_numericUpDown.Location.Y);
                square_button.Location = new Point(square_button.Location.X, 189);
                perimeter_button.Location = new Point(perimeter_button.Location.X, 229);
            }
        }
    }
}
