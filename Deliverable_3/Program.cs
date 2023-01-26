using System;
namespace Deliverable_3
{
    class Program
    {
        static void Main(string[] args)

        {
            Boolean done = false;
            while(!done)
            {

            
               try
                {
                int input = 0;
                string series = "";

                while (true)
                {
                    Console.WriteLine("Please enter an integer between 1 and 100");
                    input = int.Parse(Console.ReadLine());

                    if (input < 1 && input > 100)
                    {
                        //Console.WriteLine("Make sure you input a whole number no less than 1 and no greater than 100");
                        break;
                    }
                    // }

                    // while(true);
                    {
                        Console.WriteLine("Would you like the even or the odd numbers in the series?");
                        series = Console.ReadLine();

                        if (series == "odd" || series == "Odd")
                        {
                            Console.WriteLine("All of the " + series + " numbers from 0 to " + input + " are ");
                            for (int i = 1; i <= input; i = i + 2)
                            {
                                Console.WriteLine(i);
                                


                            }
                                Console.WriteLine("Thank you.");
                            }
                        else
                            {
                                Console.WriteLine("Please only input either 'even' or 'odd', Start Over.");
                                
                            }
                        if (series == "even" || series == "Even")
                        {
                            Console.WriteLine("All of the " + series + " numbers from 0 to " + input + " are ");
                            for (int i = 2; i <= input; i = i + 2)
                            {
                                Console.WriteLine(i);
                              

                            }
                                Console.WriteLine("Thank you");
                        }

                    }
                    break;

                }
            }

            catch
            {
                Console.WriteLine("please enter the correct data type");
            }
        }
    }
    }
}
    
