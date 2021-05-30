namespace codeHamming
{
    class EnglishAlph
    {
        public string CharToBinary(string charEng)
        {
            string result = "";
            switch(charEng)
            {
                case " ": result = "00000";
                    break;
                case "a": result = "00001";
                    break;
                case "b": result = "00010";
                    break;
                case "c": result = "00011";
                    break;
                case "d": result = "00100";
                    break;
                case "e": result = "00101";
                    break;
                case "f": result = "00110";
                    break;
                case "g": result = "00111";
                    break;
                case "h": result = "01000";
                    break;
                case "i": result = "01001";
                    break;
                case "j": result = "01010";
                    break;
                case "k": result = "01011";
                    break;
                case "l": result = "01100";
                    break;
                case "m": result = "01101";
                    break;
                case "n": result = "01110";
                    break;
                case "o": result = "01111";
                    break;
                case "p": result = "10000";
                    break;
                case "q": result = "10001";
                    break;
                case "r": result = "10010";
                    break;
                case "s": result = "10011";
                    break;
                case "t": result = "10100";
                    break;
                case "u": result = "10101";
                    break;
                case "v": result = "10110";
                    break;
                case "w": result = "10111";
                    break;
                case "x": result = "11000";
                    break;
                case "y": result = "11001";
                    break;
                case "z": result = "11010";
                    break;
            }
            return result;
        }

        public enum EnglishBinary
        {
            a = 00001,
            b = 00010,
            c = 00011,
            d = 00100,
            e = 00101,
            f = 00110,
            g = 00111,
            h = 01000,
            i = 01001,
            j = 01010,
            k = 01011,
            l = 01100,
            m = 01101,
            n = 01110,
            o = 01111,
            p = 10000,
            q = 10001,
            r = 10010,
            s = 10011,
            t = 10100,
            u = 10101,
            v = 10110,
            w = 10111,
            x = 11000,
            y = 11001,
            z = 11010
        }
    }
}
