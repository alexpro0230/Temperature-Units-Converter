using System;
using Temperature_Units_Converter;
public class unitsConverter
{

    //FAHRENHEIT
    public static void fToC()
    {
        float output = (Program.input - 32) / 1.8f;
        Console.WriteLine(output);
    }

    public static void fToK()
    {
        float output = (Program.input - 32) / 1.8f + 273.15f;
        Console.WriteLine(output);
    }

    //CELSIUS

    public static void CtoF()
    {
        float output = (Program.input * 1.8f) + 32;
        Console.WriteLine(output);
    }

    public static void cToK()
    {
        float output = Program.input + 273.15f;
        Console.WriteLine(output);
    }

    //KELVIN

    public static void kToF()
    {
        float output = (Program.input - 273.15f) * 1.8f + 32;
        Console.WriteLine(output);
    }

    public static void kToC()
    {
        float output = Program.input - 273.15f;
        Console.WriteLine(output);
    }
}
