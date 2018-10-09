using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            HLine UpLine = new HLine(0, 70, 0, '*');
            UpLine.Draw();
            HLine DownLine = new HLine(0, 70, 20, '*');
            DownLine.Draw();
            VLine LeftLine = new VLine(0, 0, 20, '*');
            LeftLine.Draw();
            VLine RightLine = new VLine(70, 0, 20, '*');
            RightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
