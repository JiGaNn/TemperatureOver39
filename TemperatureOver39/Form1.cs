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
        public Form1()
        {
            InitializeComponent();

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
        }
        private void Calculate()
        {
            try
            {
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
                        res = t1 * temp2;
                        break;
                    case "сравнение":
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
        private void txt1_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
