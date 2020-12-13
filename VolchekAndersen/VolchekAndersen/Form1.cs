using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolchekAndersen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            if (TB.TextLength > 0)
            {
                TB.BackColor = Color.White;
                double num = Double.Parse(TB.Text.Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture); 
                if (num > 7)
                        MessageBox.Show("Привет");
            }
            else
            {
                MessageBox.Show("Введите число в текстовое поле!");
                TB.BackColor = Color.Red;
            }
        }

        private void BTN_Solve_Name_Click(object sender, EventArgs e)
        {
               if (TB_Name.Text == "Вячеслав")
                    MessageBox.Show("Привет, Вячеслав");
                else
                    MessageBox.Show("Нет такого имени");
        }

        private void BTN_Massiv_Click(object sender, EventArgs e)
        {
            if (TB_Massiv.TextLength > 0)
            {
                TB_Massiv.BackColor = Color.White;
                string[] Mass_string = TB_Massiv.Text.Split(' ');
                string result = "";
                foreach (string str in Mass_string)
                {
                    double num;
                    if (double.TryParse(str, out num))
                        if ((num!=0)&&(num % 3 == 0))
                            result += num + "; ";
                }
              
                        MessageBox.Show("Элементы массива, кратные 3: "+result);
            }
            else
            {
                MessageBox.Show("Введите массив в текстовое поле!");
                TB_Massiv.BackColor = Color.Red;
            }
           
        }

        private void TB_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ',') && (e.KeyChar != '.'))// цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
            //запрет ввода разделителя первым символом
            if (textBox.SelectionStart == 0 && ((e.KeyChar == ',') || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
            //после 0 должна быть запятая
            if (textBox.Text == "0")
            {
                if ((e.KeyChar != (char)Keys.Back) && ((e.KeyChar != ',') && (e.KeyChar != '.')))
                {
                    e.Handled = true;
                }
            }
            //ввод только одной запятой
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox.Text.Contains('.') || textBox.Text.Contains(',')))
            {
                e.Handled = true;
            }
        }

        private void TB_Massiv_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            string last = textbox.Text.Split(' ').Last();

            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != ' '))// цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
            //запрет ввода разделителя первым символом
            if (((textbox.SelectionStart == 0)||(textbox.Text.Last()==' ')) && ((e.KeyChar == ',') || (e.KeyChar == '.')))
            {
                e.Handled = true;
            }
            //после 0 должна быть запятая
            if (last == "0")
            {
                if ((e.KeyChar != (char)Keys.Back) && (e.KeyChar != ',') && (e.KeyChar != '.') && (e.KeyChar != ' '))
                {
                    e.Handled = true;
                }
            }
            //ввод только одной запятой
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (last.Contains('.') || last.Contains(',')))
            {
                e.Handled = true;
            }
            //перед пробелом должно быть только число
            if ((e.KeyChar==' ')&&(!Char.IsDigit(last.LastOrDefault())))
            {
                  e.Handled = true;
             
            }
        }
    }
}
