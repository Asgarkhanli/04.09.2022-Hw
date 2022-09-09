using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _04._09._2022_Hw
{
    internal class Program
    {
        #region Task_01
        //static void Main(string[] args)
        //{
        //    Thread thread = Thread.CurrentThread;
        //    thread.Name = "Main Thread";
        //    Console.WriteLine(thread.Name);


        //    var secThread = new Thread(Method2);
        //    secThread.Start();
        //    Method1();
        //    Method2();

        //}

        //static void Method1()
        //{
        //    for (int i = 0; i< 50; i++)
        //    {
        //        Console.WriteLine("Method1: "+ i);
        //    }
        //}
        //static void Method2()
        //{
        //    for(int i = 0; i< 50; i++)
        //    {
        //        Console.WriteLine("Method2: "+ i);
        //    }
        //}

        #endregion
        #region Task_02
        //static async Task Main(string[] args)
        //{
        //    string url = "https://catfact.ninja/fact";
        //    HttpClient client = new HttpClient();
        //    Console.WriteLine("Show me facts about cats");

        //    do
        //    {
        //        var stringResult= await client.GetStringAsync(url);
        //        Console.WriteLine(stringResult);
        //    }
        //    while (Convert.ToBoolean(Console.ReadLine()));
        //}
        #endregion
        #region Task_03
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Sumdigitsinstring("1q2w3e"));
        //    Console.WriteLine(Sumdigitsinstring("L0r3m.1p5um"));
        //    Console.WriteLine(Sumdigitsinstring(""));
        //}

        //static int Sumdigitsinstring(string str)
        //{
        //    var sum = 0;

        //    for (var i = 0; i < str.Length; i++)
        //    {
        //        if (char.IsDigit(str[i]))
        //            sum += (int)char.GetNumericValue(str[i]);
        //    }
        //    return sum;
        //}

        #endregion
        #region Task_04
        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 78, -9, 0, 23, 54, 21, 7, 86 };
        //    var top5 = numbers.OrderByDescending(x => x).Take(5);

        //    foreach (var number in top5)
        //    {
        //        Console.WriteLine($"{number}"); 
        //    }
        //}

        #endregion
        #region Task_05

        static void Main(string[] args)
        {
            string str1;
            Console.WriteLine("Input the String: ");
            str1 = Console.ReadLine();

            var strNew = WordFilt(str1);
            Console.WriteLine(" ");

            foreach(string str2 in strNew)
                Console.WriteLine(str2);
            if (str1 == " ")
                Console.WriteLine("Please, Enter the String: ");
        }

        static IEnumerable<string> WordFilt(string str)
        {
            var upperWord = str.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));
            return upperWord;
        }

        #endregion
        #region Task_06

        //static void Main(string[] args)
        //{
        //    int year = 2003;
        //    Console.WriteLine(CheckYear(year)? "Leap Year" :
        //                         "Not a Leap Year");
        //}

        //static bool CheckYear(int year)
        //{
        //    if (year % 400 == 0)
        //        return true;

        //    if (year % 100 == 0)
        //        return false;

        //    if (year % 4 == 0)
        //        return true;
        //    return false;

        //}

        #endregion
    }
}
