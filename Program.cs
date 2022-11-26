using System.Drawing;

namespace My_method
{
    internal class Program
    {

        static  string Drowsymbol(string symbolfordrow, int howmanysymbol) 
        {
            string drow;
            drow = default;
            for (int i = 0; i < howmanysymbol; i++)
            {
                drow = drow + symbolfordrow;
            }
            return drow;
        }
        static void Main(string[] args)
        {
            string symbol;
            int size;
            string prit;

            Console.Write("Enter symbol:");
            symbol = Console.ReadLine();
            Console.Write("Enter size:");
            size = int.Parse(Console.ReadLine());

            prit = Drowsymbol(symbol, size);
            Console.WriteLine(prit);
        }
    }
}