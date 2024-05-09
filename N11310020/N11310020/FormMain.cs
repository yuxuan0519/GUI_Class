using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310020
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form = new FormButton();
            form.Show();
        }

        private void bntTextBox_Click(object sender, EventArgs e)
        {
            Form formTextBox = new FormTextBox();
            formTextBox.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FFFFFF = new FFFFFF();
            FFFFFF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new FormGame();
            form.Show();
        }
    }
}
