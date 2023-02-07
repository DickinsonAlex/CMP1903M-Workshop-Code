using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Week 2
            //Read in the items from streetCodes.txt
            List<string> streetCodes = new List<string>();
            streetCodes = System.IO.File.ReadAllLines(@"C:\Users\james\source\repos\CMP1903M Workshop Code\CMP1903M Workshop Code\streetCodes.txt").ToList();

            //Second two variables here are to use when calculating the checksum
            int checkSum = 8;
            int total = 1;
            int total2 = 0;

            //Loop through each item in the list
            foreach (string streetCode in streetCodes)
            {
                //Convert streetcode to int
                int streetCodeInt = Convert.ToInt32(streetCode.Substring(0,4));

                //Get the checksum for streetCodeInt
                int checkSum2 = streetCodeInt % checkSum;

                if (checkSum2 == Convert.ToInt32(streetCode.Substring(5, 1)))
                {
                    Console.WriteLine(streetCode);
                }
            }
        }
    }
}
