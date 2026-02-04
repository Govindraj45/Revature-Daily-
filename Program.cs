using System;

class Program
{
    static void Main()
    {
        int a = 5;

        Console.WriteLine("Before method call: " + a);

        IncrementValue(ref a);

        Console.WriteLine("After method call: " + a);
    }

    static void IncrementValue(ref int a)
    {
        a++;
    }
}
