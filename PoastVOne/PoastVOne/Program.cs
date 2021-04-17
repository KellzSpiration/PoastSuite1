using System;
using System.Collections.Generic;
using System.Text;

namespace PoastVOne
{
   class Program5
    {
       public static void SolveFx(Parameter parameter)   // the main logic method that is repeated above
        {
            parameter.x = parameter.THx;
            parameter.y = parameter.THy;
            parameter.upperx = parameter.x + parameter.h1;
            parameter.upperFx = 3 * Math.Pow(parameter.upperx, 2) - (2 * (parameter.upperx * parameter.y)) + Math.Pow(parameter.y, 2) + (4 * parameter.upperx) + (3 * parameter.y);
            parameter.lowerx = parameter.x - parameter.h1;
            parameter.lowerFx = 3 * Math.Pow(parameter.lowerx, 2) - (2 * (parameter.lowerx * parameter.y)) + Math.Pow(parameter.y, 2) + (4 * parameter.lowerx) + (3 * parameter.y);
            parameter.UpFX[parameter.i] = Math.Round(parameter.upperFx, 3);
            parameter.LowFX[parameter.i] = Math.Round(parameter.lowerFx, 3);
            Console.WriteLine("f(x+h1,y) = ({0},{1}) = {2}", parameter.upperx, parameter.y, parameter.UpFX[parameter.i]);
            Console.WriteLine("f(x-h1,y) = ({0},{1}) = {2}", parameter.lowerx, parameter.y, parameter.LowFX[parameter.i]);

            if (parameter.upperFx <= parameter.lowerFx)
            {
                parameter.xF = parameter.upperx;
                parameter.uppery = parameter.y + parameter.h2;
                parameter.upperFy = 3 * Math.Pow(parameter.xF, 2) - (2 * (parameter.xF * parameter.uppery)) + Math.Pow(parameter.uppery, 2) + (4 * parameter.xF) + (3 * parameter.uppery);
                parameter.lowery = parameter.y - parameter.h1;
                parameter.lowerFy = 3 * Math.Pow(parameter.xF, 2) - (2 * (parameter.xF * parameter.lowery)) + Math.Pow(parameter.lowery, 2) + (4 * parameter.xF) + (3 * parameter.lowery);
                parameter.UpFY[parameter.i] = Math.Round(parameter.upperFy, 3);
                parameter.LowFY[parameter.i] = Math.Round(parameter.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter.xF, parameter.uppery, parameter.UpFY[parameter.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter.xF, parameter.lowery, parameter.LowFY[parameter.i]);
            }

            else if (parameter.lowerFx <= parameter.upperFx)
            {
                parameter.uppery = parameter.y + parameter.h2;
                parameter.xF = parameter.lowerx;
                parameter.upperFy = 3 * Math.Pow(parameter.xF, 2) - (2 * (parameter.xF * parameter.uppery)) + Math.Pow(parameter.uppery, 2) + (4 * parameter.xF) + (3 * parameter.uppery);
                parameter.lowery = parameter.y - parameter.h2;
                parameter.lowerFy = 3 * Math.Pow(parameter.xF, 2) - (2 * (parameter.xF * parameter.lowery)) + Math.Pow(parameter.lowery, 2) + (4 * parameter.xF) + (3 * parameter.lowery);
                parameter.UpFY[parameter.i] = Math.Round(parameter.upperFy, 3);
                parameter.LowFY[parameter.i] = Math.Round(parameter.lowerFy, 3);
                Console.WriteLine("f(x,y+h2) = ({0},{1}) = {2}", parameter.xF, parameter.uppery, parameter.UpFY[parameter.i]);
                Console.WriteLine("f(x,y-h2) = ({0},{1}) = {2}", parameter.xF, parameter.lowery, parameter.LowFY[parameter.i]);
            }

            parameter.bestPoint = Math.Min(Math.Min(parameter.upperFx, parameter.lowerFx), Math.Min(parameter.upperFy, parameter.lowerFy));
            parameter.Function[parameter.i] = Math.Round(parameter.bestPoint, 3);
            Console.WriteLine("Best Point ={0}", parameter.Function[parameter.i]);

            // ---temporary head
            if (parameter.bestPoint == parameter.upperFx)
            {
                parameter.THx = 2 * parameter.upperx - parameter.x;
                parameter.THy = 2 * parameter.y - parameter.y;
                parameter.THf = 3 * Math.Pow(parameter.THx, 2) - (2 * (parameter.THx * parameter.THy)) + Math.Pow(parameter.THy, 2) + (4 * parameter.THx) + (3 * parameter.THy);
                parameter.TFunct[parameter.i] = Math.Round(parameter.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter.THx, parameter.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter.THx, parameter.THy, parameter.TFunct[parameter.i]);
            }
            else if (parameter.bestPoint == parameter.lowerFx)
            {
                parameter.THx = 2 * parameter.lowerx - parameter.x;
                parameter.THy = 2 * parameter.y - parameter.y;
                parameter.THf = 3 * Math.Pow(parameter.THx, 2) - (2 * (parameter.THx * parameter.THy)) + Math.Pow(parameter.THy, 2) + (4 * parameter.THx) + (3 * parameter.THy);
                parameter.TFunct[parameter.i] = Math.Round(parameter.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter.THx, parameter.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter.THx, parameter.THy, parameter.TFunct[parameter.i]);
            }
            else if (parameter.bestPoint == parameter.upperFy)
            {
                parameter.THx = 2 * parameter.xF - parameter.x;
                parameter.THy = 2 * parameter.uppery - parameter.y;
                parameter.THf = 3 * Math.Pow(parameter.THx, 2) - (2 * (parameter.THx * parameter.THy)) + Math.Pow(parameter.THy, 2) + (4 * parameter.THx) + (3 * parameter.THy);
                parameter.TFunct[parameter.i] = Math.Round(parameter.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("x,y = {0},{1}", parameter.THx, parameter.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter.THx, parameter.THy, parameter.TFunct[parameter.i]);
            }
            else if (parameter.bestPoint == parameter.lowerFy)
            {
                parameter.THx = 2 * parameter.xF - parameter.x;
                parameter.THy = 2 * parameter.lowery - parameter.y;
                parameter.THf = 3 * Math.Pow(parameter.THx, 2) - (2 * (parameter.THx * parameter.THy)) + Math.Pow(parameter.THy, 2) + (4 * parameter.THx) + (3 * parameter.THy);
                parameter.TFunct[parameter.i] = Math.Round(parameter.THf, 3);
                Console.WriteLine("---Temporary Head---");
                Console.WriteLine("(x,y) = {0},{1}", parameter.THx, parameter.THy);
                Console.WriteLine("f({0},{1}) = {2}", parameter.THx, parameter.THy, parameter.TFunct[parameter.i]);
            }

        }
    }
}
