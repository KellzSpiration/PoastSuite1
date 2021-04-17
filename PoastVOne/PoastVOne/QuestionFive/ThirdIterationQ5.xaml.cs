﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionFive
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThirdIterationQ5 : ContentPage
    {
        private double q;
        public ThirdIterationQ5(double score2)
        {
            InitializeComponent();
            q = score2;
        }

        async private void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter4 = new Parameter4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter4.f = 6 * Math.Pow(parameter4.x, 2) - (5 * (parameter4.x * parameter4.y)) + 2 * Math.Pow(parameter4.y, 2) + (4 * parameter4.x) + (2 * parameter4.y);
            Console.WriteLine("f(0,0) = {0}", parameter4.f);
            int Max = 0;

            while (parameter4.h1 >= parameter4.h1F && parameter4.h2 >= parameter4.h2F && Max < 5)
            {

                if (parameter4.bestPoint > parameter4.THf)
                {
                    Program4.SolveFx(parameter4);
                }
                else
                {
                    if (parameter4.upperFx == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.upperx, parameter4.y);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.upperx;
                        parameter4.THyy = parameter4.y;

                        Program4.SolveFx(parameter4);
                    }

                    else if (parameter4.lowerFx == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.lowerx, parameter4.y);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.lowerx;
                        parameter4.THyy = parameter4.y;
                        Program4.SolveFx(parameter4);

                    }

                    else if (parameter4.upperFy == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.xF, parameter4.uppery);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.xF;
                        parameter4.THyy = parameter4.uppery;

                        Program4.SolveFx(parameter4);
                    }

                    else if (parameter4.lowerFy == parameter4.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter4.xF, parameter4.lowery);
                        parameter4.h1 = parameter4.h1 / 2;
                        parameter4.h2 = parameter4.h2 / 2;
                        parameter4.THxx = parameter4.xF;
                        parameter4.THyy = parameter4.lowery;

                        Program4.SolveFx(parameter4);
                    }
                }
                parameter4.i++;
                Max++;
            }

            int a;
            bool isEntryEmpty007 = string.IsNullOrEmpty(UpFX3.Text);
            if (isEntryEmpty007)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX3.Text) - parameter4.UpFX[2]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty008 = string.IsNullOrEmpty(LowFX3.Text);
            if (isEntryEmpty008)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX3.Text) - parameter4.LowFX[2]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty009 = string.IsNullOrEmpty(UpFY3.Text);
            if (isEntryEmpty009)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY3.Text) - parameter4.UpFY[2]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty010 = string.IsNullOrEmpty(LowFY3.Text);
            if (isEntryEmpty010)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY3.Text) - parameter4.LowFY[2]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty011 = string.IsNullOrEmpty(Th3.Text);
            if (isEntryEmpty011)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th3.Text) - parameter4.TFunct[2]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty012 = string.IsNullOrEmpty(Bp3.Text);
            if (isEntryEmpty012)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp3.Text) - parameter4.Function[2]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c + q;
            //double score3 = Math.Round((T / 6 * 100) * 2);
            // double score3 = Math.Round((((Math.Round((T / 6 * 100) * 2) / 2) + q) / 2) * 2) / 2;

            double score3 = T;
            // Bp3.Text = score3.ToString();
            await Navigation.PushModalAsync(new FourthgIterationQ5(score3));

        }
    }
}