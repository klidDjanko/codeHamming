namespace codeHamming
{
    class EnglishAlph
    {
        public string CharToBinary(string charEng)
        {
            string result = "";
            switch(charEng)
            {
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
    }
}
