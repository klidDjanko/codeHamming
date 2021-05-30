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
                //Кодируем, заполняем информационные биты кода Хемминга (9.4)
                string[] codeHamming = new string[binary.Length + 4];

                //Заполняем блоки с проверочными битами
                for(int j = 0; j < codeHamming.Length; j++)
                {
                    if (Math.Log(j + 1, 2) % 1 == 0)
                    {
                        if (j + 1 == 1) codeHamming[j] = Xor(binary[1].ToString(), binary[2].ToString());
                        if (j + 1 == 2) codeHamming[j] = Xor(Xor(binary[0].ToString(), binary[2].ToString()), binary[3].ToString());
                        if (j + 1 == 4) codeHamming[j] = Xor(Xor(binary[1].ToString(), binary[3].ToString()), binary[4].ToString());
                        if (j + 1 == 8) codeHamming[j] = Xor(Xor(binary[0].ToString(), binary[1].ToString()), binary[4].ToString());
                    }
                }
                //Заполняем блоки с информационными битами
                for (int i = 0; i < binary.Length; i++)
                {
                    for (int j = 0; j < codeHamming.Length; j++)
                    {
                        if (Math.Log(j + 1, 2) % 1 != 0 && codeHamming[j] == null)
                        {
                            codeHamming[j] = binary[i].ToString();
                            break;
                        }
                    }
                }

                //Выводим полученное значение кода на консоль
                foreach(string ch in codeHamming) Console.Write(ch);
            }
        }

        //Бинарная операция исключающее ИЛИ - XOR
        string Xor(string a, string b)
        {
            string result = "0";
            if (a == "0" && b == "0" || a == "1" && b == "1") result = "0";
            else result = "1";
            return result;
        }


    }
}
