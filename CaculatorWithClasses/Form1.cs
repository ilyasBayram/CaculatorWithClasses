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

        readonly Addition addition = new Addition();

        readonly Variables variables = new Variables();

        readonly Subtract subtract = new Subtract();

        readonly Division division = new Division();

        readonly Multiply multiply = new Multiply();


        ICalculation calculation = new Subtract();

        CalculationManagement total = new CalculationManagement();

    

        


        public void Numbers()
        {

            if (TxBoxNumber1.Text=="" || TxBoxNumber2.Text=="")
            {
                MessageBox.Show("Please enter the numbers");

                LblResult.Text="Result";
            }
            else
            {
                variables.ValueFirst = int.Parse(TxBoxNumber1.Text);

                variables.ValueSecond = int.Parse(TxBoxNumber2.Text);
            }      
               
        }

        public void Add()
        {

            Numbers();
            LblResult.Text = Convert.ToString(addition.Calculate(variables));

            
        }

        public void Sub()
        {

            Numbers();

            LblResult.Text = Convert.ToString(total.TopCalculate(subtract, variables));

         
        }

        public void Div()
        {
            Numbers();

            LblResult.Text = Convert.ToString(variables.Result);
        }

        public void Mult()
        {
            Numbers();
            LblResult.Text = Convert.ToString(total.TopCalculate(multiply,variables));
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
