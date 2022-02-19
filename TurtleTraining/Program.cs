using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace TurtleTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            Turtle.X = 50;
            Turtle.Y = 300;
            //1 задача
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(30);
                Turtle.TurnRight();
                Turtle.Move(30);
                Turtle.TurnRight();
                Turtle.Move(30);
                Turtle.TurnLeft();
                Turtle.Move(30);
                Turtle.TurnLeft();
            }

            Turtle.X = 450;
            Turtle.Y = 300;

            //2 задача
            for (int i = 0; i < 6; i++)
            {
                Turtle.Move(80);
                Turtle.Turn(60);
            }
        }
    }
}
