using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckVowelOrConsonant
{
    public class checkVowel
    {
        public static void checkVowelorConsonant()
        {
            char ch=Convert.ToChar(Console.ReadLine());
            if(ch =='a'|| ch=='e'|| ch=='i'||ch=='o'||ch=='u'||ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
            {
                Console.WriteLine(ch + " is a vowel.");
            }
            else if((ch >='a' && ch <='z')||(ch>='A' && ch<='Z'))
            {
                Console.WriteLine(ch + " is a Consonant.");
            }
            else
            {
                Console.WriteLine("Enter only an alphabet.");
            }
        }
    }
}
