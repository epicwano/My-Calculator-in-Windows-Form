using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enOpertions { Sum = 1, Sub = 2, Mult = 3, Divide = 4};

        float FirstNumber;
        float SecondNumber;
        enOpertions Opertion;





    }
}
