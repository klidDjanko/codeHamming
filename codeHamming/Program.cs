using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeHamming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Получаем ввод
            Console.Write("Введите английский символ: ");
            string input = Convert.ToString(Console.ReadLine());
            //Получаем информационную часть в двоичном виде
            EnglishAlph english = new EnglishAlph();
            string binary = english.CharToBinary(input);
            Console.WriteLine("Код символа в бинарном виде: {0}", binary);
            //Кодируем, заполняем информационные биты кода Хемминга (9.4)
            string[] codeHamming = new string[binary.Length + 4];
            //Внешний цикл идёт по бинарному коду буквы
            Program program = new Program();
            for(int i = 0; i < binary.Length; i++)
            {
                //Внуренний цикл идёт по индексам кода Хемминга
                for(int j = 0; j < codeHamming.Length; j++)
                {
                    //Если это не ключевой блок с проверочным битом и если он не занят, запишем информационный бит
                    if (Math.Log(j + 1, 2) % 1 != 0 && codeHamming[j] == null)
                    {
                        codeHamming[j] = binary[i].ToString();
                        break;
                    }
                    else if(Math.Log(j + 1, 2) % 1 == 0)
                    {
                        if (j + 1 == 1) codeHamming[j] = program.Xor(binary[1].ToString(), binary[2].ToString());
                        if (j + 1 == 2) codeHamming[j] = program.Xor(program.Xor(binary[0].ToString(), binary[2].ToString()), binary[3].ToString());
                        if (j + 1 == 4) codeHamming[j] = program.Xor(program.Xor(binary[1].ToString(), binary[3].ToString()), binary[4].ToString());
                        if (j + 1 == 8) codeHamming[j] = program.Xor(program.Xor(binary[0].ToString(), binary[1].ToString()), binary[4].ToString());
                    }
                }
            }

            //Вывод кода на консоль
            Console.Write("Полученный код Хемминга: ");
            foreach (string el in codeHamming) Console.Write(el);
            Console.ReadLine();
        }

        string Xor(string a, string b)
        {
            string result = "0";
            if (a == "0" && b == "0" || a == "1" && b == "1") result = "0";
            else result = "1";
            return result;
        }
    }
}
