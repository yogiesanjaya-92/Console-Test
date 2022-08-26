using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace CommonTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] X = { 1, 2, 3 };
            int[] Y = { 1, 3, 4 };
            int[] Z = { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
            int[] Z2 = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            int[] XX = { 0, 0, 1, 0, 0, 1, 0 };

            
            Console.WriteLine("Sort Array : {0}", changedArray(Z2));
            Console.WriteLine("Date Interval : {0}", dateInterval(new DateTime(2019, 07, 15), new DateTime(2019, 07, 18)));

            //Console.WriteLine("Sock Merchant : " + sockMerchant(9, Z));
            //Console.WriteLine("Remove Trailing Zeros : ");
            //RemoveTrailingZeros();
            //Console.WriteLine("Exception Handling : ");
            //ExceptionHandling();
            //Console.WriteLine("Aritchmetic result : " + arithmetic(3, 2));
            //Console.WriteLine("Logic result : " + logic(3, 2));
            //Console.WriteLine("Reverse sentence : " + reverse_sentence("I am programmer"));
            //Console.WriteLine("Reverse words : " + reverse_words("I am programmer"));
            //Console.WriteLine("Intersection : " + intersect(X, Y));
            //Console.WriteLine("Fibonacci : " + fibonacci(8));
            //Console.WriteLine("Pyramid of star : ");
            //pyramid(7).ToList().ForEach(Console.WriteLine);
            //Console.WriteLine("Total valley : " + countingValleys(16, "DDUUDDUUDDUUDDUU"));
            //Console.WriteLine("Socks pair : " + sockMerchant(9, Z));
            //Console.WriteLine("Socks pair : " + sockMerchant2(9, Z));
            //Console.WriteLine("Jumping clouds : " + jumpingOnClouds(XX));
            //Console.WriteLine("Repeated string : " + repeatedString("aba", 10));
            //Console.WriteLine("Summing digits : " + summingDigit(12345));
            //Console.WriteLine("Factorial : " + factorial(3));
            //Console.WriteLine("List of file : ");
            //findFiles("D:\\Sample");
            Console.ReadLine();
        }

        private static int changedArray(int[] arr)
        {
            List<int> res = new List<int>();
            Array.Sort(arr);
            foreach (int a in arr)
            {
                if (!a.Equals(arr.Max()))
                {
                    res.Add(a);
                }
            }
            return res.Last();
        }

        private static int dateInterval(DateTime startTime, DateTime endTime)
        {
            int interval = 0;
            interval = Convert.ToInt16(endTime.Subtract(startTime).TotalDays);
            return interval;
        }

        private static int sockMerchant(int n, int[] ar)
        {
            int sell = 0;
            var dict = new Dictionary<int, int>();
            foreach (var value in ar)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }

            foreach (var pair in dict)
            {
                sell = sell + pair.Value / 2;
            }
            return sell;
        }

        private static void RemoveTrailingZeros()
        {
            string Input = "1.0;1.01;1.0010;0.00;1.0050";
            string[] Process = Input.Split(';');
            Console.WriteLine("Input \t Output");
            foreach (var input in Process)
            {
                string output = "";

                output = input;
                while (output.EndsWith("0") || output.EndsWith("."))
                {
                    output = output.Remove(output.Length - 1, 1);
                }
                if (string.IsNullOrWhiteSpace(output))
                {
                    output = "0";
                }

                //Output on a console window. As shown above.
                Console.WriteLine(input + " \t\t" + output);
            }
        }

        private static void ExceptionHandling()
        {

            string strUserChoice = String.Empty;
            do
            {
                int FN = 0;
                bool success = false;

                while (!success.Equals(true))
                {
                    try
                    {
                        Console.WriteLine("Please enter first number");
                        FN = Convert.ToInt32(Console.ReadLine());
                        success = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("FormatException - " + ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("OverflowException - " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception - " + ex.Message);
                    }
                }

                int SN = 0;
                success = false;

                while (!success.Equals(true))
                {
                    try
                    {
                        Console.WriteLine("Please enter second number");
                        SN = Convert.ToInt32(Console.ReadLine());
                        success = true;
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("FormatException - " + ex.Message);
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("OverflowException - " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception - " + ex.Message);
                    }
                }

                int Total = FN + SN;
                Console.WriteLine("Total = {0}", Total);

                do
                {
                    Console.WriteLine("Do you want to continue - Yes or No");
                    strUserChoice = Console.ReadLine();
                }
                while (strUserChoice.ToUpper() != "YES"
                       && strUserChoice.ToUpper() != "NO");
            }
            while (strUserChoice.ToUpper() != "NO");
        }

        private static int arithmetic(int A, int B)
        {
            return A * B;
        }

        private static bool logic(int A, int B)
        {
            if (A > B)
            {
                return true;
            }
            return false;
        }

        private static string reverse_sentence(string S)
        {
            char[] chars = S.ToArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        private static string reverse_words(string S)
        {
            string[] words = S.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                char[] chars = words[i].ToArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }
            return string.Join(" ", words);
        }

        private static int intersect(int[] A, int[] B)
        {
            int[] intersection = A.Intersect(B).ToArray();
            if (intersection.Length == 0)
            {
                return -1;
            }
            return intersection.Min();
        }

        private static string fibonacci(int A)
        {
            int x = 0;
            int y = 1;
            int z = 0;
            int[] results = new int[A];
            for (int i = 0; i < A; i++)
            {
                if (i == 0)
                {
                    results[i] = x;
                }
                else if (i == 1)
                {
                    results[i] = y;
                }
                else
                {
                    z = x + y;
                    x = y;
                    y = z;
                    results[i] = z;
                }
            }
            return string.Join(",", results);
        }

        private static string[] pyramid(int A)
        {
            string[] results = new string[A];
            for (int i = 1; i <= A; i++)
            {
                string row = "";
                int j = A;
                while (j > i)
                {
                    row = row + " ";
                    j--;
                }
                j = 1;
                while (j < 2 * i)
                {
                    row = row + "*";
                    j++;
                }
                results[i - 1] = row;
            }
            return results;
        }

        private static int countingValleys(int n, string s)
        {
            char[] valley = s.ToArray();
            int count = 0;
            int path = 0;
            bool ValleyActive = false;

            for (int i = 0; i < n; i++)
            {
                if (valley[i].ToString() == "U")
                {
                    path++;
                }
                else
                {
                    path--;
                }
                if (!ValleyActive && path < 0)
                {
                    ValleyActive = true;
                }
                if (ValleyActive && path == 0)
                {
                    count++;
                    ValleyActive = false;
                }
            }
            return count;
        }

        private static int sockMerchant2(int n, int[] ar)
        {
            var pairsFound = 0;
            var sockColorHash = new Dictionary<int, int>();

            foreach (var sock in ar)
            {
                if (sockColorHash.ContainsKey(sock))
                {
                    pairsFound++;
                    sockColorHash.Remove(sock);
                }
                else
                    sockColorHash.Add(sock, 1);
            }
            return pairsFound;
        }

        //private static int sockMerchant(int n, int[] ar)
        //{
        //    var pairsFound = 0;
        //    var colour = ar.ToList();

        //    for (int i = 0; i < colour.Count() - 1; i++)
        //    {
        //        for (int j = i + 1; j < colour.Count() - 1; j++)
        //        {
        //            if (ar[i] == ar[j])
        //            {
        //                pairsFound++;
        //                colour.RemoveAt(i);
        //                colour.RemoveAt(j);
        //                i = j = 0;
        //            }
        //        }
        //    }
        //    return pairsFound;
        //}

        private static int jumpingOnClouds(int[] c)
        {
            int i = 0;
            int Jumps = 0;
            while (true)
            {
                if (((i + 2) < c.Length) && (c[i + 2] == 0))
                {
                    i += 2;
                }
                else if ((i + 1) < c.Length)
                {
                    i++;
                }
                else
                {
                    break;
                }
                Jumps++;
            }
            return Jumps;
        }

        private static long repeatedString(string s, long n)
        {
            var count = 0L;
            foreach (var letter in s)
            {
                if (letter == 'a')
                {
                    count++;
                }
            }
            var possibleStringRepeatitions = n / s.Length;
            count *= possibleStringRepeatitions;
            var offsetStringLength = n % s.Length;
            for (int i = 0; i < offsetStringLength; i++)
            {
                if (s[i] == 'a')
                {
                    count++;
                }
            }
            return count;
        }

        private static int summingDigit(int number)
        {
            int result = 0;
            while (number != 0)
            {
                result += number % 10;
                number /= 10;
            }

            if (result > 9)
            {
                result = summingDigit(result);
            }

            return result;
        }

        private static int factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * factorial(number - 1);
        }

        private static void findFiles(string path)
        {
            foreach (string filename in Directory.GetFiles(path))
            {
                Console.WriteLine(filename);
            }
            foreach (string directory in Directory.GetDirectories(path))
            {
                findFiles(directory);
            }
        }
    }
}
