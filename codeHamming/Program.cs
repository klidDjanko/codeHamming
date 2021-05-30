using System;

namespace codeHamming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получаем ввод
            Console.Write("Введите исходную строку (англ.): ");
            string input = Convert.ToString(Console.ReadLine());
            Code code = new Code();
            code.CodeH(input);

            Console.ReadKey();
        }
    }
}
