using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day3_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Add(5, 7);
            Console.WriteLine(answer);
        }

        public static int Add(int firstNum, int secondNum)
            {
            int sum = firstNum + secondNum;
            return sum;
            }



    }
}
