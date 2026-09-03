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

        float FirstNumber = 0;
        float SecondNumber = 0;
        enOpertions Opertion;
        float Result = 0;
        bool FirstNumberIsSet = false;

        void SetNumbers(Button btn)
        {
            if (FirstNumberIsSet == false)
            {
                FirstNumber = float.Parse(btn.Text);
                FirstNumberIsSet = true;
                txtShowResult.Text = FirstNumber.ToString();
            }
            else
            {
                SecondNumber = float.Parse(btn.Text);
                txtShowResult.Text += SecondNumber.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SetNumbers((Button)sender);
        }

        void SetOperation(RadioButton rb)
        {
            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbSum":
                        Opertion = enOpertions.Sum;
                        txtShowResult.Text += " " + "+" + " ";
                        break;
                    case "rbSub":
                        Opertion = enOpertions.Sub;
                        txtShowResult.Text += " " + "-" + " ";
                        break;
                    case "rbMult":
                        Opertion = enOpertions.Mult;
                        txtShowResult.Text += " " + "X" + " ";
                        break;
                    case "rbDiv":
                        Opertion = enOpertions.Divide;
                        txtShowResult.Text += " " + "/" + " ";
                        break;
                }
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            SetOperation((RadioButton)sender);
        }

        float Calculate(enOpertions Opertion)
        {
            switch (Opertion)
            {
                case enOpertions.Sum:
                    Result = FirstNumber + SecondNumber;
                    break;
                case enOpertions.Sub:
                    Result = FirstNumber - SecondNumber;
                    break;
                case enOpertions.Mult:
                    Result = FirstNumber * SecondNumber;
                    break;
                case enOpertions.Divide:
                    Result = FirstNumber / SecondNumber;
                    break;
            }

            return Result;
        }

        private void btnEqule_Click(object sender, EventArgs e)
        {
            Result = Calculate(Opertion);

            txtShowResult.Text += Environment.NewLine;
            txtShowResult.Text += Result.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtShowResult.Clear();

            FirstNumber = 0;
            SecondNumber = 0;
            Result = 0;

            FirstNumberIsSet = false;

            rbSum.Checked = false;
            rbSub.Checked = false;
            rbMult.Checked = false;
            rbDiv.Checked = false;
        }


    }
}
