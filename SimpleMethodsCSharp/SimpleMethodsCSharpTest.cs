using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethodsCSharp
{
    class SimpleMethodsCSharpTest
    {
        public List<int> NonDupNumbers (int[] values)
        {
            List<int> returnValues = new List<int>();
            Boolean dups = false;
            for(int outter = 0; outter < values.Length; outter++)
            {
                dups = false;
                for(int inner = 0; inner < values.Length; inner++)
                {
                    if(inner != outter)
                    {
                        if(values[outter] == values[inner])
                        {
                            //Console.Write("Inside if(values[outter] == values[inner]) check");
                            dups = true;
                            //Console.Write(dups);
                        }// end if(values[outter] == values[inner]) check
                    }// end if(inner != outter) check
                }// end inner for loop
                if (dups == false)
                {
                    returnValues.Add(values[outter]);
                }// end if(!dups) check
            }// end outter for loop
            return returnValues;
        }//end NonDupNumbers method

        public List<char> NonDupLetters(String inputString)
        {
            List<char> returnValues = new List<char>();
            bool dups = false;
            char[] orginalStringArray = inputString.ToCharArray();
            for(int outter = 0; outter < inputString.Length; outter++)
            {
                dups = false;
                for(int inner = 0; inner < inputString.Length; inner++)
                {
                    if(inner != outter)
                    {
                        if(orginalStringArray[outter] == orginalStringArray[inner])
                        {
                            dups = true;
                        }// end if(orginalStringArray[outter] == orginalStringArray[inner]) check
                    }// end if(inner != outter) check
                }// end inner for loop
                if (!dups)
                {
                    returnValues.Add(orginalStringArray[outter]);
                }// end if (!dups) check
            }// end outter for loop
            return returnValues;
        }// end NonDupLetters method

        public int TotalASCIIValueOfAString (String inputString)
        {
            int total = 0;
            char[] valueString = inputString.ToCharArray();
            foreach(char let in valueString)
            {
                total += (int)let;
            }// end char let foreach loop
            return total;
        }// end TotalASCIIValueOfAString method

        public bool IsPalindrome (String inputString)
        {
            String reverseString = "";
            for(int index = (inputString.Length - 1); index > -1; index--)
            {
                reverseString += inputString.Substring(index, 1);
            }// end index for loop
            if (inputString.Equals(reverseString))
            {
                return true;
            }// end if (inputString.Equals(reverseString)) check
            else
            {
                return false;
            }// end else check
        }// end IsPalindrome method
    }// end SimpleMethodsCSharpTest class
}// end SimpleMethodsCSharp namespace
