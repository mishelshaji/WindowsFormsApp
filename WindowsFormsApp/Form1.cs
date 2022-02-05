using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private int _number1;
        private int _number2;
        private string _operator;

        public Form1()
        {
            InitializeComponent();
            btnZero.Click += ButtonNumber_Click;
            btnOne.Click += ButtonNumber_Click;
            btnTwo.Click += ButtonNumber_Click;
            btnThree.Click += ButtonNumber_Click;
            btnFour.Click += ButtonNumber_Click;
            btnFive.Click += ButtonNumber_Click;
            btnSix.Click += ButtonNumber_Click;
            btnSeven.Click += ButtonNumber_Click;
            btnEight.Click += ButtonNumber_Click;
            btnNine.Click += ButtonNumber_Click;

            btnAdd.Click += ButtonOperator_Click;
            btnSub.Click += ButtonOperator_Click;
            btnMul.Click += ButtonOperator_Click;
            btnDiv.Click += ButtonOperator_Click;

            btnEql.Click += BtnEql_Click;

            btnClear.Click += BtnClear_Click;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _number1 = 0;
            _number2 = 0;
            _operator = default;
            txtScreen.Text = "0";
        }

        private void BtnEql_Click(object sender, EventArgs e)
        {
            _number2 = Convert.ToInt32(txtScreen.Text);
            switch (_operator)
            {
                case "+":
                    txtScreen.Text = (_number1 + _number2).ToString();
                    break;
                case "-":
                    txtScreen.Text = (_number1 - _number2).ToString();
                    break;
                case "*":
                    txtScreen.Text = (_number1 * _number2).ToString();
                    break;
                default:
                    txtScreen.Text = (_number1 / _number2).ToString();
                    break;
            }
        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            _operator = btn.Text;
            _number1 = Convert.ToInt32(txtScreen.Text);
            txtScreen.Text = "0";
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            txtScreen.Text = txtScreen.Text == "0"? btn.Text: txtScreen.Text + btn.Text;
        }
    }
}
