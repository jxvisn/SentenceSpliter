using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SentenceSpliter
{
    class Program
    {
        static void Main(string[] args)
        {

            //GreetUser
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine("Hello {0}!", userName);
            Console.WriteLine("Enter a random sentence to be split:");
            //AskUserForInput
            Console.WriteLine("Enter a sentence: ");
            var sentence = Console.ReadLine();

            //Split this string and put into an Array
            var arrayOfWords = sentence.Split(' ');

            var newSentence = string.Join("", arrayOfWords);

            Console.WriteLine(newSentence.ToUpper());

        }
    }
}
