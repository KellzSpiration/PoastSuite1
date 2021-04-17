﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionTwo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondIteration : ContentPage
    {
        private double p;
        public SecondIteration(double score)
        {
            InitializeComponent();
            p = score;
        }

        async void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter1 = new Parameter1(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter1.f = 5 * Math.Pow(parameter1.x, 2) - (3 * (parameter1.x * parameter1.y)) + 6 * Math.Pow(parameter1.y, 2) + (parameter1.x) + (2 * parameter1.y);
            Console.WriteLine("f(0,0) = {0}", parameter1.f);
            int Max = 0;

            while (parameter1.h1 >= parameter1.h1F && parameter1.h2 >= parameter1.h2F && Max < 5)
            {

                if (parameter1.bestPoint > parameter1.THf)
                {
                    Program1.SolveFx(parameter1);
                }
                else
                {
                    if (parameter1.upperFx == parameter1.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.upperx, parameter1.y);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THxx = parameter1.upperx;
                        parameter1.THyy = parameter1.y;

                        Program1.SolveFx(parameter1);
                    }

                    else if (parameter1.lowerFx == parameter1.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.lowerx, parameter1.y);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THxx = parameter1.lowerx;
                        parameter1.THyy = parameter1.y;
                        Program1.SolveFx(parameter1);

                    }

                    else if (parameter1.upperFy == parameter1.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.xF, parameter1.uppery);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THxx = parameter1.xF;
                        parameter1.THyy = parameter1.uppery;

                        Program1.SolveFx(parameter1);
                    }

                    else if (parameter1.lowerFy == parameter1.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter1.xF, parameter1.lowery);
                        parameter1.h1 = parameter1.h1 / 2;
                        parameter1.h2 = parameter1.h2 / 2;
                        parameter1.THxx = parameter1.xF;
                        parameter1.THyy = parameter1.lowery;

                        Program1.SolveFx(parameter1);
                    }
                }
                parameter1.i++;
                Max++;

            }

            int a;
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX2.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX2.Text) - parameter1.UpFX[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX2.Text) - parameter1.LowFX[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY2.Text) - parameter1.UpFY[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY2.Text) - parameter1.LowFY[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th2.Text) - parameter1.TFunct[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp2.Text) - parameter1.Function[1]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c + p;
            // double score2 = Math.Round(T / 6 * 100);

            double score2 = T;
            // Bp2.Text = score2.ToString();
            await Navigation.PushModalAsync(new ThirdIteration(score2));



        }

       async private void BtnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstIterationQ2());
        }
    }
    }
