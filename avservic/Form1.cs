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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void регистрацияКлиентовToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form2 twoForm = new Form2();
            twoForm.ShowDialog();
            Close();
        }

        private void пользовательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form3 wForm = new Form3();
            wForm.ShowDialog();
            Close();
        }
    }
}
