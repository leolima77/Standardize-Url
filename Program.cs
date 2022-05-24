using System;

namespace ReplaceCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "átençÃo sômóñ";
            string newWord = "";

            string[] characters = { 
                                    "áÁàÀâÂäÄãÃåÅæÆçÇéÉèÈêÊëËíÍìÌîÎïÏñÑóÓòÒôÔöÖõÕøØœŒßúÚùÙûÛüÜ",
                                    "aAaAaAaAaAaAaAcCeEeEeEeEiIiIiIiInNoOoOoOoOoOoOcCBuUuUuUuU"
                                  };

            for (int i = 0; i < input.Length; i++)
            {
                if (characters[0].IndexOf(Convert.ToChar(input.Substring(i, 1))) >= 0)
                {
                    int car = characters[0].IndexOf(Convert.ToChar(input.Substring(i, 1)));
                    newWord += characters[1].Substring(car, 1);
                }
                else
                {
                    newWord += input.Substring(i, 1);
                }
            }

            Console.WriteLine(newWord);
        }
    }
}
