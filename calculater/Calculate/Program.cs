using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate
{
    class Program
    {
        public static string[] valList;
        

        //program start 
        static void Main(string[] args)
        {           
                try
                {
                    startAgain();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong , but lets start for the bigining ");
                    startAgain();
                }          
        }

       //start calculate 
        static void startAgain()
        {
            Console.WriteLine("Please enter command:");
            var input = Console.ReadLine();

            //checking first command           
             valList = input.Split(' ');
            if (valList[0] != "Calculate")
            {
                //error display 
                Console.WriteLine("Please enter valide command ex 'Calculate' ");
                startAgain();
            }

            if (valList[1] == "max")
            {
                GetMax();
            }
            else {
                GetMin();
            }
            //no valide command added 
            Console.WriteLine("Please enter valide logic : 'max' or' min' ");
        }

        static void GetMax()
        {
            var maxVal = 0;
            foreach (string item in valList)
            {
                int ongoingNumber = 0;
                //check is number 
                if (int.TryParse(item, out ongoingNumber))
                {
                    if (ongoingNumber > maxVal)
                        maxVal = ongoingNumber;
                }
            }
            //display result "the Max is 
            Console.WriteLine("The max  is :" + maxVal);
            Console.ReadLine();
            startAgain();
        }

        static void GetMin()
        {
            var minVal = 0;
            var isFirstVal = true;
            foreach (string item in valList)
            {
                int ongoingNumber = 0;
                //check is number 
                if (int.TryParse(item, out ongoingNumber))
                {
                    if (isFirstVal)
                    {
                        minVal = ongoingNumber;
                        isFirstVal = false;
                    }
                    if (ongoingNumber < minVal)
                        minVal = ongoingNumber;
                }
            }
            //display result "the Max is 
            Console.WriteLine("The min is :" + minVal);
            Console.ReadLine();
            startAgain();
        }
    }
}
