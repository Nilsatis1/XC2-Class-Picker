using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XC2_Class_Picker
{
    public partial class SoldierBuilder : Form
    {
        private string name;
        private int aim;
        private int health;
        private int dodge;
        private int mobility;
        private int hacking;
       
        public SoldierBuilder()
        {
            InitializeComponent();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            this.name = txtName.Text;
            this.health = int.Parse(txtHealth.Text);
            this.aim = int.Parse(txtAim.Text);
            this.mobility = int.Parse(txtMobility.Text);
            this.hacking = int.Parse(txtHack.Text);
            this.dodge = int.Parse(txtDodge.Text);
            
            string txtResult;
            if (aim >= 70)
            {
                txtResult = string.Format("Train {0} as a: DFA SNIPER", name);
            }
            else if (aim >= 65 && mobility >= 15)
            {
                txtResult = string.Format("Train {0} as a: SHOOTY RANGER or SHOOTY SHINOBI", name);
            }
            else if (aim  >= 65 && mobility >= 12 && mobility < 15)
            {
                txtResult = String.Format("Train {0} as either a: SHOOTY GUNNER > STUNNER ASSAULT > OVERWATCH RANGER > ROCKET TECHNICAL", name);
            }
            else if (aim >= 65 && dodge >= 5 && health >= 5)
            {
                txtResult = string.Format("Train {0} as a: SUPRESION GUNNER.", name);
            }
            else if (aim >= 65 && hacking >= 8)
            {
                txtResult = string.Format("Train {0} as a: OVERWATCH SPECIALIST.", name);
            }
            else if (aim >= 60 && aim < 65 && mobility >= 14 && mobility < 16)
            {
                txtResult = string.Format("Train {0} as a: BLADE SHINOBI.", name);
            }
            else if (aim  >= 60 && aim < 65 && mobility == 14 && mobility == 15 && health >= 4 && dodge >= 1)
            {
                txtResult = String.Format("Train {0} as a: KILLER INSTINCT ASSAULT", name);  
            }
            else if (aim >= 60 && aim < 65 && mobility >= 16 && health >= 4 && dodge >= 1)
            {
                txtResult = String.Format("Train {0} as a: BREACHER ASSAULT or FLAME TECHNICAL", name);
            }
            else if (aim  >= 55 && aim < 65 && hacking >= 8)
            {
                txtResult = String.Format("Train {0} as a: SUPPORT SPECIALIST", name);
            }
            else if (aim  >= 55 && aim < 60 && mobility >= 14)
            {
                txtResult = String.Format("Train {0} as a: DAMAGE OR SUPPORT GRENADIER", name);
            }
            else
            {
                txtResult = String.Format("Train {0} as a: STEALTH SHINOBI", name);
                
            }
            this.Hide();
            Resultform resultForm = new Resultform(txtResult, name);
            
            resultForm.Show();
        }

        private void SoldierBuilder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void classBuilder_TextChanged(object sender, EventArgs e)
        {
            string classTxt = classBuilder.Text;
            this.Hide();
            SKPform sKPform = new SKPform(classTxt);
            sKPform.Show();
            

        }
    }
}
