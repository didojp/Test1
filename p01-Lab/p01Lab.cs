using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p01_Lab
{
    class p01Lab
    {
        static void Main(string[] args)
        {
            //задача- да при зададен стринг от думи да се изведе на конзолата тези от тях, които имат повторения нечетен брой пъти.
            // изхода(резултата) да не е кейсензитив(малки- големи букви)

            string[] words = Console.ReadLine().Split(' '); // 1. правим масив(по добре да почнем със стринг и всичко на веднъж), който пълним със стринга от входа. Split() винаги връща масив от стрингове.
            var wordCount = new Dictionary<string, int>(); // 2. създаваме речник в който като ключове записваме масива, а като стойности- бройките повторения.

            foreach (var word in words) // 3.  правим foreach, за да обходим стринга. 
            {
                string wordToLower = word.ToLower(); //7. създаваме стринг да приравним всички букви ToLower case; Масива не разпозава ToLower;
                if (wordCount.ContainsKey(wordToLower)) //4.
                {
                    wordCount[wordToLower]++; // 5. създаваме брояч с който броим повтарящите се прималени думи и ги записваме в речника. бройките пъти са Value в речника.
                }
                else
                {
                    wordCount[wordToLower] = 1; //6. ако пък думата излиза за пръв път- даваме и стойност 1( така я записваме в речника).
                }

            }
            var result = new List<string>();
            foreach (var kvp in wordCount) // 8. правим foreach с който да обходим речника за четни и нечетни повтарящи се думи. KVP- KEY VALUE PAIRED!!!
            {
                var word = kvp.Key;    //9. правим променливи изразяващи ключа и стойностите на думите, които изследваме.
                var count = kvp.Value;
                if (kvp.Value%2==1)
                {
                    result.Add(word);

                }
            }
            Console.WriteLine(string.Join(",", result));


            
        }
    }
}
