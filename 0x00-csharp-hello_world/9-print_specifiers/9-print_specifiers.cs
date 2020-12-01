using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
		double currency = 98765.4321;
		Console.WriteLine("{0:0.00%}", percent);
        Console.WriteLine("{0:C}", currency);
    }
}
