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
            //Кодируем
            Console.WriteLine("Код Хемминга для заданной строки:");
            Code code = new Code();
            code.CodeH(input);
            //Декодируем
            Console.WriteLine("Декодировать и исправить однократные ошибки:");
            input = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Декодированное сообщение: ");
            Decode decode = new Decode();
            decode.DecodeH(input);

            Console.ReadKey();
        }
    }
}
