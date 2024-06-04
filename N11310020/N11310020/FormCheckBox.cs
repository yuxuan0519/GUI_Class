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

namespace N11310020
{ 
    public partial class FormCheckBox : Form
    {
     public FormCheckBox()
        {
        InitializeComponent();
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
            foreach (Control c in panel2.Controls)
            {
                if (c is CheckBox)
                {
                    CheckBox chk = (CheckBox)c;
                    if (chk.Checked)
                    {
                        MessageBox.Show(chk.Text);
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
                    MessageBox.Show(chk.Text);
                }
            }
        }
    }


}
} 


