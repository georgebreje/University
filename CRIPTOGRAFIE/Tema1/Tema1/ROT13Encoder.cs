using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    public static class ROT13Encoder
    {
        public static string ROT13(this string input)
        {
            string encodedText = "";

            foreach (var c in input)
            {
                if (c > 'w')
                {
                    encodedText += Convert.ToChar('a' + 13 - 1);
                }
                else if (c < 'a' && c > 'W')
                {
                    encodedText += Convert.ToChar('A' + 13 - 1);
                }
                else
                {
                    encodedText += Convert.ToChar(c + 3);
                }
            }

            return encodedText;
        }
    }
}
