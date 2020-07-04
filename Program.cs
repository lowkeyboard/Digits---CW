/*  CW Solution to Digital Root problem. 
      16  -->  1 + 6 = 7
   942  -->  9 + 4 + 2 = 15  -->  1 + 5 = 6
132189  -->  1 + 3 + 2 + 1 + 8 + 9 = 24  -->  2 + 4 = 6
493193  -->  4 + 9 + 3 + 1 + 9 + 3 = 29  -->  2 + 9 = 11  -->  1 + 1 = 2


*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Authentication;
using System.Xml.Schema;

namespace RootDigital
{
    class Program
    {

        public int DigitalRoot(long n)
        {

            string someString = n.ToString();


            List<char> charArr = new List<char>();
            List<double> dList = new List<double>();

            char[] charAr = new char[] { };

            charAr = someString.ToCharArray();


            foreach (var digit in charAr)
            {
                charArr.Add(digit);
                double toSum = Char.GetNumericValue(digit);


                double total = charArr.Sum(x => Char.GetNumericValue(x));
                dList.Add(total);


            }

            List<int> intList = dList.ConvertAll(x => (int)x);
            int lastIndex = intList.Count();


            while (intList[lastIndex - 1] > 9)
            {
                return DigitalRoot(intList[lastIndex - 1]);
            };



            return intList[lastIndex - 1];
        }


        static void Main(string[] args)
        {

            {
                Program c = new Program();

                Console.WriteLine(c.DigitalRoot(1235));

            }
        }
    }
}

