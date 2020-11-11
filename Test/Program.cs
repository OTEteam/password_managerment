using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Please enter a string to encrypt:");
            string plaintext = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine(plaintext);

            Console.WriteLine("Your encrypted string is:");
            string encryptedstring = StringCipher.Encrypt(plaintext, StringCipher.DefaultPsw);
            Console.WriteLine(encryptedstring);
            Console.WriteLine("");

            Console.WriteLine("Your decrypted string is:");
            string decryptedstring = StringCipher.Decrypt("uXKKpHOB2lVVO2yO3nv/BaWMIcGGy/MC2rghYGYqkdYaNGxcEatjaiQ+7o5Nte4bxjOHXLWlXxMaSk0RX/DoBg7NL905Z2gZfeOTK3lWqr/gK65mSr7ZCt/RnmGpm/Ei", StringCipher.DefaultPsw);
            Console.WriteLine(StringCipher.Encrypt("123", StringCipher.DefaultPsw) == StringCipher.Encrypt("123", StringCipher.DefaultPsw));
            Console.WriteLine(decryptedstring);
            Console.WriteLine("");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
