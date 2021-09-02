using System;

namespace Temperature_Units_Converter
{
    public class Program
    {
        public static int[] unitsIntArray;
        public static int input;

        //mainly call all the funcions here
        static void Main(string[] args)
        {
            Console.WriteLine(" /__  ___/                                                                                      ");
            Console.WriteLine("   / /   ___      _   __      ___      ___      __      ___    __  ___           __      ___    ");
            Console.WriteLine("  / /  //___) ) // ) )  ) ) //   ) ) //___) ) //  ) ) //   ) )  / /   //   / / //  ) ) //___) ) ");
            Console.WriteLine(" / /  //       // / /  / / //___/ / //       //      //   / /  / /   //   / / //      //        ");
            Console.WriteLine("/ /  ((____   // / /  / / //       ((____   //      ((___( (  / /   ((___( ( //      ((____     ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    //   ) )                                                                                    ");
            Console.WriteLine("   //         ___       __              ___      __    __  ___  ___      __                     ");
            Console.WriteLine("  //        //   ) ) //   ) ) ||  / / //___) ) //  ) )  / /   //___) ) //  ) )                  ");
            Console.WriteLine(" //        //   / / //   / /  || / / //       //       / /   //       //                        ");
            Console.WriteLine("((____/ / ((___/ / //   / /   ||/ / ((____   //       / /   ((____   //                         ");

            Console.WriteLine();
            Console.WriteLine();

            unitsIntArray = new int[2];
            string[] unitsArray = askForUnitType();
            analizeUnit(unitsArray);
            askForInput();
            callFunc();
        }

        //We ask the user for their unit type
        private static string[] askForUnitType()
        {
            Console.Write("What's the unit you want to convert? ");
            string unitToConvert = Console.ReadLine();
            Console.WriteLine();
            Console.Write("To which unit you want to convert it? ");
            string unitToConvertInto = Console.ReadLine();
            string[] result = new string[2];
            result[0] = unitToConvert;
            result[1] = unitToConvertInto;
            return result;
        }

        //Here we analize the unit types and then create an array, so we can further make a conversion
        private static void analizeUnit(string[] unit)
        {
            char comparison = Convert.ToChar((unit[0]));
            string comparison2 = Convert.ToString((unit[1]));
            switch (comparison.ToString())
            {
                case "F":
                    if (comparison2 == "F")
                    {
                        unitsIntArray[0] = 1;
                        unitsIntArray[1] = 1;
                        break;
                    } else if (comparison2 == "C") {
                        unitsIntArray[0] = 1;
                        unitsIntArray[1] = 2;
                        break;
                    } else if (comparison2 == "K") {
                        unitsIntArray[0] = 1;
                        unitsIntArray[1] = 3;
                        break;
                    }
                    break;
                case "C":
                    if (comparison2 == "F")
                    {
                        unitsIntArray[0] = 2;
                        unitsIntArray[1] = 1;
                        break;
                    }
                    else if (comparison2 == "C")
                    {
                        unitsIntArray[0] = 2;
                        unitsIntArray[1] = 2;
                        break;
                    }
                    else if (comparison2 == "K")
                    {
                        unitsIntArray[0] = 2;
                        unitsIntArray[1] = 3;
                        break;
                    }
                    break;
                case "K":
                    if (comparison2 == "F")
                    {
                        unitsIntArray[0] = 3;
                        unitsIntArray[1] = 1;
                        break;
                    }
                    else if (comparison2 == "C")
                    {
                        unitsIntArray[0] = 3;
                        unitsIntArray[1] = 2;
                        break;
                    }
                    else if (comparison2 == "K")
                    {
                        unitsIntArray[0] = 3;
                        unitsIntArray[1] = 3;
                        break;
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Input. Usage => C, F, K. Your input: " + Convert.ToChar(Convert.ToInt32(unit[0])));
                    return;
                    break;
            }
        }

        //We gather the temperature
        private static void askForInput()
        {
            Console.WriteLine("Value: ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        //We call the needed function acording to our unt type
        private static void callFunc()
        {
            if(unitsIntArray[0] == unitsIntArray[1])
            {
                Console.WriteLine(input);
                return;
            }

            if(unitsIntArray[0] == 1)
            {
                if(unitsIntArray[1] == 2)
                {
                    unitsConverter.fToC();
                }
                else if(unitsIntArray[1] == 3)
                {
                    unitsConverter.fToK();
                }
            }
            else if(unitsIntArray[0] == 2)
            {
                if(unitsIntArray[1] == 1)
                {
                    unitsConverter.CtoF();
                }
                else if(unitsIntArray[1] == 3)
                {
                    unitsConverter.cToK();
                }
            }
            else if(unitsIntArray[0] == 3)
            {
                if(unitsIntArray[1] == 1)
                {
                    unitsConverter.kToC();
                }
                else if(unitsIntArray[1] == 2)
                {
                    unitsConverter.kToF();
                }
            }
        }
    }
}
