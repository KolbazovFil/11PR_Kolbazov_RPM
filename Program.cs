using System;
using System.Text.RegularExpressions;
namespace ConsoleApp
{
    class NumAndStr //Задание 1: Напишите регулярное выражение для проверки, содержит ли строка только буквы и цифры.
    {
        private string Str { get; set; }
        public NumAndStr(string str)
        {
            string pattern = "^[а-яА-Яa-zA-Z0-9]+$";  // (^) - начало строки, ([]) - определяют класс символов, (+) - одно или более вхождений, ($) - конц строки
            if (Regex.IsMatch(str, pattern))    // Проверяем строку на соответствие регулярному выражению
            {
                Str = str;
            }
            else
            {
                throw new Exception("Строка должна содержать только буквы и цифры!");
            }
        }
        public void Display()
        {
            Console.WriteLine($"Строка содержит только буквы и цифры!");
        }
    }
    class StrDate  // Задание 2: Напишите регулярное выражение для извлечения всех дат в формате \"dd.mm.yyyy\" из текстового документа.
    {
        private string Str { get; set; }
        private MatchCollection Matches { get; set; } // Поле для хранения совпадений
        public StrDate(string str)
        {
            // (@) - позволяет использовать обратные слэши (\) без необходимости их экранирования.
            string pattern = @"\b\d{2}\.\d{2}\.\d{4}\b";    // (\b) - граница, (\d{2}) - две цифры, (\.) - точка, (\d{4}) - четыре цифры
            Matches = Regex.Matches(str, pattern);
            if (Matches.Count > 0)
            {
                Str = str;
            }
            else
            {
                throw new Exception("Даты в формате \"dd.mm.yyyy\" не найдены!");
            }
        }
        public void Display()
        {
            Console.WriteLine("Найденны следующие даты:");
            foreach (Match match in Matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
    class StrEmail  //Задание 3: Напишите регулярное выражение для проверки, соответствует ли строка формату электронной почты.
    {
        private string Str { get; set; }
        // (@) - позволяет использовать обратные слэши (\) без необходимости их экранирования.
        // ^ - начало строки, [\w-]+ - последовательность, состоящая из латинских букв, цифр, символа подчеркивания (_) или дефиса (-), плюс (+) указывает на то, что таких символов должно быть как минимум один
        // (\.[\w-]+)* - это группа, которая проверяет наличие точки перед следующей частью, за которой следует снова последовательность букв и/или цифр.
        // знак * означает, что эта группа может присутствовать ноль или более раз.
        // @ - символ собачки
        // ([\w-]+\.) - соответствует доменной части адреса. только точка в конце. Плюс указывает на то, что таких групп может быть несколько.
        // [a-zA-Z]{2,7} - позволяет использовать буквы от 2 до 7 символов.
        // $ - конец строки
        public StrEmail(string str)
        {
            string pattern = @"^[\w-]+(\.[\w-]+)*@([\w-]+\.)+[a-zA-Z]{2,7}$";
            if (Regex.IsMatch(str, pattern))
            {
                Str = str;
            }
            else
            {
                throw new Exception("строка не соответствует формату электронной почты!");
            }
        }
        public void Display()
        {
            Console.WriteLine($"Строка соответствует  формату электронной почты!");
        }
    }
    class StrURL    //Задание 5: Напишите регулярное выражение для извлечения всех ссылок(URL) из текстового документа.
    {
        private string Str { get; set; }
        public StrURL(string str)
        {
            string pattern = @"\bhttps?://[^\s/$.?#].[^\s]*\b|www\.[^\s]+\.[^\s]+\b";
            if (Regex.IsMatch(str, pattern))
            {
                Str = str;
            }
            else
            {
                throw new Exception("Ссылки в формате (URL) не найдены!");
            }
        }
        public void Display()
        {
            Console.WriteLine($"Ссылки в тексте:");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Задание 1: Напишите регулярное выражение для проверки, содержит ли строка только буквы и цифры.");
            //Console.Write("Введите строку: ");
            //string str = Console.ReadLine();
            //try
            //{
            //    NumAndStr Str = new NumAndStr(str);
            //    Str.Display();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            // -------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("\nЗадание 2: Напишите регулярное выражение для извлечения всех дат в формате \"dd.mm.yyyy\" из текстового документа.");
            //Console.Write("Введите строку: ");
            //string strDate = Console.ReadLine();
            //try
            //{
            //    StrDate Str = new StrDate(strDate);
            //    Str.Display();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            // -------------------------------------------------------------------------------------------------------------------------------------------------------------
            //Console.WriteLine("\nЗадание 3: Напишите регулярное выражение для проверки, соответствует ли строка формату электронной почты.");
            //Console.Write("Введите строку: ");
            //string strEmail = Console.ReadLine();
            //try
            //{
            //    StrEmail Str = new StrEmail(strEmail);
            //    Str.Display();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            // -------------------------------------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\nЗадание 5: Напишите регулярное выражение для извлечения всех ссылок(URL) из текстового документа.");
            Console.Write("Введите строку: ");
            string strURL = Console.ReadLine();
            try
            {
                StrURL Str = new StrURL(strURL);
                Str.Display();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




            Console.ReadLine();
        }
    }



    //Задание 4: Напишите регулярное выражение для замены всех вхождений чисел в строке на слово &quot; NUMBER&quot;.



    //Задание 6: Напишите регулярное выражение для проверки, содержит ли строка хотя бы одну заглавную букву.

    //Задание 7: Напишите регулярное выражение для извлечения всех номеров телефонов в формате &quot;+XXX-XXX-XXXXXXX&quot; из текстового документа.

    //Задание 8: Напишите регулярное выражение для проверки, содержит ли строка хотя бы одно слово, начинающееся с заглавной буквы.

    //Задание 9: Напишите регулярное выражение для замены всех вхождений слов &quot; apple&quot; и &quot;orange&quot; в строке на &quot;fruit&quot;.

    //Задание 10: Напишите регулярное выражение для проверки, соответствует ли строка формату IP-адреса.
}