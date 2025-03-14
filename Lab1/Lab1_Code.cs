using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_05._03._Serebryakov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Перемнная для повторного использования
        bool proverka = false;

        private void button1_Click(object sender, EventArgs e)
        {
            // Переключение состояния формы 
            proverka = !proverka;
            // Форма в состоянии проверки
            if (proverka)
            {
                button1.Text = "Начать снова";
                // Забираем из textBox введенные данные
                string text1, text2, text3;
                text1 = (string)textBox1.Text;
                text2 = (string)textBox2.Text;
                text3 = (string)textBox3.Text;
                // Делаем textBox невидимыми
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                // Пытаемся обработать введенные данные и проверить треугольник
                try
                {
                    // Конвертируем введенные данные в целые числа
                    int first_num, second_num, third_num;
                    first_num = Convert.ToInt32(text1);
                    second_num = Convert.ToInt32(text2);
                    third_num = Convert.ToInt32(text3);
                    // Проверка существования треугольника
                    if ((first_num + third_num > second_num) && (third_num + second_num > first_num) && (first_num + second_num > third_num))
                        // Проверка на равносторонний треугольника
                        if (first_num == second_num && second_num == third_num)
                            label1.Text = "Полученный треугольник \n равносторонний";
                        // Проверка на равнобедренный треугольника
                        else if (first_num == third_num || second_num == third_num || first_num == second_num)
                            label1.Text = "Полученный треугольник \n равнобедренный";
                        // Если 2 предыдущие проверки треугольник не прошел, значит он разносторонний
                        else
                            label1.Text = "Полученный треугольник \n разносторонний";
                    // Если треугольника не существует
                    else
                        label1.Text = "Полученный треугольник \n не существует";
                }
                // Если введены не корректные данные, то выводим сообщение об этом
                catch
                {
                    label1.Text = "Произошла ошибка.\n Введены некорректные данные";
                }
            }
            // Если была нажата кнопка "Начать заново"
            else
            {
                // Делаем textBox видимыми
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                // Очищаем поля textBox
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label1.Text = "Введите длины сторон треугольника";
                button1.Text = "Проверить";
            }

        }
    }
}
