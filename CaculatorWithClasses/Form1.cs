using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculatorWithClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        readonly Addition Addition = new Addition();

        readonly Variables Variables = new Variables();

        readonly Subtract Subtract = new Subtract();

        readonly Division Division = new Division();

        readonly Multiply Multiply = new Multiply();


        public void Numbers()
        {

            if (TxBoxNumber1.Text=="" || TxBoxNumber2.Text=="")
            {
                MessageBox.Show("Please enter the numbers");

                LblResult.Text="Result";
            }
            else
            {
                Variables.ValueFirst = int.Parse(TxBoxNumber1.Text);

                Variables.ValueSecond = int.Parse(TxBoxNumber2.Text);
            }      
               
        }

        public void Add()
        {

            Numbers();
            LblResult.Text=Convert.ToString(Addition.Add(Variables));

        }

        public void Sub()
        {

            Numbers();

            LblResult.Text = Convert.ToString(Subtract.Sub(Variables));

         
        }

        public void Div()
        {
            Numbers();

            LblResult.Text = Convert.ToString(Division.Div(Variables));
        }

        public void Mult()
        {
            Numbers();
            LblResult.Text = Convert.ToString(Multiply.Mul(Variables));
        }

        private void BtnAddition_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            Sub();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            Div();
        }

        private void BtnMultply_Click(object sender, EventArgs e)
        {
            Mult();
        }
    }
}
