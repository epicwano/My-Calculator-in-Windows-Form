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
        string SecondNumber = "";
        enOpertions Opertion;
        float Result = 0;
        bool FirstNumberIsSet = false;

        void SetNumbers(Button btn)
        {
            if (FirstNumberIsSet == false)
            {
                txtShowResult.Text += btn.Tag.ToString();
            }
            else
            {
                SecondNumber += btn.Tag.ToString();
                txtShowResult.Text += btn.Tag.ToString();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            SetNumbers((Button)sender);
        }

        void SetOperation(RadioButton rb)
        {

            if (FirstNumberIsSet == false)
            {

                if (!string.IsNullOrEmpty(txtShowResult.Text))
                {
                    FirstNumber = float.Parse(txtShowResult.Text);
                    FirstNumberIsSet = true;
                }
                else
                {
                    MessageBox.Show("You Must Enter a Number First");
                    rb.Checked = false;
                    return;
                }    
            }


            if (rb.Checked)
            {
                switch (rb.Name)
                {
                    case "rbSum":
                        Opertion = enOpertions.Sum;
                        break;
                    case "rbSub":
                        Opertion = enOpertions.Sub;
                        break;
                    case "rbMult":
                        Opertion = enOpertions.Mult;
                        break;
                    case "rbDiv":
                        Opertion = enOpertions.Divide;
                        break;
                }

                txtShowResult.Text = FirstNumber.ToString() + " " + rb.Tag.ToString() + " ";
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
                    Result = FirstNumber + float.Parse(SecondNumber);
                    break;
                case enOpertions.Sub:
                    Result = FirstNumber - float.Parse(SecondNumber);
                    break;
                case enOpertions.Mult:
                    Result = FirstNumber * float.Parse(SecondNumber);
                    break;
                case enOpertions.Divide:
                    Result = FirstNumber / float.Parse(SecondNumber);
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
            rbSum.Checked = false;
            rbSub.Checked = false;
            rbMult.Checked = false;
            rbDiv.Checked = false;

            txtShowResult.Clear();

            FirstNumber = 0;
            SecondNumber = "";
            Result = 0;

            FirstNumberIsSet = false;
        }


    }
}
