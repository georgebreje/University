using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    public class Monoalphabetic
    {
        public static char[] normalChar
        = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
            'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static char[] codedChar
            = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O',
            'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K',
            'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

        public static string Encrypt(string input)
        {
            string encryptedString = "";

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {

                    // comparing the character and
                    // adding the corresponding char
                    // to the encryptedString
                    if (input[i] == normalChar[j])
                    {
                        encryptedString += codedChar[j];
                        break;
                    }

                    // if there are any special characters
                    // add them directly to the string
                    if (input[i] < 'a' || input[i] > 'z')
                    {
                        encryptedString += input[i];
                        break;
                    }
                }
            }

            // return encryptedString
            return encryptedString;
        }
    }
}
