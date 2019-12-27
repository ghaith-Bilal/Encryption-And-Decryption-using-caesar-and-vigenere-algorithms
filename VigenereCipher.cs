using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoSecProject
{
    class VigenereCipher
    {
        static string output = null;
        static char[] input = null;
        static char[] charKey = null;

        public static string Encryption(string Plain_Text, string en_key)
        {
            output = null;
            while (en_key.Length <= Plain_Text.Length)
            {
                en_key += en_key;
            }
            charKey = en_key.ToUpper().ToCharArray();
            input = Plain_Text.ToUpper().ToCharArray();


            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    output += input[i];
                    continue;
                }
                if (Char.IsPunctuation(input[i]))
                {
                    output += input[i];
                    continue;
                }
                if (input[i] == 13)
                {
                    output += "\r";
                    continue;
                }
                if (input[i] == 10)
                {
                    output += "\n";
                    continue;
                }
                if (input[i] == 9)
                {
                    output += "\t";
                    continue;
                }
                if (input[i] < 65 || input[i] > 90)
                {
                    output += input[i];
                    continue;
                }

                int plain = input[i] - 65;
                int key = charKey[i] - 65;
                int cipher = (plain + key) % 26;
                int cipherIndex = cipher + 65;
                char charOutput = (char)cipherIndex;
                output += charOutput.ToString();
            }
            return output;
        }
        public static string Decryption(string Cipher_text, string de_key)
        {
            output = null;
            while (de_key.Length <= Cipher_text.Length)
            {
                de_key += de_key;
            }
            charKey = de_key.ToUpper().ToCharArray();
            input = Cipher_text.ToUpper().ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    output += input[i];
                    continue;
                }
                if (Char.IsPunctuation(input[i]))
                {
                    output += input[i];
                    continue;
                }
                if (input[i] == 13)
                {
                    output += "\r";
                    continue;
                }
                if (input[i] == 10)
                {
                    output += "\n";
                    continue;
                }
                if (input[i] == 9)
                {
                    output += "\t";
                    continue;
                }
                if (input[i] < 65 || input[i] > 90)
                {
                    output += input[i];
                    continue;
                }

                int cipher = input[i] - 65;
                int key = charKey[i] - 65;
                int plain = (cipher - key);
                    while (plain<0)
                        plain += 26;
                plain = plain % 26;
                int plainIndex = plain + 65;
                char charOutput = (char)plainIndex;
                output += charOutput.ToString();
            }
            return output;
        }
    }
}
