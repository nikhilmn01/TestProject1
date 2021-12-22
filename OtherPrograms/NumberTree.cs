using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.OtherPrograms
{
    public class NumberTree
    {
        [Test]
        public static void main()
        {
            List<List<int>> tree = getTree(5);
            isPrime.Check(3013);
            Console.WriteLine(isPrime.nextPrime(3013));
        }
        public static List<List<int>> getTree(int height)
        {
            List<List<int>> requiredTree = new List<List<int>>();
            int startingItem = 10;
            startingItem = isPrime.nextPrime(startingItem);
            for (int i = 0; i < height; i++)
            {
                List<int> rowItems = new List<int>();
                for (int j = 0; j < Math.Pow(2, i); j++)
                {
                    rowItems.Add(startingItem++);
                    startingItem = isPrime.nextPrime(startingItem);
                }
                requiredTree.Add(rowItems);
            }
            return requiredTree;
        }     
    }


    internal class isPrime
    {
        public static int nextPrime(int num)
        {
            int i = 0;
            num++;
            for (i = num; true; i++)
            {
                int counter = 0;
                for (num = i; num >= 1; num--)
                {
                    if (i % num == 0)
                    {
                        counter = counter + 1;
                    }
                }
                if (counter == 2)
                {
                    return i;
                }
            }

        }

        public static int Check(int num)
        {
            int i, m = 0, flag = 0;
            //num = 3;// it is the number to be checked
            m = num / 2;
            if (num == 0 || num == 1)
            {
                Console.WriteLine(num + " is not prime number");
            }
            else
            {
                for (i = 2; i <= m; i++)
                {
                    if (num % i == 0)
                    {
                        Console.WriteLine(num + " is not prime number");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(num + " is prime number");
                }
            }
            return num;
        }

    }

    
}
