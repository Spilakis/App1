using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using App1;

namespace Calculator
{
    [Activity(Label = "Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
      
        protected override void OnCreate(Bundle bundle)
        {
            //Display the result of the calculation
            double resultvalue = 0;
            //Display and excute code relevant to user's choice
            string operatorUsed = "";

            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main1);

            //Numerical Keypads
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);
            Button button9 = FindViewById<Button>(Resource.Id.button9);
            Button button0 = FindViewById<Button>(Resource.Id.button0);
            

            //Mathematical operators
            Button Add = FindViewById<Button>(Resource.Id.Add);
            Button Minus = FindViewById<Button>(Resource.Id.Minus);
            Button Divide = FindViewById<Button>(Resource.Id.Divide);
            Button Multiply = FindViewById<Button>(Resource.Id.Multiply);
            Button Dec = FindViewById<Button>(Resource.Id.Dec);

            //Commands
            Button Clear = FindViewById<Button>(Resource.Id.Clear);
            Button Equals = FindViewById<Button>(Resource.Id.Enter);
    
            //output
            TextView Textview1 = FindViewById<TextView>(Resource.Id.textView1);

            //INPUT NUMBERS
            //Number1
            button1.Click += delegate
            {
                Textview1.Text = Textview1.Text + button1.Text;
            };
            //Number 2
            button2.Click += delegate
            {
                Textview1.Text = Textview1.Text + button2.Text;
            };
            //Number 3
            button3.Click += delegate
            {
                Textview1.Text = Textview1.Text + button3.Text;
            };
            //Number 4
            button4.Click += delegate
            {
                Textview1.Text = Textview1.Text + button4.Text;
            };
            //Number 5
            button5.Click += delegate
            {
                Textview1.Text = Textview1.Text + button5.Text;
            };
            //Number 6
            button6.Click += delegate
            {
                Textview1.Text = Textview1.Text + button6.Text;
            };
            //Number 7
            button7.Click += delegate
            {
                Textview1.Text = Textview1.Text + button7.Text;
            };
            //Number 8
            button8.Click += delegate
            {
                Textview1.Text = Textview1.Text + button8.Text;
            };
            //Number 9
            button9.Click += delegate
            {
                Textview1.Text = Textview1.Text + button9.Text;
            };
            //Number 0
            button0.Click += delegate
            {
                Textview1.Text = Textview1.Text + button0.Text;
            };

            //INPUT MATHEMATICAL OPERATIONS
            //Addition
            Add.Click += delegate
            {
                Textview1.Text = Textview1.Text + Add.Text;
                operatorUsed = Add.Text;
                resultvalue = double.Parse(Textview1.Text);
            };
            //Minus
            Minus.Click += delegate
            {
                Textview1.Text = Textview1.Text + Minus.Text;
            };
            //Multiplication
            Multiply.Click += delegate
            {
                Textview1.Text = Textview1.Text + Multiply.Text;
            };
            //Divide
            Divide.Click += delegate
            {
                Textview1.Text = Textview1.Text + Divide.Text;
            };
            //Decimal point
            Dec.Click += delegate
            {
                Textview1.Text = Textview1.Text + Dec.Text;
            };

            //INPUT COMMANDS
            //Clear
            Clear.Click += delegate
            {
                //reset input to nothing
                Textview1.Text = Textview1.Text = "";
            };
            //Enter
            Equals.Click += delegate
            {
                switch(operatorUsed)
                {
                    //To solve Addition
                    case "+":
                        Textview1.Text = (resultvalue + double.Parse(Textview1.Text)).ToString();
                        break;
                    //To solve Subtraction
                    case "-":
                        Textview1.Text = (resultvalue + double.Parse(Textview1.Text)).ToString();
                        break;
                    //To solve Multipcation
                    case "*":
                        Textview1.Text = (resultvalue + double.Parse(Textview1.Text)).ToString();
                        break;
                    //To solve Division
                    case "/":
                        Textview1.Text = (resultvalue + double.Parse(Textview1.Text)).ToString();
                        break;
                }
            };

        }
        

        }
    }


