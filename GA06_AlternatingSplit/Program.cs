using System;
using System.Linq;

namespace GA06_AlternatingSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Encrypt("This is a test!", 2);
        }

        // For building the encrypted string:

        // Take every 2nd character from the string,
        // then the other characters that are not every 2nd character,
        // and concat them as a new String.
        // Do this n times!

        // To do the above, you must build an encrypt(message, n) method that performs like this:

        // encrypt("This is a test!", 1) -> "hsi  etTi sats!"
        // encrypt("This is a test!", 2) -> "s eT ashi tist!"



        // TO BE CHECKED:
        // where define local var
        // Linq

        static void Encrypt(string message, int n)
        {
            string secondCharactors, otherCharactors, newMessage = message;

            for (int i=1; i<=n; i++)
            {
                // take 2nd charactor from "message" and push to "secondCharactors"
                secondCharactors = new string(newMessage.Where((ch, index) => (index+1) % 2 == 0).ToArray());
                // push all other charactors to "otherCharactors"
                otherCharactors = new string(newMessage.Where((ch, index) => (index + 1) % 2 != 0).ToArray());
                // join two strings
                newMessage = String.Concat(secondCharactors, otherCharactors);
            }

        }
    }
}
