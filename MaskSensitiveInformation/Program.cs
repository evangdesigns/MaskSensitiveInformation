using System;

namespace MaskSensitiveInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me your secrets");
            var secret = Console.ReadLine();
            var ast = '*';

            if (secret.Length > 4)
            {
                Console.WriteLine(
                    string.Concat(
                    "".PadLeft(secret.Length - 4, ast),
                    secret.Substring(secret.Length - 4)
                    )
                );
            }

            Console.ReadKey();
        }
    }
}
