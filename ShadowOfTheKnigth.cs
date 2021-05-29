using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs;
        inputs = Console.ReadLine().Split(' ');
        int W = int.Parse(inputs[0]); // width of the building.
        int H = int.Parse(inputs[1]); // height of the building.
        int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
        inputs = Console.ReadLine().Split(' ');
        int X0 = int.Parse(inputs[0]);
        int Y0 = int.Parse(inputs[1]);
        var x = X0;
        var y = Y0;

        var xMin = -1;
        var xMax = W;
        var yMin = -1;
        var yMax = H;
        // game loop
        while (true)
        {

            string dir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)
            if (dir.Contains("U"))
            {
                yMax = y;
                y = (y - ((yMax - yMin) / 2));
            }
            if (dir.Contains("D"))
            {
                yMin = y;
                y = (y + ((yMax - yMin) / 2));
            }
            if (dir.Contains("L"))
            {
                xMax = x;
                x = (x - ((xMax - xMin) / 2));
            }
            if (dir.Contains("R"))
            {
                xMin = x;
                x = (x + ((xMax - xMin) / 2));
            }
            Console.WriteLine($"{x} {y}");

        }
    }
}
