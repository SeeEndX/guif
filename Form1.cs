using System;
using System.Windows.Forms;

namespace guif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SumForRub.Text = Properties.Settings.Default.SumForRub;
        }
        public string func(int p)
        {
            string result = "";
            if (p < 1)
            {
                result = "Цена не может быть меньше 1 копейки!";
                MessageBox.Show(result);
            }
            else if (p > 9999)
            {
                result = "Цена слишком высокая, не удовлетворяет условию задачи!";
                MessageBox.Show(result);
            }
            else
            {
                if (p % 10 == 0) result = "Товар стоит " + p / 100 + " руб";
                if (p / 100 == 1 || (p / 100) % 10 == 1 && p / 1000 != 1) result = "Товар стоит " + p / 100 + " руб" + "ль ";
                else if (p / 100 == 2 || p / 100 == 3 || p / 100 == 4 || (p / 100) % 10 == 2 || (p / 100) % 10 == 3 || (p / 100) % 10 == 4)
                {
                    if (p / 100 == 1 || p / 1000 == 1) result = "Товар стоит " + p + " руб" + "лей ";
                    else result = "Товар стоит " + p / 100 + " руб" + "ля ";
                }
                else if (p % 1000 == 200 || p % 1000 == 300 || p % 1000 == 400)
                    result = "Товар стоит " + p / 100 + " руб" + "ля ";
                else result = "Товар стоит " + p / 100 + " руб" + "лей ";
                if (p % 100 == 0) MessageBox.Show(result);
                else
                {
                    result = result + p % 100 + " копе";
                    if (p % 10 == 1 && p % 100 != 11)
                        result = result + "йка";
                    else if ((p % 10 == 2 || p % 10 == 3 || p % 10 == 4) && p % 100 / 10 != 1)
                        result = result + "йки";
                    else result = result + "ек";
                    MessageBox.Show(result);
                }
            }
            return result;
        }

        private void Count_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SumForRub = this.SumForRub.Text;
            Properties.Settings.Default.Save();
            int p = int.Parse(this.SumForRub.Text);
            func(p);
        }

        private void Clear_Click(object sender, EventArgs e)
        { 
            this.SumForRub.Text = "";
        }

        private void Task_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дано натуральное число 1≤n≤9999, определяющее стоимость товара в копейках. Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т.п.");
        }
    }
}
