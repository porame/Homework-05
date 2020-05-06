using System;

namespace Mana
{
    class Program
    {
        static void Main(string[] args)
        {

            String num1 = " ";
            String num2 = " ";
            String num3 = " ";
            String num4 = " ";
            String num5 = " ";
            String num6 = " ";
            String num7 = " ";
            String num8 = " ";
            String num9 = " ";
            String numA = " ";
            int k = 1;

            Console.WriteLine("["+num1+"]"+ "[" + num2 + "]" + "[" + num3 + "]" + "[" + num4 + "]" + "[" + num5 + "]" + "[" + num6 + "]" +
                "[" + num7 + "]" + "[" + num8 + "]" + "[" + num9 + "]" + "[" + numA + "]");
            Console.WriteLine(" 1  2  3  4  5  6  7  8  9  A");
            
            do
            {
                Console.WriteLine("Please choose LED to turn On/Off: ");
                String numLED = Console.ReadLine();
                if (numLED == "A" | numLED == "a")
                {
                    if(numA == " ")
                    {
                        numA = "!";
                    }
                    else
                    {
                        numA = " ";
                    }
                }
                else if(Int32.Parse(numLED) == 1)
                {
                    if (num1 == " ")
                    {
                        num1 = "!";
                    }
                    else
                    {
                        num1 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 2)
                {
                    if (num2 == " ")
                    {
                        num2 = "!";
                    }
                    else
                    {
                        num2 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 3)
                {
                    if (num3 == " ")
                    {
                        num3 = "!";
                    }
                    else
                    {
                        num3 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 4)
                {
                    if (num4 == " ")
                    {
                        num4 = "!";
                    }
                    else
                    {
                        num4 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 5)
                {
                    if (num5 == " ")
                    {
                        num5 = "!";
                    }
                    else
                    {
                        num5 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 6)
                {
                    if (num6 == " ")
                    {
                        num6 = "!";
                    }
                    else
                    {
                        num6 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 7)
                {
                    if (num7 == " ")
                    {
                        num7 = "!";
                    }
                    else
                    {
                        num7 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 8)
                {
                    if (num8 == " ")
                    {
                        num8 = "!";
                    }
                    else
                    {
                        num8 = " ";
                    }
                }
                else if (Int32.Parse(numLED) == 9)
                {
                    if (num9 == " ")
                    {
                        num9 = "!";
                    }
                    else
                    {
                        num9 = " ";
                    }
                }
                Console.WriteLine("[" + num1 + "]" + "[" + num2 + "]" + "[" + num3 + "]" + "[" + num4 + "]" + "[" + num5 + "]" + "[" + num6 + "]" +
                   "[" + num7 + "]" + "[" + num8 + "]" + "[" + num9 + "]" + "[" + numA + "]");
                Console.WriteLine(" 1  2  3  4  5  6  7  8  9  A");
            } while (k == 1);
        }
    }
}