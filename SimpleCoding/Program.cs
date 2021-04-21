using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SimpleCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In C#, write a program that parses a sentence and replaces each word with the following: first letter, number of distinct characters between first and last character, and last letter.

                For example, Smooth would become S3h.  Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer.

                 by the following:

                Words are separated by spaces or non-alphabetic characters and these separators should be maintained in their original form and location in the answer.

                For example:

                Smooth becomes S3h.

                Sign&ficant becomes S2n&f4t.

                Ac43rd0  becomes A0c43r0d0
            */

            string sentence = String.Empty;
            string resultSentence = String.Empty;

            Console.WriteLine("Write a sentence");
            sentence = Console.ReadLine();

            resultSentence = Process.GetInstance().transform(sentence);

            Console.WriteLine(string.Format("{0} becomes {1}", sentence, resultSentence));

            Console.ReadKey();
        }




    }
}
