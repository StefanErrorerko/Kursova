using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HartemBebraWFCS
{
    public partial class Form1 : Form
    {
        enum Side
        {
            ToCentre,
            Left,
            Right,
            Up,
            Down
        }
        private int func_num { get; set; } = -1;
        private double xmin = -5, xmax = 5, ymin = -5, ymax = 5,
            scale_value = 1,
            move_value = 1,
            step = 0.01;
        public Form1()
        {
            InitializeComponent();
            Axis ax = new Axis();
            Axis ay = new Axis();
            ax.Title = "x";
            ay.Title = "y";
            ax.TextOrientation = TextOrientation.Stacked;
            ay.TextOrientation = TextOrientation.Stacked;
            ax.Interval = 1;
            ay.Interval = 1;
            myChart.ChartAreas[0].AxisX = ax;
            myChart.ChartAreas[0].AxisY = ay;
            myChart.ChartAreas[0].AxisX.Maximum = xmax;
            myChart.ChartAreas[0].AxisX.Minimum = xmin;
            myChart.ChartAreas[0].AxisY.Maximum = xmax;
            myChart.ChartAreas[0].AxisY.Minimum = xmin;
            myChart.ChartAreas[0].AxisY.Crossing = 0;
            myChart.ChartAreas[0].AxisX.Crossing = 0;
            myChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            myChart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            this.myChart.Series[1].Points.AddXY(0, 0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(this.button_about, "Відомості про автора");
            toolTip1.SetToolTip(this.myChart, "Область графіків.\nТут будується графік");
            toolTip1.SetToolTip(this.button_moveup, "Переміщення вгору");
            toolTip1.SetToolTip(this.button_movedown, "Переміщення вниз");
            toolTip1.SetToolTip(this.button_left, "Переміщення ліворуч");
            toolTip1.SetToolTip(this.button_right, "Переміщення праворуч");
            toolTip1.SetToolTip(this.button_home, "Відцентрувати");
            toolTip1.SetToolTip(this.FuncShow, "Обрана функція");
            toolTip1.SetToolTip(this.button_build, "Побудувати графік функції");
            toolTip1.SetToolTip(this.button_clear, "Очистити область графіків");
            toolTip1.SetToolTip(this.button_exit, "Завершити роботу програми");
            toolTip1.SetToolTip(this.button_down, "Попередня функція");
            toolTip1.SetToolTip(this.button_up, "Наступна функція");
        }

        private void ChartShowChange(string scale)
        {
            double scaling = scale_value;
            if(scale == "-") {
                scaling *= -1;
            }
            if (Math.Abs(myChart.ChartAreas[0].AxisX.Maximum) + Math.Abs(myChart.ChartAreas[0].AxisX.Minimum) > 2 || scale == "-")
            {
                myChart.ChartAreas[0].AxisX.Maximum -= scaling;
                myChart.ChartAreas[0].AxisX.Minimum += scaling;
                myChart.ChartAreas[0].AxisY.Maximum -= scaling;
                myChart.ChartAreas[0].AxisY.Minimum += scaling;
                myChart.ChartAreas[0].AxisX.Interval = (Math.Abs(myChart.ChartAreas[0].AxisX.Maximum) + Math.Abs(myChart.ChartAreas[0].AxisX.Minimum)) / 10;
                myChart.ChartAreas[0].AxisY.Interval = (Math.Abs(myChart.ChartAreas[0].AxisY.Maximum) + Math.Abs(myChart.ChartAreas[0].AxisY.Minimum)) / 10;
                GraphBuild();
            }
        }
        private void ChartShowChange(Side move_side)
        {
            if(move_side == Side.Left)
            {
                myChart.ChartAreas[0].AxisX.Minimum-= move_value;
                myChart.ChartAreas[0].AxisX.Maximum-= move_value;
            }
            else if(move_side == Side.Right)
            {
                myChart.ChartAreas[0].AxisX.Minimum += move_value;
                myChart.ChartAreas[0].AxisX.Maximum += move_value;
            }
            else if(move_side == Side.Down)
            {
                myChart.ChartAreas[0].AxisY.Minimum-= move_value;
                myChart.ChartAreas[0].AxisY.Maximum-= move_value;
            }
            else if (move_side == Side.Up)
            {
                myChart.ChartAreas[0].AxisY.Minimum+= move_value;
                myChart.ChartAreas[0].AxisY.Maximum+= move_value;
            }
            else if (move_side == Side.ToCentre)
            {
                myChart.ChartAreas[0].AxisX.Minimum = xmin;
                myChart.ChartAreas[0].AxisX.Maximum = xmax;
                myChart.ChartAreas[0].AxisY.Minimum = ymin;
                myChart.ChartAreas[0].AxisY.Maximum = ymax;
            }
            GraphBuild();
        }

        private void GraphBuild()
        {
            try
            {
                //Clear();
                //string func = textBox1.Text;
                //char[] separators = new char[] {'*','+', '-', '/' };

                Clear();
                double x, y, last_step = step;
                if (func_num == 3)
                {
                    x = myChart.ChartAreas[0].AxisX.Minimum;
                    while (x <= 0)
                    {
                        if (x >= -2 * last_step && x <= 2 * last_step)
                        {
                            step = 0.001;
                        }
                        y = Function(x);
                        if (y <= myChart.ChartAreas[0].AxisY.Maximum && y >= myChart.ChartAreas[0].AxisY.Minimum)
                        {
                            this.myChart.Series[0].Points.AddXY(x, y);
                        }
                        x += step;
                        step = last_step;
                    }
                    if (this.myChart.Series.FindByName("Hyperbola") == null)
                    {
                        this.myChart.Series.Add($"Hyperbola");
                        this.myChart.Series[this.myChart.Series.Count - 1].ChartType = SeriesChartType.Spline;
                        this.myChart.Series[this.myChart.Series.Count - 1].BorderWidth = 2;
                        this.myChart.Series[this.myChart.Series.Count - 1].Color = Color.DodgerBlue;
                    }
                    x = 0;
                    while (x <= myChart.ChartAreas[0].AxisX.Maximum)
                    {
                        if (x >= -2 * last_step && x <= 2 * last_step)
                        {
                            step = 0.001;
                        }
                        y = Function(x);
                        if (y <= myChart.ChartAreas[0].AxisY.Maximum && y >= myChart.ChartAreas[0].AxisY.Minimum)
                        {
                            this.myChart.Series[this.myChart.Series.Count - 1].Points.AddXY(x, y);
                        }
                        x += step;
                        step = last_step;
                    }

                }
                else if (func_num == 8 || func_num == 7)
                {
                    double assymptota;
                    if (func_num == 8)
                    {
                        assymptota = Math.PI;
                    }
                    else
                    {
                        assymptota = Math.PI / 2;
                    }
                    x = myChart.ChartAreas[0].AxisX.Minimum;
                    int count = 1;
                    while (x <= myChart.ChartAreas[0].AxisX.Maximum)
                    {
                        if (this.myChart.Series.Count < count + 2)
                        {
                            this.myChart.Series.Add($"Series{this.myChart.Series.Count + 1}");
                            this.myChart.Series[this.myChart.Series.Count - 1].ChartType = SeriesChartType.Spline;
                            this.myChart.Series[this.myChart.Series.Count - 1].BorderWidth = 2;
                            this.myChart.Series[this.myChart.Series.Count - 1].Color = Color.DodgerBlue;
                        }
                        do
                        {
                            y = Function(x);
                            if (y <= myChart.ChartAreas[0].AxisY.Maximum && y >= myChart.ChartAreas[0].AxisY.Minimum)
                            {
                                this.myChart.Series[count + 1].Points.AddXY(x, y);
                            }
                            x += step;
                        } while (Math.Abs(x % assymptota) > 0.001);
                        ++count;
                    }
                }
                else if (func_num >= 0)
                {
                    x = myChart.ChartAreas[0].AxisX.Minimum;
                    while (x <= myChart.ChartAreas[0].AxisX.Maximum)
                    {
                        y = Function(x);
                        if (y <= myChart.ChartAreas[0].AxisY.Maximum && y >= myChart.ChartAreas[0].AxisY.Minimum)
                        {
                            this.myChart.Series[0].Points.AddXY(x, y);
                        }
                        x += step;
                    }
                }
                step = last_step;
            }
            catch (Exception ex)
            {
                if (acoef.Text == "0")
                {
                    toolTip1.Show(ex.Message, this.bcoef, 3000);
                }
                
                else if (acoef.Text == "")
                {
                    toolTip1.Show("Заповніть усі поля", this.bcoef, 3000);
                }
                else if (bcoef.Text == "")
                {
                    toolTip1.Show("Заповніть усі поля", this.acoef, 3000);
                }
                else if (acoef.Text != "" && bcoef.Text != "")
                {
                    toolTip1.Show("Введено невірний формат даних. Спробуйте числа", this.bcoef, 4000);
                }
            }
        }

        private double Function(double x)
        {
            double y = Double.PositiveInfinity,
                a, b;
            if (acoef.Text == "0" && func_num != 4)
            {
                throw new Exception("Множення функції на нуль є некоректним");
            }
            a = Convert.ToDouble(acoef.Text);
            b = Convert.ToDouble(bcoef.Text);
            switch (func_num)
            {
                case 0:
                    y = a * Math.Sqrt(x) + b;
                    break;
                case 1:
                    y = a * Math.Pow(x, 2) + b;
                    break;
                case 2:
                    y = a * Math.Pow(x, 3) + b;
                    break;
                case 3:
                    y = a * 1 / x + b;
                    break;
                case 4:
                    y = a * x + b;
                    break;
                case 5:
                    y = a * Math.Cos(x) + b;
                    break;
                case 6:
                    y = a * Math.Sin(x) + b;
                    break;
                case 7:
                    y = a * Math.Tan(x) + b;
                    break;
                case 8:
                    y = a / Math.Tan(x) + b;
                    break;
            }
            return y;
        }

        private void LabelChange()
        {
            switch (func_num)
            {
                case 0:
                    FuncShow.Text = "y = a•√x+b";
                    foo.Text = "√x";
                    acoef.Enabled = true;
                    bcoef.Enabled = true;
                    break;
                case 1:
                    FuncShow.Text = "y = ax²+b";
                    foo.Text = "x²";
                    break;
                case 2:
                    FuncShow.Text = "y = ax³+b";
                    foo.Text = "x³";
                    break;
                case 3:
                    FuncShow.Text = "y = a•1/x+b";
                    foo.Text = "1/x";
                    break;
                case 4:
                    FuncShow.Text = "y = ax+b";
                    foo.Text = "x";
                    break;
                case 5:
                    FuncShow.Text = "y = a•cos(x)+b";
                    foo.Text = "cos x";
                    break;
                case 6:
                    FuncShow.Text = "y = a•sin(x)+b";
                    foo.Text = "sin x";
                    break;
                case 7:
                    FuncShow.Text = "y = a•tg(x)+b";
                    foo.Text = "tg x";
                    break;
                case 8:
                    FuncShow.Text = "y = a•ctg(x)+b";
                    foo.Text = "ctg x";
                    acoef.Enabled = true;
                    bcoef.Enabled = true;
                    break;
                default:
                    FuncShow.Text = "";
                    foo.Text = "";
                    acoef.Enabled = false;
                    bcoef.Enabled = false;
                    break;
            }
        }

        private void Clear()
        {
            for (int i = 0; i < this.myChart.Series.Count; i++)
            {
                if (i != 1)
                {
                    this.myChart.Series[i].Points.Clear();
                }
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            toolTip1.Show("", this.myChart);
        }
        //---------------------Кнопки-------------------------------
        //----------------кнопки навгіації--------------------------
        private void button_home_Click(object sender, EventArgs e)
        {
            ChartShowChange(Side.ToCentre);
        }

        private void button_moveup_Click(object sender, EventArgs e)
        {
            ChartShowChange(Side.Up);

        }

        private void button_movedown_Click(object sender, EventArgs e)
        {
            ChartShowChange(Side.Down);

        }

        private void button_right_Click(object sender, EventArgs e)
        {
            ChartShowChange(Side.Right);

        }
        private void button_left_Click(object sender, EventArgs e)
        {
            ChartShowChange(Side.Left);
        }

        //-----------------кнопки зміни масштабування-------------------
        private void button_scale_minus_Click(object sender, EventArgs e)
        {
            ChartShowChange("-");
        }

        private void button_scale_plus_Click(object sender, EventArgs e)
        {
            ChartShowChange("+");
        }

        //--------------кнопки вибору функції---------------------------
        private void button_up_Click(object sender, EventArgs e)
        {
            if (func_num < 8)
            {
                ++func_num;
            }
            else
            {
                func_num = 0;
            }
            LabelChange();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_down_Click(object sender, EventArgs e)
        {
            if (func_num > 0)
            {
                --func_num;
            }
            else
            {
                func_num = 8;
            }
            LabelChange();
        }
        //------------------інформативні кнопки------------------------
        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void button_manual_Click(object sender, EventArgs e)
        {
            toolTip1.Show("Щоб побудувати графік функції, оберіть його справа кнопками ˅ і ˄." +
                "\nУведіть нижче коєфіцієнти a i b." +
                "\nДалі натисніть кнопку 'Побудувати графік'." +
                "\nКоли графік побудувано, ви можете змінити його масштаб кнопками + і -," +
                "\nпереміщатись по ньому кнопками ˅, ˄, <, i >." +
                "\nНатиснувши на символ 🏠, координатна площина відцентрується." +
                "\nЯкщо необхідно стерти область графіків, натисніть кнопку 'Очистити'.", this.myChart, 9000);
        }

        //----------------кнокпи роботи над Chart--------------------
        private void button_clear_Click(object sender, EventArgs e)
        {
            Clear();
            func_num = -1;
            FuncShow.Text = "";
            acoef.Enabled = false;
            bcoef.Enabled = false;
            foo.Text = "___";
            acoef.Text = "";
            bcoef.Text = "";
        }

        private void button_build_Click(object sender, EventArgs e)
        {
            GraphBuild();
        }
    }
}