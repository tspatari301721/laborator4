using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseElev
{
    public partial class Form1 : Form
    {
        Elev Alex;
        Elev Elena;

        public Form1()
        {
            InitializeComponent();
            Alex = new Elev() { Nume = "Alex", inaltimea = 180 };
            Elena = new Elev() { Nume = "Elena", inaltimea = 176 };
        }

        private void btAlex_Click(object sender, EventArgs e)
        {
            Alex.SuntEu();
        }

        private void btElena_Click(object sender, EventArgs e)
        {
            Elena.SuntEu();
        }

        private void btChange_Click(object sender, EventArgs e)
        {

            Elev adauga;
            adauga = Alex;
            Alex = Elena;
            Elena = adauga;
            MessageBox.Show("S-au schimbat datele");
        }
    }
}
