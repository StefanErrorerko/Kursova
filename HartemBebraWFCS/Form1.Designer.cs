
namespace HartemBebraWFCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.FuncShow = new System.Windows.Forms.Label();
            this.button_build = new System.Windows.Forms.Button();
            this.button_up = new System.Windows.Forms.Button();
            this.button_down = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.myChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_scale_plus = new System.Windows.Forms.Button();
            this.button_scale_minus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_moveup = new System.Windows.Forms.Button();
            this.button_movedown = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button_manual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.foo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.acoef = new System.Windows.Forms.TextBox();
            this.bcoef = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FuncShow
            // 
            this.FuncShow.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FuncShow.Location = new System.Drawing.Point(544, 497);
            this.FuncShow.Name = "FuncShow";
            this.FuncShow.Size = new System.Drawing.Size(183, 23);
            this.FuncShow.TabIndex = 3;
            this.FuncShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FuncShow.UseMnemonic = false;
            // 
            // button_build
            // 
            this.button_build.Location = new System.Drawing.Point(171, 534);
            this.button_build.Name = "button_build";
            this.button_build.Size = new System.Drawing.Size(217, 40);
            this.button_build.TabIndex = 5;
            this.button_build.Text = "Побудувати графік функції";
            this.button_build.UseVisualStyleBackColor = true;
            this.button_build.Click += new System.EventHandler(this.button_build_Click);
            // 
            // button_up
            // 
            this.button_up.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_up.Location = new System.Drawing.Point(730, 480);
            this.button_up.Name = "button_up";
            this.button_up.Size = new System.Drawing.Size(30, 25);
            this.button_up.TabIndex = 6;
            this.button_up.Text = "˄";
            this.button_up.UseVisualStyleBackColor = false;
            this.button_up.Click += new System.EventHandler(this.button_up_Click);
            // 
            // button_down
            // 
            this.button_down.Location = new System.Drawing.Point(730, 507);
            this.button_down.Name = "button_down";
            this.button_down.Size = new System.Drawing.Size(30, 25);
            this.button_down.TabIndex = 7;
            this.button_down.Text = "˅";
            this.button_down.UseVisualStyleBackColor = true;
            this.button_down.Click += new System.EventHandler(this.button_down_Click);
            // 
            // button_left
            // 
            this.button_left.Location = new System.Drawing.Point(41, 547);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(30, 25);
            this.button_left.TabIndex = 8;
            this.button_left.Text = "<";
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_right
            // 
            this.button_right.Location = new System.Drawing.Point(113, 547);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(30, 25);
            this.button_right.TabIndex = 9;
            this.button_right.Text = ">";
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_home
            // 
            this.button_home.Location = new System.Drawing.Point(77, 547);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(30, 25);
            this.button_home.TabIndex = 10;
            this.button_home.Text = "🏠";
            this.button_home.UseVisualStyleBackColor = true;
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // myChart
            // 
            chartArea1.Name = "ChartArea1";
            this.myChart.ChartAreas.Add(chartArea1);
            this.myChart.Location = new System.Drawing.Point(66, 5);
            this.myChart.Name = "myChart";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Gray;
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            this.myChart.Series.Add(series1);
            this.myChart.Series.Add(series2);
            this.myChart.Size = new System.Drawing.Size(681, 469);
            this.myChart.TabIndex = 1;
            this.myChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "MainTitle";
            title1.Text = "Графік функції";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.myChart.Titles.Add(title1);
            // 
            // button_scale_plus
            // 
            this.button_scale_plus.Location = new System.Drawing.Point(49, 609);
            this.button_scale_plus.Name = "button_scale_plus";
            this.button_scale_plus.Size = new System.Drawing.Size(30, 25);
            this.button_scale_plus.TabIndex = 11;
            this.button_scale_plus.Text = "+";
            this.button_scale_plus.UseVisualStyleBackColor = true;
            this.button_scale_plus.Click += new System.EventHandler(this.button_scale_plus_Click);
            // 
            // button_scale_minus
            // 
            this.button_scale_minus.Location = new System.Drawing.Point(102, 609);
            this.button_scale_minus.Name = "button_scale_minus";
            this.button_scale_minus.Size = new System.Drawing.Size(30, 25);
            this.button_scale_minus.TabIndex = 12;
            this.button_scale_minus.Text = "-";
            this.button_scale_minus.UseVisualStyleBackColor = true;
            this.button_scale_minus.Click += new System.EventHandler(this.button_scale_minus_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(76, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "🔍";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_moveup
            // 
            this.button_moveup.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_moveup.Location = new System.Drawing.Point(77, 516);
            this.button_moveup.Name = "button_moveup";
            this.button_moveup.Size = new System.Drawing.Size(30, 25);
            this.button_moveup.TabIndex = 14;
            this.button_moveup.Text = "˄";
            this.button_moveup.UseVisualStyleBackColor = false;
            this.button_moveup.Click += new System.EventHandler(this.button_moveup_Click);
            // 
            // button_movedown
            // 
            this.button_movedown.Location = new System.Drawing.Point(77, 578);
            this.button_movedown.Name = "button_movedown";
            this.button_movedown.Size = new System.Drawing.Size(30, 25);
            this.button_movedown.TabIndex = 15;
            this.button_movedown.Text = "˅";
            this.button_movedown.UseVisualStyleBackColor = true;
            this.button_movedown.Click += new System.EventHandler(this.button_movedown_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(407, 534);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(85, 40);
            this.button_clear.TabIndex = 16;
            this.button_clear.Text = "Очистити";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(536, 601);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(108, 40);
            this.button_about.TabIndex = 17;
            this.button_about.Text = "Про автора";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(690, 601);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(70, 40);
            this.button_exit.TabIndex = 19;
            this.button_exit.Text = "Вийти";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Tag = "k";
            // 
            // button_manual
            // 
            this.button_manual.Location = new System.Drawing.Point(171, 601);
            this.button_manual.Name = "button_manual";
            this.button_manual.Size = new System.Drawing.Size(321, 40);
            this.button_manual.TabIndex = 18;
            this.button_manual.Text = "Інструкція";
            this.button_manual.UseVisualStyleBackColor = true;
            this.button_manual.Click += new System.EventHandler(this.button_manual_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "y =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 551);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "•";
            // 
            // foo
            // 
            this.foo.AutoSize = true;
            this.foo.Location = new System.Drawing.Point(644, 551);
            this.foo.Name = "foo";
            this.foo.Size = new System.Drawing.Size(32, 17);
            this.foo.TabIndex = 24;
            this.foo.Text = "___";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "+";
            // 
            // acoef
            // 
            this.acoef.Enabled = false;
            this.acoef.Location = new System.Drawing.Point(574, 548);
            this.acoef.Name = "acoef";
            this.acoef.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.acoef.Size = new System.Drawing.Size(45, 22);
            this.acoef.TabIndex = 27;
            // 
            // bcoef
            // 
            this.bcoef.Enabled = false;
            this.bcoef.Location = new System.Drawing.Point(702, 550);
            this.bcoef.Name = "bcoef";
            this.bcoef.Size = new System.Drawing.Size(45, 22);
            this.bcoef.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(462, 497);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 22);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 653);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.acoef);
            this.Controls.Add(this.bcoef);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.foo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_manual);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_movedown);
            this.Controls.Add(this.button_moveup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_scale_minus);
            this.Controls.Add(this.button_scale_plus);
            this.Controls.Add(this.button_home);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_down);
            this.Controls.Add(this.button_up);
            this.Controls.Add(this.button_build);
            this.Controls.Add(this.myChart);
            this.Controls.Add(this.FuncShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.myChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FuncShow;
        private System.Windows.Forms.Button button_build;
        private System.Windows.Forms.Button button_up;
        private System.Windows.Forms.Button button_down;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.DataVisualization.Charting.Chart myChart;
        private System.Windows.Forms.Button button_scale_plus;
        private System.Windows.Forms.Button button_scale_minus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_moveup;
        private System.Windows.Forms.Button button_movedown;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button_manual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label foo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox acoef;
        private System.Windows.Forms.TextBox bcoef;
        private System.Windows.Forms.TextBox textBox1;
    }
}

