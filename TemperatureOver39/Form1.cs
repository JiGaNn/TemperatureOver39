using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureOver39
{
    public partial class Form1 : Form
    {
        private void tb_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
        }
        public Form1()
        {
            InitializeComponent();

            txt1.KeyUp += tb_KeyUp;
            txt2.KeyUp += tb_KeyUp;
            save.KeyUp += tb_KeyUp;
            clean.KeyUp += tb_KeyUp;

            var measureType = new string[]
            {
                "°C",
                "°F",
                "°Ra",
                "K"
            };
            cmbtype1.DataSource = new List<string>(measureType);
            cmbtype2.DataSource = new List<string>(measureType);
            cmbresultType.DataSource = new List<string>(measureType);

            comboBox1.Text = Properties.Settings.Default.comboBox1.ToString();
            txt1.Text = Properties.Settings.Default.txt1.ToString();
            txt2.Text = Properties.Settings.Default.txt2.ToString();
            result.Text = Properties.Settings.Default.result.ToString();
            cmbtype1.Text = Properties.Settings.Default.cmbtype1.ToString();
            cmbtype2.Text = Properties.Settings.Default.cmbtype2.ToString();
            cmbresultType.Text = Properties.Settings.Default.cmbresultType.ToString();
        }
        private void Calculate()
        {
            try
            {
                if (cmbresultType.Text == "")
                    cmbresultType.Text = "°C";
                if (cmbtype2.Text == "")
                    cmbtype2.Text = "°C";
                var temp1 = Convert.ToDouble(txt1.Text);
                var temp2 = Convert.ToDouble(txt2.Text);

                TempType type1 = GetTempType(cmbtype1);
                TempType type2 = GetTempType(cmbtype2);
                TempType typeResult = GetTempType(cmbresultType);

                Temperature t1 = new Temperature(temp1, type1);
                Temperature t2 = new Temperature(temp2, type2);
                Temperature res = null;

                switch (comboBox1.Text)
                {
                    case "сложение":
                        res = t1 + t2;
                        break;
                    case "вычитание":
                        res = t1 - t2;
                        break;
                    case "умножение на число":
                        cmbtype2.Text = "";
                        res = t1 * temp2;
                        break;
                    case "сравнение":
                        cmbresultType.Text = "";
                        if(t1 == t2)
                        {
                            result.Text = "Значения равны";
                            return;
                        }
                        else
                        {
                            result.Text = "Значения не равны";
                            return;
                        }
                    default:
                        res = new Temperature(0, typeResult);
                        break;
                }
                result.Text = res.To(typeResult).Output();
            }
            catch(FormatException)
            {
                //MessageBox.Show("Не удалось преобразовать текст в число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private TempType GetTempType(ComboBox comboBox)
        {
            TempType tempType;
            switch(comboBox.Text)
            {
                case "°C":
                    tempType = TempType.c;
                    break;
                case "°F":
                    tempType = TempType.f;
                    break;
                case "°Ra":
                    tempType = TempType.r;
                    break;
                case "K":
                    tempType = TempType.k;
                    break;
                default:
                    tempType = TempType.c;
                    break;
            }
            return tempType;
        }
        private void myChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void clean_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "сложение";
            txt1.Text = "";
            txt2.Text = "";
            result.Text = "";
            cmbtype1.Text = "°C";
            cmbtype2.Text = "°C";
            cmbresultType.Text = "°C";
        }
        private void save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.comboBox1 = comboBox1.Text;
            Properties.Settings.Default.txt1 = txt1.Text;
            Properties.Settings.Default.txt2 = txt2.Text;
            Properties.Settings.Default.result = result.Text;
            Properties.Settings.Default.cmbtype1 = cmbtype1.Text;
            Properties.Settings.Default.cmbtype2 = cmbtype2.Text;
            Properties.Settings.Default.cmbresultType = cmbresultType.Text;
            Properties.Settings.Default.Save();
        }
    }
}
