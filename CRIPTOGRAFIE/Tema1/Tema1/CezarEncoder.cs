using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    public static class CezarEncoder
    {
        #region Algorithm
        public static string Encode(this string input)
        {
            string encodedText = "";

            foreach (var c in input)
            {
                if (Char.IsLetter(c))
                {
                    if (c > 'w')
                    {
                        encodedText += Convert.ToChar('a' + 2);
                    }
                    else if (c < 'a' && c > 'W')
                    {
                        encodedText += Convert.ToChar('A' + 2);
                    }
                    else
                    {
                        encodedText += Convert.ToChar(c + 3);
                    }
                }
            }

            return encodedText;
        }

        public static string Encode(this string input, int length)
        {
            string encodedText = "";

            foreach (var c in input)
            {
                if (c > 'w')
                {
                    encodedText += Convert.ToChar('a' + length - 1);
                }
                else if (c < 'a' && c > 'W')
                {
                    encodedText += Convert.ToChar('A' + length - 1);
                }
                else
                {
                    encodedText += Convert.ToChar(c + 3);
                }
            }

            return encodedText;
        }
        #endregion
        
    }
}
