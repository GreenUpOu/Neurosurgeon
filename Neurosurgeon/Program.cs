using System;

namespace Neurosurgeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Neurosurgeon neurosurgeon = new Neurosurgeon(
                Console.ReadLine(), 
                Convert.ToInt32(Console.ReadLine())
                );

            Console.WriteLine(neurosurgeon.ToString());

            neurosurgeon.make_inspection();
            neurosurgeon.make_surgery("Pavel");
            neurosurgeon.take_money(120);

            Console.ReadLine();
        }
    }
}
