using Microsoft.SqlServer.Server;
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

        enum enOpertions { Sum = 1, Sub = 2, Mult = 3, Divide = 4,NotSet = 5};

        float FirstNumber = 0;
        string SecondNumber = "";
        enOpertions Opertion = enOpertions.NotSet;
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

        bool Erorr()
        {
            if (Opertion == enOpertions.NotSet)
            {
                errorProvider1.SetError(btnEqule, "Complete the task then claculate");
                return true;
            }
            else if (Opertion == enOpertions.Divide && SecondNumber == "0")
            {
                errorProvider1.SetError(btnEqule, "You can not divide by zero");
                return true;
            }
            else
            {
                errorProvider1.SetError(btnEqule, "");
                return false;
            }
          
        }


        private void btnEqule_Click(object sender, EventArgs e)
        {

            if (Erorr())
                return;


            Result = Calculate(Opertion);

            byte Numeric = (byte)numericUpDown1.Value;


            txtShowResult.Text += Environment.NewLine;
            txtShowResult.Text += " = " + Result.ToString("F" + Numeric.ToString());


            ListLastCalcullations.Items.Add(txtShowResult.Text);
            lblTotalCalculations.Text = ListLastCalcullations.Items.Count.ToString();

            btnClear.Focus();
        }

        void ClearAll()
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

            btn7.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple calculator application created using C# and Windows Forms.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            ListLastCalcullations.Items.Clear();
        }

        private void BtnRemoveIndex_Click(object sender, EventArgs e)
        {
            if (FirstNumberIsSet == false)
            { 
                txtShowResult.Text = txtShowResult.Text.Remove(txtShowResult.Text.Length - 1);
            }
            else
            {
                SecondNumber = SecondNumber.Remove(SecondNumber.Length - 1);
                txtShowResult.Text = txtShowResult.Text.Remove(txtShowResult.Text.Length - 1);
            }
        }
    }
}
