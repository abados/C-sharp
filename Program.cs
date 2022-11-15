using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw_string_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             Console.WriteLine("//////////////////Contains()///////////////");
            Console.WriteLine("");
            // String.Contains() is a string method. This method is used to check whether the substring occurs within a given string or not.
            String str = "Zionet Tech Company";
            String substr1 = "Tech";
            String substr2 = "tech";

            // using String.Contains() Method
            Console.WriteLine(str.Contains(substr1));

            // Here case-sensitive comparison
            // And substr2 value is 'For'
            // So its return false
            Console.WriteLine(str.Contains(substr2));

            Console.WriteLine("");
            Console.WriteLine("////////////////CopyTo()/////////////////");
            Console.WriteLine("");
            //CopyTo() method is a string method. It is used to copy a specified number of characters from a specified position
            //in the string and it copies the characters of this string into a array of Unicode characters.

            string str2 = "ZionetTechCompany";
            char[] dest = new char[15];

            // str index 5 to 5+3 has to 
            // copy into Copystring
            // 3 is no. of character
            // 0 is start index of Copystring
            str2.CopyTo(6, dest, 0, 4);

            // Displaying String
            Console.Write("The Copied String in dest Variable is: ");
            Console.WriteLine(dest);

            Console.WriteLine("");
            Console.WriteLine("////////////////Insert()/////////////////");
            Console.WriteLine("");
            // Insert() method is a String method. It is used to return a new string in which a specified string is inserted
            // at a specified index position in the current string instance.

            String str3 = "my name is abadi";

            Console.WriteLine("Current string: " + str3);

            // insert Hay at index 11 where string is append
            Console.WriteLine("New string: " + str3.Insert(11, "Hay "));

            Console.WriteLine("");
            Console.WriteLine("////////////////PadRight()/////////////////");
            Console.WriteLine("");
            //PadRight() is a string method. This method is used to left-aligns the characters in String by padding them with spaces or specified
            //character on the right, for a specified total length. This method can be overloaded by passing different parameters to it.
            string str4 = "Merkz Ma'ashe";

            Console.WriteLine("String : " + str4);

            // totalwidth is less than string length
            Console.WriteLine("Pad 2 :'{0}'", str4.PadRight(2));

            // totalwidth is equal to string length
            Console.WriteLine("Pad 13 :'{0}'", str4.PadRight(14));

            // totalwidth is greater than string length
            Console.WriteLine("Pad 20 :'{0}'", str4.PadRight(16));

            Console.WriteLine("");
            Console.WriteLine("////////////////Replace()/////////////////");
            Console.WriteLine("");
            //Replace() method is a string method. This method is used to replace all the specified Unicode characters or specified string from the
            //current string object and returns a new modified string. This method can be overloaded by passing arguments to it.

            String str5 = "WeLoveIsrael";

            Console.WriteLine("OldString : " + str5);

            // replace the character 's' with 'G'
            Console.WriteLine("NewString: " + str5.Replace('s', 'G'));

            // oldString will remain unchanged
            // its return the modified string
            Console.WriteLine("\nOldString: " + str5);

            // replace the character 'e' with space ' '
            Console.WriteLine("NewString: " + str5.Replace('e', ' '));

            Console.WriteLine("");
            Console.WriteLine("////////////////Substring()/////////////////");
            Console.WriteLine("");
            //Substring() is a string method. It is used to retrieve a substring from the current instance of the string.
            //This method can be overloaded by passing the different number of parameters to it as follows:

            // define string
            String str6 = "WeLoveCSharp";

            Console.WriteLine("String    : " + str6);

            // retrieve the substring from index 5
            Console.WriteLine("Sub String1: " + str6.Substring(2));

            // retrieve the substring from index 8
            Console.WriteLine("Sub String2: " + str6.Substring(6));

            Console.WriteLine("The original string didn't change    : " + str6);

            Console.WriteLine("");
            Console.WriteLine("////////////////ToCharArray()/////////////////");
            Console.WriteLine("");
            //ToCharArray() is a string method. This method is used to copy the characters from a specified string in the current instance
            //to a Unicode character array or the characters of a specified substring in the current instance to a Unicode character array.
            //This method can be overloaded by changing the number of arguments passed to it.

            String str7 = "WeLoveCSharp";

            // copy the string str to chars 
            // character array & it will start
            // copy from 'G' to 's', i.e. 
            // beginning to ending of string
            char[] chars = str7.ToCharArray();

            Console.WriteLine("String: " + str7);
            Console.Write("Character array :");

            // to display the resulted character array
            for (int i = 0; i < chars.Length; i++)
                Console.Write(" " + chars[i]);

            Console.WriteLine("");
            Console.WriteLine("////////////////Split()/////////////////");
            Console.WriteLine("");

            //Split() is a string class method. The Split() method returns an array of strings generated by splitting of
            //original string separated by the delimiters passed as a parameter in Split() method.
            //The delimiters can be a character or an array of characters or an array of strings.
            //Or you can also say that it returns a string array which contains the substrings in the current instance that are delimited by elements of a specified string or Unicode character array.
            //There are 6 methods in the overload list of this method

            Console.WriteLine("////////////////Split() - the first way/////////////////");
            Console.WriteLine("");
            // Taking a string
            String str8 = "We love C Shrpe, And C";

            String[] spearator = { "Shrpe, ", "And" };
          
            Int32 count = 2;

            // using the method
            String[] strlist = str8.Split(spearator, count,
                   StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");
            Console.WriteLine("////////////////Split() - the Second way/////////////////");
            Console.WriteLine("");

            String str81 = "\"We love C Shrpe, And C\"";

            char[] spearator2 = { ',', ' ' };
            Int32 count2 = 2;

            // Using the Method
            String[] strlist2 = str81.Split(spearator2,
                   count, StringSplitOptions.None);

            foreach (String s in strlist2)
            {
                Console.WriteLine(s);
                
            }

            Console.WriteLine("");
            Console.WriteLine("////////////////Split() - the Third way/////////////////");
            Console.WriteLine("");

            // Taking a string
            String str82 = "We love C Shrpe, And C";

            String[] spearator3 = { "Shrpe, ", "And" };

            // using the method
            String[] strlist3 = str82.Split(spearator3,
               StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist3)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
            Console.WriteLine("////////////////Split() - the 4 way/////////////////");
            Console.WriteLine("");

            String str84 = "We love C Shrpe, And C";

            char[] spearator4 = { 'C', ' ' };

            // using the method
            String[] strlist4 = str84.Split(spearator4);

            foreach (String s in strlist4)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();


            Console.WriteLine("");
            Console.WriteLine("////////////////Split() - the 5 way/////////////////");
            Console.WriteLine("");

            String str85 = "We love C Shrpe, And C";

            char[] spearator5 = { 'C', ' ' };

            // using the method
            String[] strlist5 = str85.Split(spearator5,
               StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist5)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("");
            Console.WriteLine("////////////////Split() - the 6 way/////////////////");
            Console.WriteLine("");

            // Taking a string
            String str86 = "We love C Shrpe, And C";

            char[] spearator6 = { 'C', ' ' };
            Int32 count6 = 2;

            // using the method
            String[] strlist6 = str86.Split(spearator6, count6);

            foreach (String s in strlist6)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("");
            Console.WriteLine("////////////////Trim()/////////////////");
            Console.WriteLine("");
            //Trim() is a string method. This method is used to removes all leading and trailing white-space characters from the current
            //String object.This method can be overloaded by passing arguments to it.

            string s1 = " HAY";
            string s2 = " HAY ";
            string s3 = "HAY ";

            // Before Trim method call
            Console.WriteLine("Before:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);

            Console.WriteLine("");

            // After Trim method call
            Console.WriteLine("After:");
            Console.WriteLine(s1.Trim());
            Console.WriteLine(s2.Trim());
            Console.WriteLine(s3.Trim());


            Console.WriteLine("");
            Console.WriteLine("////////////////TrimStart()/////////////////");
            Console.WriteLine("");
            //TrimStart() & TrimEnd() are the string methods. TrimStart() method is used to remove the occurrences of a set of characters
            //specified in an array from the starting of the current String object. TrimEnd() method is used to remove the occurrences of a
            //set of characters specified in an array from the ending of the current String object. 
            string st1 = "*****0000abc000****";

            char[] charsToTrim1 = { '*', '0' };

            // string to be trimmed
            string st2 = "  abc";
            string st3 = "  -HAY-";
            string st4 = "  ZionetIsInTheHouse";

            // Before TrimStart method call
            Console.WriteLine("Before:");
            Console.WriteLine(st1);
            Console.WriteLine(st2);
            Console.WriteLine(st3);
            Console.WriteLine(st4);

            Console.WriteLine("");

            // After TrimStart method call
            Console.WriteLine("After:");

            // argument as char array
            Console.WriteLine(st1.TrimStart(charsToTrim1));

            // if there is no argument then it
            // takes default as null, ' ',
            // '\t', '\r'
            Console.WriteLine(st2.TrimStart());

            // White space is not remove
            Console.WriteLine(st3.TrimStart('-'));

            // not take char array but Argument only character
            Console.WriteLine(st4.TrimStart(' ', 'G', 'e', 'k', 's'));

            Console.WriteLine("");
            Console.WriteLine("////////////////TrimEnd()/////////////////");
            Console.WriteLine("");
            // String to be trimmed
            string st11 = "*****0000abc000****";


            char[] charsToTrim2 = { '*', '0' };

            // string to be trimmed
            string st22 = "abc  ";
            string st33 = "  -HAY-  ";
            string st44 = "  ZionetIsInTheHouse";

            // Before TrimEnd method call
            Console.WriteLine("Before:");
            Console.WriteLine(st11);
            Console.WriteLine(st22);
            Console.WriteLine(st33);
            Console.WriteLine(st44);

            Console.WriteLine("");

            // After TrimEnd method call
            Console.WriteLine("After:");

            // argument as char array
            Console.WriteLine(st11.TrimEnd(charsToTrim1));

            // if there is no argument then it
            // takes default as null, ' ',
            // '\t', '\r'
            Console.WriteLine(st22.TrimEnd());

            // White space is not remove
            Console.WriteLine(st33.TrimEnd('-'));

            // not take char array but
            // Argument only character
            Console.WriteLine(st44.TrimEnd(' ', 'G', 'e', 'k', 's'));

            Console.WriteLine("");
            Console.WriteLine("////////////////StartsWith()/////////////////");
            Console.WriteLine("");

            //StartsWith() is a string method. This method is used to check whether the beginning of the current string instance
            //matches with a specified string or not. If it matches then it returns the string otherwise false. Using foreach-loop,
            //it is possible to check many strings. This method can be overloaded by passing different type and number of arguments to it.


            // The input string or character
            string strLink = "https://mail.google.com/mail/u/0/#inbox";

            // Different string character and
            // Possible string to be matches
            string[] m = new string[] {
            "https://mail.google.com",
            "https://mail.google.com/mail",
            "https://mail.google.com/mail/u/0/"};

            // Using foreach - loop to check
            // each possible match
            foreach (string s in m)
            {

                // To check match second possibility
                if (strLink.StartsWith(s))
                {

                    // Display the result
                    Console.WriteLine(s);
                }

            }

            Console.WriteLine("");
            Console.WriteLine("////////////////StartsWith()/////////////////");
            Console.WriteLine("");

            //IndexOf() method is a string method. This method is used to find the zero-based index of the first occurrence of a specified
            //character or string within the current instance of the string. The method returns -1 if the character or string is not found.
            //This method can be overloaded by passing different parameters to it.

            string str9 = "ZionetIsInTheHouse";

            // Finding the index of character
            // which is present in string and
            // this will show the value 5
            int index1 = str9.IndexOf('H');

            Console.WriteLine("The Index Value of character 'H' is " + index1);

            // Now finding the index of that character which
            //  is not even present with the string
            int index2 = str9.IndexOf('s');

            // As expected, this will output value -1
            Console.WriteLine("The Index Value of character 's' is " + index2);
            Console.ReadLine();




        }
    }
}
