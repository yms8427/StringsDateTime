using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.StringsAndDateTime.Helpers
{
    class StringHelper
    {
        public string GetUpperCase(string text)
        {
            return text.ToUpper(CultureInfo.GetCultureInfo("en-US"));
            //return text.ToUpper();//makinenin diline göre çalışır
        }

        public string GetLowerCase(string text)
        {
            return text.ToLower();
        }

        public string ReplaceWord(string text, string original, string replacement)
        {
            return text.Replace(original, replacement);
        }

        public string GetLength(string text)
        {
            return text.Length.ToString();
        }

        public string GetIndex(string text, char character)
        {
            //TODO: Kaç kez ve nerelerde "I" geçmiş 
            return text.IndexOf(character).ToString();
        }

        public string GetWordCount(string text)
        {
            var words = text.Split(' ', ',', '.', '?', '!');
            //var total = 0;
            //foreach (var word in words)
            //{
            //    total += word.Length;
            //}
            return words.Length.ToString();
        }

        public string GetCustomCalculation(string text)
        {
            //21+5-3
            var numbers = text.Split('+', '-');
            foreach (var number in numbers)
            {
                var op = text.Substring(number.Length, 1);
                switch (op)
                {
                    case "+":
                        return "Topla";
                        break;
                    case "-":
                        return "Çıkar";
                        break;
                }
            }
            return "Error";
        }
    }
}
