using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSecProject
{
    class CaesarCipher
    {
        static string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string output = null;
        static char[] letter = alpha.ToCharArray();
        static char[] input = null;
        static int res = 0;

        public static string Encryption(string Plain_Text, int shift)
        {
            input = Plain_Text.ToUpper().ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (input[j] == letter[i])
                    {
                        input[j] = letter[(i + shift) % letter.Length];
                        break;
                    }
                }
            }
            output = new string(input);
            return output;
        }
        public static string Decryption(string Cipher_text, int shift)
        {
            input = Cipher_text.ToUpper().ToCharArray();
            for (int j = 0; j < input.Length; j++)
            {
                for (int i = 0; i < letter.Length; i++)
                {
                    if (input[j] == letter[i])
                    {
                        res = (i - shift);
                        while (res < 0)
                            res = res + letter.Length;

                        input[j] = letter[res % letter.Length];
                        break;
                    }
                }
            }
            output = new string(input);
            return output;
        }
    }
}
