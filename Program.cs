using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Defense_of_Consolas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //this exercise is for defend a single square on a map chessboard like and to protect that cell there is need of a group of around cell 
            //title of the console 
            Console.Title = "Defense of Consolas";
            // ask for the row and column
            Console.WriteLine("Which is the target ROw?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Which is the target column?");
            int col = Convert.ToInt32(Console.ReadLine());

            // now we have to protect the targeted cell all around and where to plae our defence and should be row and column -1 +1 and also row -1 +1 column
            // in this way we can protect the cell targeted 

            Console.WriteLine($"({row}, {col + 1})");
            Console.WriteLine($"({row + 1}, {col})");
            Console.WriteLine($"({row - 1}, {col})");
            Console.WriteLine($"({row}, {col - 1})");

            Console.Beep();

        }
    }
}
