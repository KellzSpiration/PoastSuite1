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
    public partial class ssecondIterationQ1 : ContentPage
    {
        private double p;
        public ssecondIterationQ1(double score)
        {
            InitializeComponent();
            p = score;
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
                    Program.SolveFx(parameter);
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

                        Program.SolveFx(parameter);
                    }

                    else if (parameter.lowerFx == parameter.bestPoint)
                    {
                        //  Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.lowerx, parameter.y);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.lowerx;
                        parameter.THy = parameter.y;
                        Program.SolveFx(parameter);

                    }

                    else if (parameter.upperFy == parameter.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.xF, parameter.uppery);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.xF;
                        parameter.THy = parameter.uppery;

                        Program.SolveFx(parameter);
                    }

                    else if (parameter.lowerFy == parameter.bestPoint)
                    {
                        // Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter.xF, parameter.lowery);
                        parameter.h1 = parameter.h1 / 2;
                        parameter.h2 = parameter.h2 / 2;
                        parameter.THx = parameter.xF;
                        parameter.THy = parameter.lowery;

                        Program.SolveFx(parameter);
                    }
                }
                parameter.i++;
            }

            int a;
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX2.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX2.Text) - parameter.UpFX[1]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty008 = string.IsNullOrEmpty(LowFX2.Text);
            if (isEntryEmpty008)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX2.Text) - parameter.LowFX[1]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty009 = string.IsNullOrEmpty(UpFY2.Text);
            if (isEntryEmpty009)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY2.Text) - parameter.UpFY[1]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty010 = string.IsNullOrEmpty(LowFY2.Text);
            if (isEntryEmpty010)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY2.Text) - parameter.LowFY[1]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty011 = string.IsNullOrEmpty(Th2.Text);
            if (isEntryEmpty011)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th2.Text) - parameter.TFunct[1]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty012 = string.IsNullOrEmpty(Bp2.Text);
            if (isEntryEmpty012)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp2.Text) - parameter.Function[1]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c+p;
           // double score2 = Math.Round((((Math.Round((T / 6 * 100) * 2) / 2) + p) / 2)*2)/2;

            double score2 = T;
            // Bp2.Text = score2.ToString();
            await Navigation.PushModalAsync(new ThirdIterationQ1(score2));



        }
    }
}  