using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseElev
{
    class Elev
    {
        public int inaltimea;
        public string Nume;
        public void SuntEu()
        {
            MessageBox.Show("Inaltimea mea este " + inaltimea + " cm",  Nume +" spune" );   
        }
    }
}
