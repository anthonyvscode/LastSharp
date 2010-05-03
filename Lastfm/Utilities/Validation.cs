using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lastfm.Utilities
{
    public static class Validation
    {
        /// <summary>
        /// Removes characters to make valid for url.
        /// </summary>
        /// <param name="input">The input string to be cleaned</param>
        /// <returns>A cleaned string suitable for a URL. All invalid characters are replaced with a "+" symbol</returns>
        public static string RemoveInvalidChars(string input)
        {
            return RemoveInvalidChars(input, "+");
        }
        /// <summary>
        /// Removes characters to make valid for url.
        /// </summary>
        /// <param name="input">The input string to be cleaned</param>
        /// <param name="replaceChar">Character to replace invalid characters with</param>
        /// <returns>A cleaned string suitable for a URL</returns>
        public static string RemoveInvalidChars(string input, string replaceChar)
        {
            string output = string.Empty;
            char[] inputChar = input.Replace(" ", replaceChar).ToCharArray();
            for (int i = 0; i < inputChar.Length; i++)
            {
                if (Char.IsDigit(inputChar[i]) || Char.IsLetter(inputChar[i]) || inputChar[i] == Convert.ToChar(replaceChar))
                {
                    //char is valid add it to the ouput string
                    output += inputChar[i].ToString();
                }
            }

            if (output.IndexOf(replaceChar + replaceChar) > -1)
                while (output.IndexOf(replaceChar + replaceChar) > -1)
                    output = output.Replace(replaceChar + replaceChar, replaceChar);

            return output;
        }
    }
}
