using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XC2_Class_Picker
{
    public partial class Resultform : Form
    {   // This is how to send different images to the form
        public Resultform(string txtResult, string name)
        {
            InitializeComponent();
            txtClass.Text = txtResult;
            txtClass.SelectionAlignment = HorizontalAlignment.Center;
            if (txtResult == "Train " + name + " as a: STEALTH SHINOBI")
            {
                alienPic.Image = Properties.Resources.Shenobi;
            }
            else if (txtResult == "Train " + name + " as a: DAMAGE OR SUPPORT GRENADIER")
            {
                alienPic.Image = Properties.Resources.Grenadier;
            }
            else if (txtResult == "Train " + name + " as a: SUPPORT SPECIALIST")
            {
                alienPic.Image = Properties.Resources.Specialist;
            }
            else if (txtResult == "Train " + name + " as a: BREACHER ASSAULT")
            {
                alienPic.Image = Properties.Resources.Assault;
            }

        }

        private void Resultform_FormClosed(object sender, FormClosedEventArgs e)
        {
            SoldierBuilder builder = new SoldierBuilder();
            builder.Show();
        }

        


    }
}
