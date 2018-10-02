using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змейка
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            HLine UpLine = new HLine(0, 78, 0, '*');
            UpLine.Draw();
            HLine DownLine = new HLine(0, 78, 24, '*');
            DownLine.Draw();
            VLine LeftLine = new VLine(0, 0, 24, '*');
            LeftLine.Draw();
            VLine RightLine = new VLine(78, 0, 24, '*');
            RightLine.Draw();

            Console.ReadLine();
        }
    }
}
