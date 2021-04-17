﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionEight
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstIterationQ8 : ContentPage
    {
        public FirstIterationQ8()
        {
            InitializeComponent();
        }

        async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            {
                var parameter7 = new Parameter7(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

                parameter7.f = 6 * Math.Pow(parameter7.x, 2) - (9 * (parameter7.x * parameter7.y)) + 4 * Math.Pow(parameter7.y, 2) + (2 * parameter7.x) + (2 * parameter7.y);
                Console.WriteLine("f(0,0) = {0}", parameter7.f);
                int Max = 0;

                while (parameter7.h1 >= parameter7.h1F && parameter7.h2 >= parameter7.h2F && Max < 5)
                {

                    if (parameter7.bestPoint > parameter7.THf)
                    {
                        Program7.SolveFx(parameter7);
                    }
                    else
                    {
                        if (parameter7.upperFx == parameter7.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter7.upperx, parameter7.y);
                            parameter7.h1 = parameter7.h1 / 2;
                            parameter7.h2 = parameter7.h2 / 2;
                            parameter7.THxx = parameter7.upperx;
                            parameter7.THyy = parameter7.y;

                            Program7.SolveFx(parameter7);
                        }

                        else if (parameter7.lowerFx == parameter7.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter7.lowerx, parameter7.y);
                            parameter7.h1 = parameter7.h1 / 2;
                            parameter7.h2 = parameter7.h2 / 2;
                            parameter7.THxx = parameter7.lowerx;
                            parameter7.THyy = parameter7.y;
                            Program7.SolveFx(parameter7);

                        }

                        else if (parameter7.upperFy == parameter7.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter7.xF, parameter7.uppery);
                            parameter7.h1 = parameter7.h1 / 2;
                            parameter7.h2 = parameter7.h2 / 2;
                            parameter7.THxx = parameter7.xF;
                            parameter7.THyy = parameter7.uppery;

                            Program7.SolveFx(parameter7);
                        }

                        else if (parameter7.lowerFy == parameter7.bestPoint)
                        {
                            Console.WriteLine("---Best Point---");
                            Console.WriteLine("f(x,y) = ({0},{1})", parameter7.xF, parameter7.lowery);
                            parameter7.h1 = parameter7.h1 / 2;
                            parameter7.h2 = parameter7.h2 / 2;
                            parameter7.THxx = parameter7.xF;
                            parameter7.THyy = parameter7.lowery;

                            Program7.SolveFx(parameter7);
                        }
                    }
                    parameter7.i++;
                    Max++;
                }

                int a;
                bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX1.Text);
                if (isEntryEmpty001)
                {
                    a = 0;
                }
                else if (Math.Abs(double.Parse(UpFX1.Text) - parameter7.UpFX[0]) <= 0.05)
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
                else if (Math.Abs(double.Parse(LowFX1.Text) - parameter7.LowFX[0]) <= 0.05)
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
                else if (Math.Abs(double.Parse(UpFY1.Text) - parameter7.UpFY[0]) <= 0.05)
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
                else if (Math.Abs(double.Parse(LowFY1.Text) - parameter7.LowFY[0]) <= 0.05)
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
                else if (Math.Abs(double.Parse(Th1.Text) - parameter7.TFunct[0]) <= 0.05)
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
                else if (Math.Abs(double.Parse(Bp1.Text) - parameter7.Function[0]) <= 0.05)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }

                double T = a + a1 + a2 + a3 + b + c;
                //double score = Math.Round((T / 6 * 100) * 2) / 2;
                double score = T;

                // Bp1.Text = score.ToString();
                await Navigation.PushModalAsync(new SecondIterationQ8(score));
            }
        }
        }
    }