using System;
using System.Collections.Generic;
using System.Text;

namespace PoastVOne
{
    class Program1
    {
      public static void SolveFx(Parameter1 parameter1)   // the main logic method that is repeated above
        {
            parameter1.x = parameter1.THxx;
            parameter1.y = parameter1.THyy;
            parameter1.upperx = parameter1.x + parameter1.h1;
            parameter1.upperFx = 5 * Math.Pow(parameter1.upperx, 2) - (3 * (parameter1.upperx * parameter1.y)) + 6 * Math.Pow(parameter1.y, 2) + (parameter1.upperx) + (2 * parameter1.y);
            parameter1.lowerx = parameter1.x - parameter1.h1;
            parameter1.lowerFx = 5 * Math.Pow(parameter1.lowerx, 2) - (3 * (parameter1.lowerx * parameter1.y)) + 6 * Math.Pow(parameter1.y, 2) + (parameter1.lowerx) + (2 * parameter1.y);
            parameter1.UpFX[parameter1.i] = Math.Round(parameter1.upperFx, 3);
            parameter1.LowFX[parameter1.i] = Math.Round(parameter1.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter1.upperx, parameter1.y, parameter1.UpFX[parameter1.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter1.lowerx, parameter1.y, parameter1.LowFX[parameter1.i]);

            if (parameter1.upperFx <= parameter1.lowerFx)
            {
                parameter1.xF = parameter1.upperx;
                parameter1.uppery = parameter1.y + parameter1.h2;
                parameter1.upperFy = 5 * Math.Pow(parameter1.xF, 2) - (3 * (parameter1.xF * parameter1.uppery)) + 6 * Math.Pow(parameter1.uppery, 2) + (parameter1.xF) + (2 * parameter1.uppery);
                parameter1.lowery = parameter1.y - parameter1.h1;
                parameter1.lowerFy = 5 * Math.Pow(parameter1.xF, 2) - (3 * (parameter1.xF * parameter1.lowery)) + 6 * Math.Pow(parameter1.lowery, 2) + (parameter1.xF) + (2 * parameter1.lowery);
                parameter1.UpFY[parameter1.i] = Math.Round(parameter1.upperFy, 3);
                parameter1.LowFY[parameter1.i] = Math.Round(parameter1.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter1.xF, parameter1.uppery, parameter1.UpFY[parameter1.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter1.xF, parameter1.lowery, parameter1.LowFY[parameter1.i]);
            }

            else if (parameter1.lowerFx <= parameter1.upperFx)
            {
                parameter1.uppery = parameter1.y + parameter1.h2;
                parameter1.xF = parameter1.lowerx;
                parameter1.upperFy = 5 * Math.Pow(parameter1.xF, 2) - (3 * (parameter1.xF * parameter1.uppery)) + 6 * Math.Pow(parameter1.uppery, 2) + (parameter1.xF) + (2 * parameter1.uppery);
                parameter1.lowery = parameter1.y - parameter1.h2;
                parameter1.lowerFy = 5 * Math.Pow(parameter1.xF, 2) - (3 * (parameter1.xF * parameter1.lowery)) + 6 * Math.Pow(parameter1.lowery, 2) + (parameter1.xF) + (2 * parameter1.lowery);
                parameter1.UpFY[parameter1.i] = Math.Round(parameter1.upperFy, 3);
                parameter1.LowFY[parameter1.i] = Math.Round(parameter1.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter1.xF, parameter1.uppery, parameter1.UpFY[parameter1.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter1.xF, parameter1.lowery, parameter1.LowFY[parameter1.i]);
            }

            parameter1.bestPoint = Math.Min(Math.Min(parameter1.upperFx, parameter1.lowerFx), Math.Min(parameter1.upperFy, parameter1.lowerFy));
            parameter1.Function[parameter1.i] = Math.Round(parameter1.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter1.Function[parameter1.i]);

            // ---temporary head
            if (parameter1.bestPoint == parameter1.upperFx)
            {
                parameter1.THxx = 2 * parameter1.upperx - parameter1.x;
                parameter1.THyy = 2 * parameter1.y - parameter1.y;
                parameter1.THf = 5 * Math.Pow(parameter1.THxx, 2) - (3 * (parameter1.THxx * parameter1.THyy)) + 6 * Math.Pow(parameter1.THyy, 2) + (parameter1.THxx) + (2 * parameter1.THyy);
                parameter1.TFunct[parameter1.i] = Math.Round(parameter1.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter1.THxx, parameter1.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter1.THxx, parameter1.THyy, parameter1.TFunct[parameter1.i]);
            }
            else if (parameter1.bestPoint == parameter1.lowerFx)
            {
                parameter1.THxx = 2 * parameter1.lowerx - parameter1.x;
                parameter1.THyy = 2 * parameter1.y - parameter1.y;
                parameter1.THf = 5 * Math.Pow(parameter1.THxx, 2) - (3 * (parameter1.THxx * parameter1.THyy)) + 6 * Math.Pow(parameter1.THyy, 2) + (parameter1.THxx) + (2 * parameter1.THyy);
                parameter1.TFunct[parameter1.i] = Math.Round(parameter1.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter1.THxx, parameter1.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter1.THxx, parameter1.THyy, parameter1.TFunct[parameter1.i]);
            }
            else if (parameter1.bestPoint == parameter1.upperFy)
            {
                parameter1.THxx = 2 * parameter1.xF - parameter1.x;
                parameter1.THyy = 2 * parameter1.uppery - parameter1.y;
                parameter1.THf = 5 * Math.Pow(parameter1.THxx, 2) - (3 * (parameter1.THxx * parameter1.THyy)) + 6 * Math.Pow(parameter1.THyy, 2) + (parameter1.THxx) + (2 * parameter1.THyy);
                parameter1.TFunct[parameter1.i] = Math.Round(parameter1.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter1.THxx, parameter1.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter1.THxx, parameter1.THyy, parameter1.TFunct[parameter1.i]);
            }
            else if (parameter1.bestPoint == parameter1.lowerFy)
            {
                parameter1.THxx = 2 * parameter1.xF - parameter1.x;
                parameter1.THyy = 2 * parameter1.lowery - parameter1.y;
                parameter1.THf = 5 * Math.Pow(parameter1.THxx, 2) - (3 * (parameter1.THxx * parameter1.THyy)) + 6 * Math.Pow(parameter1.THyy, 2) + (parameter1.THxx) + (2 * parameter1.THyy);
                parameter1.TFunct[parameter1.i] = Math.Round(parameter1.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter1.THxx, parameter1.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter1.THxx, parameter1.THyy, parameter1.TFunct[parameter1.i]);
            }

        }
    }
}
