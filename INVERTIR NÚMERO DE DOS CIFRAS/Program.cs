    using System;

namespace INVERTIR_NÚMERO_DE_DOS_CIFRAS
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int rem = 0;
            int reverse = 0;
            Console.WriteLine("Digite el numero para invertirlo");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.WriteLine("Es: " + reverse);
        }
    }
}
