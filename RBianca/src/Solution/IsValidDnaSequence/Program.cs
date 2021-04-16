using System;

namespace IsValidDnaSequence
{
    class Program
    {
        public static bool VerifyDNA(string text)
        {
            if(text.Length != 1000)
                return false;
            char[] toChar = text.ToCharArray();
            int i;
            for (i = 0; i < text.Length; i++)
                if (toChar[i] != 'A' && toChar[i] != 'G' && toChar[i] != 'C' && toChar[i] != 'T')
                    return false;
            return true;
        }
    }
}
