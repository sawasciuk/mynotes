using mynotes.Utils;

namespace mynotes
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calc();
            var x = 2;
            var y = 3;
            System.Console.WriteLine(string.Format("{0} + {1} = {2}", x, y, calc.Add(x, y)));
        }
    }
}
