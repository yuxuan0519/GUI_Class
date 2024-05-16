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
    public partial class FormGame : Form
    {

        int min=0, max=100;
        int result;
        public FormGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.result = r.Next(100);
            MessageBox.Show(result.ToString());
            label1.Text = "以隨機產生0~100的數字，請在下方作答";
            label2.Text =string.Format("請輸入{0}~{1}之間的數值",min,max);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int input = Int32.Parse(textBox7.Text);
                if (input == this.result)
                {
                    MessageBox.Show("恭喜答對");
                }
                else if (input < this.result)
                {
                    this.min= input;
                }
                else if (input > this.result)
                {
                    this.max= input;
                }
                label2.Text = string.Format("請輸入{0}~{1}之間的數值", min, max);

            }
            catch (Exception e1)
            {
                MessageBox.Show("輸入錯誤，請輸入數字");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
