using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace N11310020
{
    public partial class FFFFFF : Form
    {
        public FFFFFF()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double a = Int32.Parse(textBox1.Text);
            label3.Text = ((a*9/5)+32).ToString();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
