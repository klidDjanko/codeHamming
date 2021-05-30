using System;
using System.Text;


namespace codeHamming
{
    class Decode
    {
        public void DecodeH(string input)
        {
            //Полученные коды букв хемминга
            string[] hammingCode = input.Split(' ');
            //Проверяем синдромы каждого кода
            for (int w = 0; w < hammingCode.Length; w++)
            {
                StringBuilder currWord = new StringBuilder(hammingCode[w]);

                //Здесь считаем синдромы из расчёта формата кода (9,4)
                Code code = new Code();
                string s1 = code.Xor(code.Xor(currWord[1].ToString(), currWord[2].ToString()), currWord[5].ToString());
                string s2 = code.Xor(code.Xor(currWord[0].ToString(), currWord[2].ToString()), code.Xor(currWord[3].ToString(), currWord[6].ToString()));
                string s3 = code.Xor(code.Xor(currWord[1].ToString(), currWord[3].ToString()), code.Xor(currWord[4].ToString(), currWord[7].ToString()));
                string s4 = code.Xor(code.Xor(currWord[0].ToString(), currWord[1].ToString()), code.Xor(currWord[4].ToString(), currWord[8].ToString()));

                //Теперь смотрим есть ли ошибка в коде буквы
                if (s1 == "0" && s2 == "1" && s3 == "0" && s4 == "1")
                {
                    Console.WriteLine("Найдена ошибка в 1 разряде кода буквы, ошибка скорректирована.");
                    if (currWord[0] == '0') currWord[0] = '1';
                    else currWord[0] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "1" && s2 == "0" && s3 == "1" && s4 == "1")
                {
                    Console.WriteLine("Найдена ошибка во 2 разряде кода буквы, ошибка скорректирована.");
                    if (currWord[1] == '0') currWord[1] = '1';
                    else currWord[1] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "1" && s2 == "1" && s3 == "0" && s4 == "0")
                {
                    Console.WriteLine("Найдена ошибка в 3 разряде кода буквы, ошибка скорректирована.");
                    if (currWord[2] == '0') currWord[2] = '1';
                    else currWord[2] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "0" && s2 == "1" && s3 == "1" && s4 == "0")
                {
                    Console.WriteLine("Найдена ошибка в 4 разряде кода буквы, ошибка скорректирована.");
                    if (currWord[3] == '0') currWord[3] = '1';
                    else currWord[3] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "0" && s2 == "0" && s3 == "1" && s4 == "1")
                {
                    Console.WriteLine("Найдена ошибка в 5 разряде кода буквы, ошибка скорректирована.");
                    if (currWord[4] == '0') currWord[4] = '1';
                    else currWord[4] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                //Есть ли ошибки в проверочных битах
                if (s1 == "1" && s2 == "0" && s3 == "0" && s4 == "0")
                {
                    Console.WriteLine("Найдена ошибка в 1 проверочном бите буквы, ошибка скорректирована.");
                    if (currWord[5] == '0') currWord[5] = '1';
                    else currWord[5] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "0" && s2 == "1" && s3 == "0" && s4 == "0")
                {
                    Console.WriteLine("Найдена ошибка во 2 проверочном бите буквы, ошибка скорректирована.");
                    if (currWord[6] == '0') currWord[6] = '1';
                    else currWord[6] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "0" && s2 == "0" && s3 == "1" && s4 == "0")
                {
                    Console.WriteLine("Найдена ошибка в 3 проверочном бите буквы, ошибка скорректирована.");
                    if (currWord[7] == '0') currWord[7] = '1';
                    else currWord[7] = '0';
                    hammingCode[w] = currWord.ToString();
                }

                if (s1 == "0" && s2 == "0" && s3 == "0" && s4 == "1")
                {
                    Console.WriteLine("Найдена ошибка в 4 проверочном бите буквы, ошибка скорректирована.");
                    if (currWord[8] == '0') currWord[8] = '1';
                    else currWord[8] = '0';
                    hammingCode[w] = currWord.ToString();
                }
            }

            for (int w = 0; w < hammingCode.Length; w++)
            {
                string currWord = hammingCode[w];
                string bufer = "";
                for (int i = 0; i < 5; i++) bufer += currWord[i];

                if (currWord.ToString() != "000000000") Console.Write(Enum.GetName(typeof(EnglishAlph.EnglishBinary), Convert.ChangeType(bufer, typeof(Int32))));
                else Console.Write(" ");
            }
        }
    }
}
