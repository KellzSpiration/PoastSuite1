﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PoastVOne.QuestionThree
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FifthIterationQ3 : ContentPage
    {
        private double s;
        public FifthIterationQ3(double score4)
        {
            InitializeComponent();
            s = score4;
        }

        async void BtnNext_Clicked(object sender, EventArgs e)
        {
            var parameter2 = new Parameter2(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0.125, 0.125, 0, 0);  // object instance of the Parameter class

            parameter2.f = Math.Pow(parameter2.x, 2) - (4 * (parameter2.x * parameter2.y)) + 3 * Math.Pow(parameter2.y, 2) + (2 * parameter2.x) + (parameter2.y);
            Console.WriteLine("f(0,0) = {0}", parameter2.f);
            int Max = 0;

            while (parameter2.h1 >= parameter2.h1F && parameter2.h2 >= parameter2.h2F && Max < 5)
            {

                if (parameter2.bestPoint > parameter2.THf)
                {
                    Program2.SolveFx(parameter2);
                }
                else
                {
                    if (parameter2.upperFx == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.upperx, parameter2.y);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.upperx;
                        parameter2.THy = parameter2.y;

                        Program2.SolveFx(parameter2);
                    }

                    else if (parameter2.lowerFx == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.lowerx, parameter2.y);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.lowerx;
                        parameter2.THy = parameter2.y;
                        Program2.SolveFx(parameter2);

                    }

                    else if (parameter2.upperFy == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.xF, parameter2.uppery);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.xF;
                        parameter2.THy = parameter2.uppery;

                        Program2.SolveFx(parameter2);
                    }

                    else if (parameter2.lowerFy == parameter2.bestPoint)
                    {
                        Console.WriteLine("---Best Point---");
                        Console.WriteLine("f(x,y) = ({0},{1})", parameter2.xF, parameter2.lowery);
                        parameter2.h1 = parameter2.h1 / 2;
                        parameter2.h2 = parameter2.h2 / 2;
                        parameter2.THx = parameter2.xF;
                        parameter2.THy = parameter2.lowery;

                        Program2.SolveFx(parameter2);
                    }
                }
                parameter2.i++;

            }
            int a;
            bool isEntryEmpty001 = string.IsNullOrEmpty(UpFX5.Text);
            if (isEntryEmpty001)
            {
                a = 0;
            }
            else if (Math.Abs(double.Parse(UpFX5.Text) - parameter2.UpFX[4]) <= 0.05)
            {
                a = 1;
            }
            else
            {
                a = 0;
            }


            int a1;
            bool isEntryEmpty002 = string.IsNullOrEmpty(LowFX5.Text);
            if (isEntryEmpty002)
            {
                a1 = 0;
            }
            else if (Math.Abs(double.Parse(LowFX5.Text) - parameter2.LowFX[4]) <= 0.05)
            {
                a1 = 1;
            }
            else
            {
                a1 = 0;
            }


            int a2;
            bool isEntryEmpty003 = string.IsNullOrEmpty(UpFY5.Text);
            if (isEntryEmpty003)
            {
                a2 = 0;
            }
            else if (Math.Abs(double.Parse(UpFY5.Text) - parameter2.UpFY[4]) <= 0.05)
            {
                a2 = 1;
            }
            else
            {
                a2 = 0;
            }

            int a3;
            bool isEntryEmpty004 = string.IsNullOrEmpty(LowFY5.Text);
            if (isEntryEmpty004)
            {
                a3 = 0;
            }
            else if (Math.Abs(double.Parse(LowFY5.Text) - parameter2.LowFY[4]) <= 0.05)
            {
                a3 = 1;
            }
            else
            {
                a3 = 0;
            }

            int b;
            bool isEntryEmpty005 = string.IsNullOrEmpty(Th5.Text);
            if (isEntryEmpty005)
            {
                b = 0;
            }
            else if (Math.Abs(double.Parse(Th5.Text) - parameter2.TFunct[4]) <= 0.05)
            {
                b = 1;
            }
            else
            {
                b = 0;
            }

            int c;
            bool isEntryEmpty006 = string.IsNullOrEmpty(Bp5.Text);
            if (isEntryEmpty006)
            {
                c = 0;
            }
            else if (Math.Abs(double.Parse(Bp5.Text) - parameter2.Function[4]) <= 0.05)
            {
                c = 1;
            }
            else
            {
                c = 0;
            }

            double T = a + a1 + a2 + a3 + b + c + s;
            //double score5 = ((Math.Round((T / 6 * 100) * 2) / 2)+s)/2;
            double score5 = Math.Round((T / 30 * 100) * 2) / 2;


            // Bp5.Text = score5.ToString();
            await Navigation.PushModalAsync(new GradePageQ3(score5.ToString()));


        }
    }
}