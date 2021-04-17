using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionOne
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstIterationQ1 : ContentPage
    {
        public FirstIterationQ1()
        {
            InitializeComponent();
        }

        async void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter = new Parameter(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter.f = 3 * Math.Pow(parameter.x, 2) - (2 * (parameter.x * parameter.y)) + Math.Pow(parameter.y, 2) + (4 * parameter.x) + (3 * parameter.y);
           // Console.WriteLine("f(0,0) = {0}", parameter.f);
            while (parameter.h1 >= parameter.h1F && parameter.h2 >= parameter.h2F)
            {

                if (parameter.bestPoint > parameter.THf)
                {
                    Program5.SolveFx(parameter);
                }
                else
                {
                    if (parameter.upperFx == parameter.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.upperx, parameter.y);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.upperx;
                        parameter.THy = parameter.y;

                        Program5.SolveFx(parameter);
                    }

                    else if (parameter.lowerFx == parameter.bestPoint)
                    {
                        //  Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.lowerx, parameter.y);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.lowerx;
                        parameter.THy = parameter.y;
                        Program5.SolveFx(parameter);

                    }

                    else if (parameter.upperFy == parameter.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.xF, parameter.uppery);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.xF;
                        parameter.THy = parameter.uppery;

                        Program5.SolveFx(parameter);
                    }

                    else if (parameter.lowerFy == parameter.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.xF, parameter.lowery);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.xF;
                        parameter.THy = parameter.lowery;

                        Program5.SolveFx(parameter);
                    }
                }
                parameter.i++;
                
            }

            int a;
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX1.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse( UpFX1.Text)- parameter.UpFX[0]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty002 = string.IsNullOrEmpty(LowFX1.Text);
            if (isEntryEmpty002)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX1.Text) - parameter.LowFX[0]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty003 = string.IsNullOrEmpty(UpFY1.Text);
            if (isEntryEmpty003)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY1.Text) - parameter.UpFY[0]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty004 = string.IsNullOrEmpty(LowFY1.Text);
            if (isEntryEmpty004)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY1.Text) - parameter.LowFY[0]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty005 = string.IsNullOrEmpty(Th1.Text);
            if (isEntryEmpty005)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th1.Text) - parameter.TFunct[0]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty006 = string.IsNullOrEmpty(Bp1.Text);
            if (isEntryEmpty006)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp1.Text)- parameter.Function[0])<= 0.05)
            {
                c= 1;
            }
            else
            {
                c= 0;    
            }

            double T = a + a1 + a2 + a3 + b + c;
            // double score = Math.Round((T / 6 * 100) * 2) / 2;
            double score = T;

           // Bp1.Text = score.ToString();
           await Navigation.PushModalAsync(new ssecondIterationQ1 (score));


        }
    }
}