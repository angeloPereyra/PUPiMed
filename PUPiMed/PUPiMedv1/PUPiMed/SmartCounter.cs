using System;
using System.Text.RegularExpressions;

namespace PUPiMed
{
    class SmartCounter
    {
        public SmartCounter(string prev)
        {
            prev = Regex.Replace(prev, @"[^\w\-]", "");
            string original = prev;
            string num = string.Empty;
            prev = reverse(prev);

            //Get Numeric Values to be incremented
            char p = '\0', c;
            bool numFound = false;
            for (int i = 0; i < prev.Length; i++)
            {
                c = prev[i];
                if (Char.IsDigit(c))
                {
                    numFound = true;
                    num += c;
                }
                else
                {
                    if (Char.IsNumber(p))
                        break;
                }
                p = c;
            }
            if (!numFound)
                num = "000";
            num = reverse(num);

            //increment
            ulong nextInt = ulong.Parse(num);
            ++nextInt;

            //For zeros
            string newInt = nextInt.ToString();
            newInt = reverse(newInt);
            if (newInt.Length != num.Length)
            {
                int i = 0;
                int diff = num.Length - newInt.Length;
                while (i < diff)
                {
                    newInt += "0";
                    ++i;
                }
            }
            newInt = reverse(newInt);

            //place on original string
            string nextCode = String.Empty;
            if (numFound)
            {
                //replace only the last occurence
                int loc = original.LastIndexOf(num);
                nextCode = original.Remove(loc, num.Length).Insert(loc, newInt);
                this.newCode = nextCode;
                //Console.WriteLine(" Next Code: {0}", nextCode);
            }
            //else 
            //Console.WriteLine("<ERR> Please_Enter_an_alphanumeric_value.");
        }

        public string reverse(string str)
        {
            char[] rev = str.ToCharArray();
            Array.Reverse(rev);
            return new String(rev); ;
        }

        public string getCode()
        {
            return this.newCode;
        }

        public string newCode;
    }
}
