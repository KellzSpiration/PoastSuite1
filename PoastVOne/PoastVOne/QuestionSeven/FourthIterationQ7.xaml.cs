﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionSeven
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FourthIterationQ7 : ContentPage
    {
        private double r;
        public FourthIterationQ7(double score3)
        {
            InitializeComponent();
            r = score3;
        }

        async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            {
                var parameter6 = new Parameter6(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

                parameter6.f = 9 * Math.Pow(parameter6.x, 2) - (2 * (parameter6.x * parameter6.y)) + 6 * Math.Pow(parameter6.y, 2) + (1 * parameter6.x) + (2 * parameter6.y);
                Console.WriteLine("f(0,0) = {0}", parameter6.f);
                int Max = 0;

                while (parameter6.h1 >= parameter6.h1F && parameter6.h2 >= parameter6.h2F && Max < 5)
                {

                    if (parameter6.bestPoint > parameter6.THf)
                    {
                        Program6.SolveFx(parameter6);
                    }
                    else
                    {
                        if (parameter6.upperFx == parameter6.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter6.upperx, parameter6.y);
                            parameter6.h1 = parameter6.h1 / 2;
                            parameter6.h2 = parameter6.h2 / 2;
                            parameter6.THxx = parameter6.upperx;
                            parameter6.THyy = parameter6.y;

                            Program6.SolveFx(parameter6);
                        }

                        else if (parameter6.lowerFx == parameter6.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter6.lowerx, parameter6.y);
                            parameter6.h1 = parameter6.h1 / 2;
                            parameter6.h2 = parameter6.h2 / 2;
                            parameter6.THxx = parameter6.lowerx;
                            parameter6.THyy = parameter6.y;
                            Program6.SolveFx(parameter6);

                        }

                        else if (parameter6.upperFy == parameter6.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter6.xF, parameter6.uppery);
                            parameter6.h1 = parameter6.h1 / 2;
                            parameter6.h2 = parameter6.h2 / 2;
                            parameter6.THxx = parameter6.xF;
                            parameter6.THyy = parameter6.uppery;

                            Program6.SolveFx(parameter6);
                        }

                        else if (parameter6.lowerFy == parameter6.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter6.xF, parameter6.lowery);
                            parameter6.h1 = parameter6.h1 / 2;
                            parameter6.h2 = parameter6.h2 / 2;
                            parameter6.THxx = parameter6.xF;
                            parameter6.THyy = parameter6.lowery;

                            Program6.SolveFx(parameter6);
                        }
                    }
                    parameter6.i++;
                    Max++;
                }
                int a;
                bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX4.Text);
                if (isEntryEmpty007)
                {
                    a = 0;
                }
                else if (Math.Abs(double.Parse(UpFX4.Text) - parameter6.UpFX[3]) <= 0.05)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }


                int a1;
                bool isEntryEmpty008 = string.IsNullOrEmpty(LowFX4.Text);
                if (isEntryEmpty008)
                {
                    a1 = 0;
                }
                else if (Math.Abs(double.Parse(LowFX4.Text) - parameter6.LowFX[3]) <= 0.05)
                {
                    a1 = 1;
                }
                else
                {
                    a1 = 0;
                }


                int a2;
                bool isEntryEmpty009 = string.IsNullOrEmpty(UpFY4.Text);
                if (isEntryEmpty009)
                {
                    a2 = 0;
                }
                else if (Math.Abs(double.Parse(UpFY4.Text) - parameter6.UpFY[3]) <= 0.05)
                {
                    a2 = 1;
                }
                else
                {
                    a2 = 0;
                }

                int a3;
                bool isEntryEmpty010 = string.IsNullOrEmpty(LowFY4.Text);
                if (isEntryEmpty010)
                {
                    a3 = 0;
                }
                else if (Math.Abs(double.Parse(LowFY4.Text) - parameter6.LowFY[3]) <= 0.05)
                {
                    a3 = 1;
                }
                else
                {
                    a3 = 0;
                }

                int b;
                bool isEntryEmpty011 = string.IsNullOrEmpty(Th4.Text);
                if (isEntryEmpty011)
                {
                    b = 0;
                }
                else if (Math.Abs(double.Parse(Th4.Text) - parameter6.TFunct[3]) <= 0.05)
                {
                    b = 1;
                }
                else
                {
                    b = 0;
                }

                int c;
                bool isEntryEmpty012 = string.IsNullOrEmpty(Bp4.Text);
                if (isEntryEmpty012)
                {
                    c = 0;
                }
                else if (Math.Abs(double.Parse(Bp4.Text) - parameter6.Function[3]) <= 0.05)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }

                double T = a + a1 + a2 + a3 + b + c + r;
                //  double score4 =(( Math.Round((T / 6 * 100) * 2) / 2)+r)/2;
                // double score4 = Math.Round((((Math.Round((T / 6 * 100) * 2) / 2) + r) / 2) * 2) / 2;
                double score4 = T;

                // Bp4.Text = score4.ToString();
                await Navigation.PushModalAsync(new FifthIterationQ7(score4));

            }
        }
    }
}