using System;
using System.Collections.Generic;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Diving the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    //Console.WriteLine(ex.Message);
            //    Console.WriteLine("Please type a whole number." );
            //    return;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}

            //List<int> numList = new List<int>();
            //numList.Add(6);
            //numList.Add(15);
            //numList.Add(3);
            //Console.WriteLine("Please give me a number to divide by:");
            //int divideNum = Convert.ToInt32(Console.ReadLine());

            try
            {
                List<int> numList = new List<int>();
                numList.Add(6);
                numList.Add(15);
                numList.Add(3);
                Console.WriteLine("Please give me a number to divide by:");
                int divideNum = Convert.ToInt32(Console.ReadLine());

                foreach (var item in numList)
                {
                    Console.WriteLine(item / divideNum);
                }
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number." );
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please don't divide by zero.");
                return;
            }

            finally
            {
                Console.ReadLine();
            }


            //for (int i = 0; 1 < numList.Count; i++)
            //{
            //    Console.WriteLine(i / divideNum);
            //}

            //Console.ReadLine();

            //foreach (var item in numList)
            //{
            //    Console.WriteLine("Your current number is");
            //    Console.WriteLine(item.ToString());
            //}
            //Console.Read();





















            //foreach (var item in numList)
            //{
            //    int result = item / divideNum;
            //}

            //Console.WriteLine(






            //for (int index = 0; index < numList.Count; index++)
            //{
            //    var result = numList[index] / divideNum;
            //}
            //Console.WriteLine();
            //Console.ReadLine();


            //for (int index = 0; index < numList.Count; index++)
            //{
            //    numList[index] = numList[index] / divideNum;
            //}
            //Console.WriteLine(numList[] / divideNum);

        }
    }
}
