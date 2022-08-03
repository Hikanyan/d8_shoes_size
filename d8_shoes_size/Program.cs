// https://paiza.jp/works/mondai/drankfast/d8_shoes_size
using System;

class Program
{
    static void Main()
    {
        float US = 0.0f;
        float UK = 0.0f;
        float s =float.Parse( Console.ReadLine());
        US = (float)(s - 18.0);
        UK = (float)(s - 18.5);
        Console.WriteLine($"{US.ToString("0.0")} {UK.ToString("0.0")}");
    }
}