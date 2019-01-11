using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avservic
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосервисDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.автосервисDataSet.Клиент);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
                MessageBox.Show("Не удалось зарегистрироваться возможно данные введены некорректно или не все поля были заполнены");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            автосервисDataSet.КлиентRow nrow = (автосервисDataSet.КлиентRow)автосервисDataSet.Клиент.NewRow();


            if (textBox1.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox5.Text.Length > 0 && textBox6.Text.Length>0)
            {
                if (textBox1.Text != "A-Z")
                {
                    nrow.Фамилия = textBox1.Text;
                    nrow.Имя = textBox2.Text;
                    nrow.Отчетсво = textBox3.Text;
                    nrow.Марка_машины = textBox4.Text;

                    nrow.Номерной_знак = textBox5.Text;
                    nrow.Контактный_телефон = (textBox6.Text);

                    автосервисDataSet.Клиент.AddКлиентRow(nrow);


                    this.клиентTableAdapter.Update(this.автосервисDataSet.Клиент);

                    MessageBox.Show("Вы успешно зарегистрировались");
                }

            }


            else
                MessageBox.Show("Не удалось зарегистрироваться возможно данные введены некорректно или не все поля были заполнены");

            dataGridView1.Show();
            

}
        }
    }

