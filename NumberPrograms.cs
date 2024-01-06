using DotNetTutorials.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTutorials
{
    internal class NumberPrograms : INumberPrograms
    {
        // 256
        // 2*2*2=8, 5*5*5=125, 6*6*6=216 not.
        /// <summary>
        /// Function to find input number is armstrong number or not
        /// </summary>
        /// <param name="number"></param>
        /// <returns>True if it is armstrong number else false</returns>
        public bool IsArmstrongNumber(int number)
        {
            IEnumerable<int> numberRange = Enumerable.Range(1, 20);

            int tempNumber = 0, sum, rem;
            tempNumber = number;

            Console.WriteLine($"Input number is: {number}");

            foreach (int num in numberRange)
            {
                number = num;
                sum = 0;
                rem = 0;
                while (number > 0)
                {
                    rem = number % 10;
                    Console.WriteLine($"\nreminder is: {rem}");
                    sum = sum + (rem * rem * rem);
                    Console.WriteLine($"Sum is : {sum}");
                    number = number / 10;
                    Console.WriteLine($"number is: {number}");
                } 
            }

            return tempNumber == sum ? true : false;
        }

        public void PrintRepetedCharCount(string inputString)
        {
            //"Hi How are you"
            Dictionary<char,int> valuePairsString=new Dictionary<char, int>();
            foreach(var ch in inputString)
            {
                if(valuePairsString.ContainsKey(ch))
                {
                    valuePairsString[ch] += 1;
                }
                else
                {
                    valuePairsString.Add(ch,1);
                }
            }
            foreach(var ch in valuePairsString.Keys)
            {
                Console.WriteLine(ch +" : "+valuePairsString[ch]);
            }
        }

        public static void SumOfDigits(int number)
        { //345
            Console.WriteLine("input number is:"+number);
            int sum=0, rem = 0;
            int tempNum = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + rem;
                number = number / 10;
            }
            Console.WriteLine($"Sum of {tempNum} is {sum}");
        }
    }
}
