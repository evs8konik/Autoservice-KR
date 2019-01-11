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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView2.Hide();
            dataGridView3.Hide();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосервисDataSet.Запчасти". При необходимости она может быть перемещена или удалена.
            this.запчастиTableAdapter.Fill(this.автосервисDataSet.Запчасти);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосервисDataSet.Информация_об_услугах". При необходимости она может быть перемещена или удалена.
            this.информация_об_услугахTableAdapter.Fill(this.автосервисDataSet.Информация_об_услугах);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автосервисDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.автосервисDataSet.Заказ);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView2.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView3.Show();
        }
    }
}
