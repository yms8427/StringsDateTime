using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

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
        
        public void StringOrder()
        {
            var sample = "Türkiye";
            var r1 = sample.CompareTo("Almanya");
            var r2 = sample.CompareTo("Yemen");
            var r3 = sample.CompareTo("Türkiye");
        }

        public void SubString(string text)
        {
            var cropped1 = text.Substring(5);
            var cropped2 = text.Substring(5, 10);
            var path = @"C:\Program Files\Windows Photo Viewer\acq.dll";
            var name = path.Substring(path.LastIndexOf(@"\") + 1);
            var url = "https://www.canperk.com/main/photos";
            var indexOfFirstDivider = url.IndexOf('/', 8);
            var start = 8;
            var site = url.Substring(start, indexOfFirstDivider - start);

            //TO BE CONTINUED
            var f = new FileInfo(path);
            var fName = f.Name;

            var u = new Uri(url);
            var siteName = u.Authority;
        }

        public void Trim()
        {
            var list = new List<string>();
            AddIfNotExists(list, "Can");
            AddIfNotExists(list, " Can");
            AddIfNotExists(list, "Can ");
            AddIfNotExists(list, "   Can");
            AddIfNotExists(list, "Can     ");
            AddIfNotExists(list, "    Can     ");
            AddIfNotExists(list, "  Can   ");
            AddIfNotExists(list, "               Can");
            var result = list.Count;
        }

        private void AddIfNotExists(List<string> list, string value)
        {
            var trimmed = value.Trim();
            if (!list.Contains(trimmed))
            {
                list.Add(trimmed);
            }
        }
    }
}
