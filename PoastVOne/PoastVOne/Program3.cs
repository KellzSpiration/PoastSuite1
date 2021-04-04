using System;
using System.Collections.Generic;
using System.Text;

namespace PoastVOne
{
    class Program3
    {
     public static void SolveFx(Parameter3 parameter3)   // the main logic method that is repeated above
        {
            parameter3.x = parameter3.THxx;
            parameter3.y = parameter3.THyy;
            parameter3.upperx = parameter3.x + parameter3.h1;
            parameter3.upperFx = 2 * Math.Pow(parameter3.upperx, 2) - (7 * (parameter3.upperx * parameter3.y)) + 6 * Math.Pow(parameter3.y, 2) + (5 * parameter3.upperx) + (5 * parameter3.y);
            parameter3.lowerx = parameter3.x - parameter3.h1;
            parameter3.lowerFx = 2 * Math.Pow(parameter3.lowerx, 2) - (7 * (parameter3.lowerx * parameter3.y)) + 6 * Math.Pow(parameter3.y, 2) + (5 * parameter3.lowerx) + (5 * parameter3.y);
            parameter3.UpFX[parameter3.i] = Math.Round(parameter3.upperFx, 3);
            parameter3.LowFX[parameter3.i] = Math.Round(parameter3.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter3.upperx, parameter3.y, parameter3.UpFX[parameter3.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter3.lowerx, parameter3.y, parameter3.LowFX[parameter3.i]);

            if (parameter3.upperFx <= parameter3.lowerFx)
            {
                parameter3.xF = parameter3.upperx;
                parameter3.uppery = parameter3.y + parameter3.h2;
                parameter3.upperFy = 2 * Math.Pow(parameter3.xF, 2) - (7 * (parameter3.xF * parameter3.uppery)) + 6 * Math.Pow(parameter3.uppery, 2) + (5 * parameter3.xF) + (5 * parameter3.uppery);
                parameter3.lowery = parameter3.y - parameter3.h1;
                parameter3.lowerFy = 2 * Math.Pow(parameter3.xF, 2) - (7 * (parameter3.xF * parameter3.lowery)) + 6 * Math.Pow(parameter3.lowery, 2) + (5 * parameter3.xF) + (5 * parameter3.lowery);
                parameter3.UpFY[parameter3.i] = Math.Round(parameter3.upperFy, 3);
                parameter3.LowFY[parameter3.i] = Math.Round(parameter3.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.uppery, parameter3.UpFY[parameter3.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.lowery, parameter3.LowFY[parameter3.i]);
            }

            else if (parameter3.lowerFx <= parameter3.upperFx)
            {
                parameter3.uppery = parameter3.y + parameter3.h2;
                parameter3.xF = parameter3.lowerx;
                parameter3.upperFy = 2 * Math.Pow(parameter3.xF, 2) - (7 * (parameter3.xF * parameter3.uppery)) + 6 * Math.Pow(parameter3.uppery, 2) + (5 * parameter3.xF) + (5 * parameter3.uppery);
                parameter3.lowery = parameter3.y - parameter3.h2;
                parameter3.lowerFy = 2 * Math.Pow(parameter3.xF, 2) - (7 * (parameter3.xF * parameter3.lowery)) + 6 * Math.Pow(parameter3.lowery, 2) + (5 * parameter3.xF) + (5 * parameter3.lowery);
                parameter3.UpFY[parameter3.i] = Math.Round(parameter3.upperFy, 3);
                parameter3.LowFY[parameter3.i] = Math.Round(parameter3.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.uppery, parameter3.UpFY[parameter3.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter3.xF, parameter3.lowery, parameter3.LowFY[parameter3.i]);
            }

            parameter3.bestPoint = Math.Min(Math.Min(parameter3.upperFx, parameter3.lowerFx), Math.Min(parameter3.upperFy, parameter3.lowerFy));
            parameter3.Function[parameter3.i] = Math.Round(parameter3.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter3.Function[parameter3.i]);

            // ---temporary head
            if (parameter3.bestPoint == parameter3.upperFx)
            {
                parameter3.THxx = 2 * parameter3.upperx - parameter3.x;
                parameter3.THyy = 2 * parameter3.y - parameter3.y;
                parameter3.THf = 2 * Math.Pow(parameter3.THxx, 2) - (7 * (parameter3.THxx * parameter3.THyy)) + 6 * Math.Pow(parameter3.THyy, 2) + (5 * parameter3.THxx) + (5 * parameter3.THyy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter3.THxx, parameter3.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THxx, parameter3.THyy, parameter3.TFunct[parameter3.i]);
            }
            else if (parameter3.bestPoint == parameter3.lowerFx)
            {
                parameter3.THxx = 2 * parameter3.lowerx - parameter3.x;
                parameter3.THyy = 2 * parameter3.y - parameter3.y;
                parameter3.THf = 2 * Math.Pow(parameter3.THxx, 2) - (7 * (parameter3.THxx * parameter3.THyy)) + 6 * Math.Pow(parameter3.THyy, 2) + (5 * parameter3.THxx) + (5 * parameter3.THyy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter3.THxx, parameter3.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THxx, parameter3.THyy, parameter3.TFunct[parameter3.i]);
            }
            else if (parameter3.bestPoint == parameter3.upperFy)
            {
                parameter3.THxx = 2 * parameter3.xF - parameter3.x;
                parameter3.THyy = 2 * parameter3.uppery - parameter3.y;
                parameter3.THf = 2 * Math.Pow(parameter3.THxx, 2) - (7 * (parameter3.THxx * parameter3.THyy)) + 6 * Math.Pow(parameter3.THyy, 2) + (5 * parameter3.THxx) + (5 * parameter3.THyy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter3.THxx, parameter3.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THxx, parameter3.THyy, parameter3.TFunct[parameter3.i]);
            }
            else if (parameter3.bestPoint == parameter3.lowerFy)
            {
                parameter3.THxx = 2 * parameter3.xF - parameter3.x;
                parameter3.THyy = 2 * parameter3.lowery - parameter3.y;
                parameter3.THf = 2 * Math.Pow(parameter3.THxx, 2) - (7 * (parameter3.THxx * parameter3.THyy)) + 6 * Math.Pow(parameter3.THyy, 2) + (5 * parameter3.THxx) + (5 * parameter3.THyy);
                parameter3.TFunct[parameter3.i] = Math.Round(parameter3.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter3.THxx, parameter3.THyy);
                Console.WriteLine("f({0},{1}) = {2}", parameter3.THxx, parameter3.THyy, parameter3.TFunct[parameter3.i]);
            }

        }
    }
}
