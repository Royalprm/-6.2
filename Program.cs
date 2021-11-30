using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string wordWithMaxLength = string.Empty;
            string[] words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
                if (words[i].Length > wordWithMaxLength.Length)
                    wordWithMaxLength = words[i];
            Console.WriteLine(wordWithMaxLength);

            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу на клавиатуре");
            Console.ReadKey();
        }
    }
}
