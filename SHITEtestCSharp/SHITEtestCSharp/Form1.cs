using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class SHITEmenu
{

    public string variable_1;

    private void cmdWaht_Click(object sender, EventArgs e)
    {
        Waht_is_it.Show();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
        string Quitter;
        Quitter = MsgBox("Are you sure that you don\'t want to take the SHITE test, you can come back and do it at anytime", vbYesNo);
        if ((Quitter == System.Windows.Forms.MessageBoxButtons.Yes))
        {
            this.Close();
        }

    }

    private void cmdTakeIt_Click(object sender, EventArgs e)
    {
        Gender.Show();
        this.Hide();
    }

    private void Label1_Click(object sender, EventArgs e)
    {
        if ((FemaleTest.Score > 0))
        {
            LBLScored.Text = ("Your previous score in the SHITE test was: " + FemaleTest.Score);
        }

    }

    private void SHITEmenu_Load(object sender, EventArgs e)
    {
    }
}