using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day4
{
    class PracticeDay4
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            try
            {
                streamReader = new StreamReader(@"c:\filename");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                //log the details to the DB
                Console.WriteLine("Please Check The File {0} is Present or not",ex.FileName);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                Console.WriteLine("Finally Block");
            }


            //string methods

            string text = "Hello World";

            //Static Methods:  
            Console.WriteLine("================= Static Methods ================\n");
            Console.WriteLine("Comparing \"abhishek\" and \"Sunny\" {0}", string.Compare("abhishek", "Sunny"));
            Console.WriteLine("Copying text value in new string: {0}", string.Copy(text));
            Console.WriteLine("Is \"Apple\" and \"apple\" are equal ??: {0}", string.Equals("Apple", "apple"));
            Console.WriteLine("Is text is NULL ? : {0}", string.IsNullOrEmpty(text));
            //All Instance Methods:  
            Console.WriteLine("\n================= Static Methods ================\n");
            string cloneText = (string)text.Clone();
            Console.WriteLine("Clone Text: {0}", cloneText);

            bool containText = text.Contains("e");
            Console.WriteLine("Is text contains given value?: {0}", containText);

            string removedText = text.Remove(2);
            Console.WriteLine("New string after Removing: {0}", removedText);

            if (text.Contains("e"))
            {
                string replacedText = text.Replace("e", "E");
                Console.WriteLine("New String after Replacing character: {0}", replacedText);
            }

            string insertedText = text.Insert(3, " Added String ");
            Console.WriteLine("Inserted Text: {0}", insertedText);
            string subString = text.Substring(3, 8);
            Console.WriteLine("New string after SubString(): {0}", subString);

            //Simple Use

            //PadLeft() / PadRight() Methods

            //string str1 = "Abhimanyu";
            //str1 = str1.PadLeft(20);
            //Console.WriteLine(str1);

            //string str2 = "Kumar";
            //str2 = str2.PadRight(30);
            //Console.WriteLine(str2);  //it will not be visible as it is very close to axis

            ////Padding with symbol

            //string str3 = "Vatsa";
            //char padWith = '*';
            //Console.WriteLine(str3.PadLeft(20, padWith));

            //string str4 = "Good Luck";
            //char padWith1 = '-';
            //Console.WriteLine(str4.PadLeft(11, padWith1));


            //Remove() / Replace() Methods

            //Using Remove

            //string str1 = "abhimanyu";
            //str1 = str1.Remove(str1.Length - 1);  //Remove(total_length - 1) means will not display last word
            //Console.WriteLine(str1);

            //string str2 = "kumar";
            //str2 = str2.Remove(0, 2);  //Remove(start_location, number_of_digit_to_remove)
            //Console.WriteLine(str2);

            ////Using Replace

            //string str3 = "abhimanyu kumar";
            //Console.WriteLine(str3);

            //string str4 = str3.Replace("kumar", "kumar vatsa");
            //Console.WriteLine(str4);



            //Split() Method


            //Using Split normally

            //string str1 = "abhimanyu kumar vatsa";
            //string[] newWordLines = str1.Split(' '); //this will create array of string
            //foreach (string word in newWordLines)
            //{
            //    Console.WriteLine(word);
            //}

            ////Using Split using method1

            //string str2 = "abhimanyu,dhananjay,sam,suthish,sam";
            //foreach (string s in Split1(str2, ',')) //Calling Method1 each time
            //{
            //    Console.WriteLine(s);
            //}

            ////Using Split using method2

            //string str3 = "09-08-2011";
            //Console.WriteLine(str3);
            //str3 = str3.Replace('-', '/');
            //Console.WriteLine(str3);
            //foreach (string s in Split2(str3, '/'))
            //{
            //    Console.WriteLine(s);
            //}



            //Substring() Method


            //Simple use

            //string str1 = "abhimanyu kumar vatsa";
            //string subStr1 = str1.Substring(0, 9);
            //Console.WriteLine("Sub Name: {0}", subStr1);

            ////Using with one parameter

            //string str2 = "abhimanyu kumar vatsa";
            //string subStr2 = str2.Substring(10);  //no 2nd parameter will display from 10 to end, it has only start parameter
            //Console.WriteLine("Sub Name: {0}", subStr2);

            ////Finding middle string

            //string str3 = "abhimanyu kumar vatsa";
            //string subStr3 = str3.Substring(10, 5);
            //Console.WriteLine("Sub Name: {0}", subStr3);



            //ToCharArray() Method



            // String to Array, using method

            //string str1 = "Abhimanyu Kumar Vatsa";
            //char[] toChArray = str1.ToCharArray();
            //for (int i = 0; i < toChArray.Length; i++)
            //{
            //    char letter = toChArray[i];
            //    Console.WriteLine(letter);
            //}

            ////Array to String, using custom method

            //string str2 = "";
            //for (int i = 0; i < toChArray.Length; i++)
            //{
            //    str2 += toChArray[i];
            //}
            //Console.WriteLine(str2);



            //DateTime



            //// Create a DateTime from date and time
            //DateTime dob = new DateTime(1974, 7, 10, 7, 10, 24);

            //// Create a DateTime from a String  
            //string dateString = "7/10/1974 7:10:24 AM";
            //DateTime dateFromString =
            //    DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(dateFromString.ToString());

            //// Empty DateTime  
            //DateTime emptyDateTime = new DateTime();

            //// Just date  
            //DateTime justDate = new DateTime(2002, 10, 18);

            //// DateTime from Ticks  
            //DateTime justTime = new DateTime(1000000);

            //// DateTime with localization  
            //DateTime dateTimeWithKind = new DateTime(1974, 7, 10, 7, 10, 24, DateTimeKind.Local);

            //// DateTime with date, time and milliseconds  
            //DateTime dateTimeWithMilliseconds = new DateTime(2010, 12, 15, 5, 30, 45, 100);



            //DateTime Properties


            //DateTime dob = new DateTime(1974, 7, 10, 7, 10, 24);
            //Console.WriteLine("Day:{0}", dob.Day);
            //Console.WriteLine("Month:{0}", dob.Month);
            //Console.WriteLine("Year:{0}", dob.Year);
            //Console.WriteLine("Hour:{0}", dob.Hour);
            //Console.WriteLine("Minute:{0}", dob.Minute);
            //Console.WriteLine("Second:{0}", dob.Second);
            //Console.WriteLine("Millisecond:{0}", dob.Millisecond);

            //Console.WriteLine("Day of Week:{0}", dob.DayOfWeek);
            //Console.WriteLine("Day of Year: {0}", dob.DayOfYear);
            //Console.WriteLine("Time of Day:{0}", dob.TimeOfDay);
            //Console.WriteLine("Tick:{0}", dob.Ticks);
            //Console.WriteLine("Kind:{0}", dob.Kind);


            //adding and substracting DateTIme


            //DateTime aDay = DateTime.Now;
            //TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);
            //DateTime aDayAfterAMonth = aDay.Add(aMonth);
            //DateTime aDayBeforeAMonth = aDay.Subtract(aMonth);
            //Console.WriteLine("{0:dddd}", aDayAfterAMonth);
            //Console.WriteLine("{0:dddd}", aDayBeforeAMonth);

            //// Add Years and Days  
            //aDay.AddYears(2);
            //aDay.AddDays(12);
            //// Add Hours, Minutes, Seconds, Milliseconds, and Ticks  
            //aDay.AddHours(4.25);
            //aDay.AddMinutes(15);
            //aDay.AddSeconds(45);
            //aDay.AddMilliseconds(200);
            //aDay.AddTicks(5000);


            //DateTime dob = new DateTime(2000, 10, 20, 12, 15, 45);
            //DateTime subDate = new DateTime(2000, 2, 6, 13, 5, 15);

            //// TimeSpan with 10 days, 2 hrs, 30 mins, 45 seconds, and 100 milliseconds  
            //TimeSpan ts = new TimeSpan(10, 2, 30, 45, 100);

            //// Subtract a DateTime  
            //TimeSpan diff1 = dob.Subtract(subDate);
            //Console.WriteLine(diff1.ToString());

            //// Subtract a TimeSpan  
            //DateTime diff2 = dob.Subtract(ts);
            //Console.WriteLine(diff2.ToString());

            //// Subtract 10 Days  
            //DateTime daysSubtracted = new DateTime(dob.Year, dob.Month, dob.Day - 10);
            //Console.WriteLine(daysSubtracted.ToString());

            //// Subtract hours, minutes, and seconds  
            //DateTime hms = new DateTime(dob.Year, dob.Month, dob.Day, dob.Hour - 1, dob.Minute - 15, dob.Second - 15);
            //Console.WriteLine(hms.ToString());



            //Find Days in a Month


            //int days = DateTime.DaysInMonth(2002, 2);
            //Console.WriteLine(days);

            //private int GetDaysInAYear(int year)
            //{
            //    int days = 0;
            //    for (int i = 1; i <= 12; i++)
            //    {
            //        days += DateTime.DaysInMonth(year, i);
            //    }
            //    return days;
            //}


            //Comparer TO DateTime

            //DateTime firstDate = new DateTime(2002, 10, 22);
            //DateTime secondDate = new DateTime(2009, 8, 11);
            //int result = DateTime.Compare(firstDate, secondDate);

            //DateTime firstDate = new DateTime(2002, 10, 22);
            //DateTime secondDate = new DateTime(2009, 8, 11);
            //int compareResult = firstDate.CompareTo(secondDate);


            //DateTime Format


            //DateTime firstDate = new DateTime(2002, 10, 22);
            //DateTime secondDate = new DateTime(2009, 8, 11);
            //int compareResult = firstDate.CompareTo(secondDate);


            //Get Leap Year and Daylight Saving Time


            //DateTime dob = new DateTime(2020, 10, 22);
            //Console.WriteLine(dob.IsDaylightSavingTime());
            //Console.WriteLine(DateTime.IsLeapYear(dob.Year));



            //How to convert C# DateTime



            //DateTime dob = new DateTime(2002, 10, 22);
            //Console.WriteLine("ToString: " + dob.ToString());
            //Console.WriteLine("ToBinary: " + dob.ToBinary());
            //Console.WriteLine("ToFileTime: " + dob.ToFileTime());
            //Console.WriteLine("ToLocalTime: " + dob.ToLocalTime());
            //Console.WriteLine("ToLongDateString: " + dob.ToLongDateString());
            //Console.WriteLine("ToLongTimeString: " + dob.ToLongTimeString());
            //Console.WriteLine("ToOADate: " + dob.ToOADate());
            //Console.WriteLine("ToShortDateString: " + dob.ToShortDateString());
            //Console.WriteLine("ToShortTimeString: " + dob.ToShortTimeString());
            //Console.WriteLine("ToUniversalTime: " + dob.ToUniversalTime());




            Console.ReadKey();

        }
    }
}
