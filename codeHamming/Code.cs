using System;

namespace codeHamming
{
    class Code
    {
        //Создание кода для введённой строки английского текста
        public void CodeH(string input)
        {
            //Все содержащиеся буквы переводим в нижний регистр
            input = input.ToLower();
            //Циклом идём по всем символам ввода
            for (int s = 0; s < input.Length; s++)
            {
                //Получаем информационную часть (символ) в двоичном виде
                EnglishAlph english = new EnglishAlph();
                string binary = english.CharToBinary(input[s].ToString());
                //Console.WriteLine("Код символа в бинарном виде: {0}", binary);

                //Кодируем, заполняем информационные биты кода Хемминга (9,4)
                //Массив для хранения кода
                string[] codeHamming = new string[binary.Length + 4];

                for (int i = 0; i < codeHamming.Length; i++)
                {
                    if (i < 5)
                    {
                        codeHamming[i] = binary[i].ToString();
                    }
                    else
                    {
                        if (i == 5) codeHamming[i] = Xor(binary[1].ToString(), binary[2].ToString());
                        if (i == 6) codeHamming[i] = Xor(Xor(binary[0].ToString(), binary[2].ToString()), binary[3].ToString());
                        if (i == 7) codeHamming[i] = Xor(Xor(binary[1].ToString(), binary[3].ToString()), binary[4].ToString());
                        if (i == 8) codeHamming[i] = Xor(Xor(binary[0].ToString(), binary[1].ToString()), binary[4].ToString());
                    }
                }

                //Выводим полученное значение кода на консоль
                foreach (string ch in codeHamming) Console.Write(ch);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        //Бинарная операция исключающее ИЛИ - XOR
        public string Xor(string a, string b)
        {
            string result = "0";
            if (a == "0" && b == "0" || a == "1" && b == "1") result = "0";
            else result = "1";
            return result;
        }
    }
}
