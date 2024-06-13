using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace N11310020
{ 
    public partial class FormCheckBox : Form
    {
     public FormCheckBox()
        {
        InitializeComponent();

            if (!File.Exists("OrderDate.csv"))
                File.WriteAllText("OrderDate.csv", "時間,主食,配餐\n", Encoding.UTF8);
         }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
            MessageBox.Show("方塊已被按下");
        else
            MessageBox.Show("方塊已被取消");

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void checkBox7_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
            String a = "", b = "";

            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        a += chk.Text + " ";
                        //MessageBox.Show(chk.Text);
                    }
                }
            }
            foreach (Control c in panel3.Controls)
            {
            if (c is CheckBox)
            {
                CheckBox chk = (CheckBox)c;
                if (chk.Checked)
                {
                        b += chk.Text + " ";
                        //MessageBox.Show(chk.Text);
                }
            }
        }
            a = a.Remove(a.Length - 1, 1);
            b = b.Remove(b.Length - 1, 1);

            DateTime d=DateTime.Now;
            string orderTime = d.ToString("yyy/MM/dd HH:mm:ss");

            File.AppendAllText("OrderDate.csv", orderTime+","+ a+","+b);
            MessageBox.Show("主餐:" + a+ "\n飲料:" + b);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 


