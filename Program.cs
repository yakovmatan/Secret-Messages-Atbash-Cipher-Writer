using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secret_Messages___Atbash_Cipher_Writer
{
    internal class Program
    {
        static string Encrypt(string message)
        {

            string decrypted = "";
            Dictionary<char, char> atbash = new Dictionary<char, char>()
            {
                {'a', 'z'},
                {'b', 'y'},
                {'c', 'x'},
                {'d', 'w'},
                {'e', 'v'},
                {'f', 'u'},
                {'g', 't'},
                {'h', 's'},
                {'i', 'r'},
                {'j', 'q'},
                {'k', 'p'},
                {'l', 'o'},
                {'m', 'n'},
                {'n', 'm'},
                {'o', 'l'},
                {'p', 'k'},
                {'q', 'j'},
                {'r', 'i'},
                {'s', 'h'},
                {'t', 'g'},
                {'u', 'f'},
                {'v', 'e'},
                {'w', 'd'},
                {'x', 'c'},
                {'y', 'b'},
                {'z', 'a'}
            };
            foreach (char c in message)
            {
                if (atbash.ContainsKey(char.ToLower(c)))
                {

                    decrypted += atbash[char.ToLower(c)];


                }
                else
                {
                    decrypted += c;
                }
            }
            return decrypted;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a message to encrypt:");
            string input = Console.ReadLine();

            string encrypted = Encrypt(input);

            Console.WriteLine("Encrypted message:");
            Console.WriteLine(encrypted);
        }
    }
}
