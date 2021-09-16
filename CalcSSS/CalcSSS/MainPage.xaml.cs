using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcSSS
{
    public partial class MainPage : ContentPage
    {
        int currentstate = 1;
        string MathOperator;
        double firstNum, secondNum;

        

        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }

             void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            if(this.resultText.Text=="0" || currentstate < 0)
            {
                this.resultText.Text = "";

                if (currentstate < 0)
                    currentstate *= -1;
            }
            this.resultText.Text += pressed;
            double Num;
            if (double.TryParse(this.resultText.Text, out  Num))
            {
                this.resultText.Text = Num.ToString();
                if (currentstate == 1)
                {
                    firstNum = Num;
                }
                else
                {
                    secondNum = Num;
                }
            }
        }
        

        void OnClear(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            currentstate = 1;
            this.resultText.Text = "0";
            
        }
       
        void OnSelectOperator(object sender, EventArgs e)
        {
            currentstate = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            MathOperator = pressed;
        }
        void OnCalculate(object sender, EventArgs e)
        {
            if (currentstate == 2)
            {
                var result = MOperator.Calculate(firstNum, secondNum, MathOperator);
                this.resultText.Text = result.ToString();
                firstNum = result;
                currentstate = -1;
               

            }

        }
    }
}
