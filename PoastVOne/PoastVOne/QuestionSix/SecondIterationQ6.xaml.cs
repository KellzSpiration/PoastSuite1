﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionSix
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondIterationQ6 : ContentPage
    {
        private double p;
        public SecondIterationQ6(double score)
        {
            InitializeComponent();
            p = score;
        }

       async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter5 = new Parameter5(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter5.f = Math.Pow(parameter5.x, 2) - (2 * (parameter5.x * parameter5.y)) + 2 * Math.Pow(parameter5.y, 2) + (8 * parameter5.x) + (3 * parameter5.y);
            Console.WriteLine("f(0,0) = {0}", parameter5.f);
            int Max = 0;

            while (parameter5.h1 >= parameter5.h1F && parameter5.h2 >= parameter5.h2F && Max < 5)
            {

                if (parameter5.bestPoint > parameter5.THf)
                {
                    Programm5.SolveFx(parameter5);
                }
                else
                {
                    if (parameter5.upperFx == parameter5.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter5.upperx, parameter5.y);
                        parameter5.h1 = parameter5.h1 / 2;
                        parameter5.h2 = parameter5.h2 / 2;
                        parameter5.THxx = parameter5.upperx;
                        parameter5.THyy = parameter5.y;

                        Programm5.SolveFx(parameter5);
                    }

                    else if (parameter5.lowerFx == parameter5.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter5.lowerx, parameter5.y);
                        parameter5.h1 = parameter5.h1 / 2;
                        parameter5.h2 = parameter5.h2 / 2;
                        parameter5.THxx = parameter5.lowerx;
                        parameter5.THyy = parameter5.y;
                        Programm5.SolveFx(parameter5);

                    }

                    else if (parameter5.upperFy == parameter5.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter5.xF, parameter5.uppery);
                        parameter5.h1 = parameter5.h1 / 2;
                        parameter5.h2 = parameter5.h2 / 2;
                        parameter5.THxx = parameter5.xF;
                        parameter5.THyy = parameter5.uppery;

                        Programm5.SolveFx(parameter5);
                    }

                    else if (parameter5.lowerFy == parameter5.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter5.xF, parameter5.lowery);
                        parameter5.h1 = parameter5.h1 / 2;
                        parameter5.h2 = parameter5.h2 / 2;
                        parameter5.THxx = parameter5.xF;
                        parameter5.THyy = parameter5.lowery;

                        Programm5.SolveFx(parameter5);
                    }
                }
                parameter5.i++;
                Max++;
            }
            int a;
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX2.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX2.Text) - parameter5.UpFX[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFX2.Text) - parameter5.LowFX[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(UpFY2.Text) - parameter5.UpFY[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(LowFY2.Text) - parameter5.LowFY[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Th2.Text) - parameter5.TFunct[1]) <= 0.05)
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
            else if (Math.Abs(double.Parse(Bp2.Text) - parameter5.Function[1]) <= 0.05)
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
            await Navigation.PushModalAsync(new ThirdIterationQ6(score2));

        }
    }
}