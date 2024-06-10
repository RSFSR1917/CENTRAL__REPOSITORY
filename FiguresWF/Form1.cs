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
        }
    }
}
