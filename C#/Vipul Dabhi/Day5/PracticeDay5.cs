using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Day5
{
    public class Galaxy
    {
        public string Name { get; set; }
        public int MegaLightYears { get; set; }
    }

    class PracticeDay5
    {
        public static void PrintValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            //al.Add(100);
            //al.Add(200);
            //al.Add(300);
            //al.Add(400);

            //al.Insert(3, 500);
            //al.Remove(200);
            //al.RemoveAt(2);

            //Generic

            //List

            //List<int> li = new List<int>();

            //// Create a list of strings.
            //var salmons = new List<string>();
            //salmons.Add("chinook");
            //salmons.Add("coho");
            //salmons.Add("pink");
            //salmons.Add("sockeye");

            //// Iterate through the list.
            //foreach (var salmon in salmons)
            //{
            //    Console.Write(salmon + " ");
            //}
            //// Output: chinook coho pink sockeye


            //// Create a list of strings by using a
            //// collection initializer.
            //var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
            //// Iterate through the list.
            //foreach (var salmon in salmons)
            //{
            //    Console.Write(salmon + " ");
            //}
            //// Output: chinook coho pink sockeye


            //// Create a list of strings by using a
            //// collection initializer.
            //var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };
            //// Remove an element from the list by specifying
            //// the object.
            //salmons.Remove("coho");
            //// Iterate through the list.
            //foreach (var salmon in salmons)
            //{
            //    Console.Write(salmon + " ");
            //}                                     
            //// Output: chinook pink sockeye
             
             
            //var numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// Remove odd numbers.
            //for (var index = numbers.Count - 1; index >= 0; index--)
            //{
            //    if (numbers[index] % 2 == 1)
            //    {
            //        // Remove the element by specifying
            //        // the zero-based index in the list.
            //        numbers.RemoveAt(index);
            //    }
            //}
            //// Iterate through the list.
            //// A lambda expression is placed in the ForEach method
            //// of the List(T) object.
            //numbers.ForEach(
            //    number => Console.Write(number + " "));
            //// Output: 0 2 4 6 8



            //var theGalaxies = new List<Galaxy>
            //{
            //    new Galaxy() { Name="Tadpole", MegaLightYears=400},
            //    new Galaxy() { Name="Pinwheel", MegaLightYears=25},
            //    new Galaxy() { Name="Milky Way", MegaLightYears=0},
            //    new Galaxy() { Name="Andromeda", MegaLightYears=3}
            //};
            //foreach (Galaxy theGalaxy in theGalaxies)
            //{
            //    Console.WriteLine(theGalaxy.Name + "  " + theGalaxy.MegaLightYears);
            //}
            //// Output:
            ////  Tadpole  400
            ////  Pinwheel  25
            ////  Milky Way  0
            ////  Andromeda  3


            //stack


            //// Creates and initializes a new Stack.
            //Stack myStack = new Stack();
            //myStack.Push("Hello");
            //myStack.Push("World");
            //myStack.Push("!");

            //// Displays the properties and values of the Stack.
            //Console.WriteLine("myStack");
            //Console.WriteLine("\tCount:    {0}", myStack.Count);
            //Console.Write("\tValues:");
            //PrintValues(myStack);

            //Example

            //Stack<string> numbers = new Stack<string>();
            //numbers.Push("one");
            //numbers.Push("two");
            //numbers.Push("three");
            //numbers.Push("four");
            //numbers.Push("five");

            //// A stack can be enumerated without disturbing its contents.
            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            //Console.WriteLine("Peek at next item to destack: {0}",
            //    numbers.Peek());
            //Console.WriteLine("Popping '{0}'", numbers.Pop());

            //// Create a copy of the stack, using the ToArray method and the
            //// constructor that accepts an IEnumerable<T>.
            //Stack<string> stack2 = new Stack<string>(numbers.ToArray());

            //Console.WriteLine("\nContents of the first copy:");
            //foreach (string number in stack2)
            //{
            //    Console.WriteLine(number);
            //}

            //// Create an array twice the size of the stack and copy the
            //// elements of the stack, starting at the middle of the
            //// array.
            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //// Create a second stack, using the constructor that accepts an
            //// IEnumerable(Of T).
            //Stack<string> stack3 = new Stack<string>(array2);

            //Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            //foreach (string number in stack3)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
            //    stack2.Contains("four"));

            //Console.WriteLine("\nstack2.Clear()");
            //stack2.Clear();
            //Console.WriteLine("\nstack2.Count = {0}", stack2.Count);

            //Example2

            
            List<object> li = new List<object>();
            {
                new Customers() { ID = 101, Name = "John", Gender = "Male" };
            }

            li.Add("dsd");
            li.RemoveAt(0);
            Console.WriteLine();



            //Queue



            //Queue<string> numbers = new Queue<string>();
            //numbers.Enqueue("one");
            //numbers.Enqueue("two");
            //numbers.Enqueue("three");
            //numbers.Enqueue("four");
            //numbers.Enqueue("five");

            //// A queue can be enumerated without disturbing its contents.
            //foreach (string number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            //Console.WriteLine("Peek at next item to dequeue: {0}",
            //    numbers.Peek());
            //Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            //// Create a copy of the queue, using the ToArray method and the
            //// constructor that accepts an IEnumerable<T>.
            //Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            //Console.WriteLine("\nContents of the first copy:");
            //foreach (string number in queueCopy)
            //{
            //    Console.WriteLine(number);
            //}

            //// Create an array twice the size of the queue and copy the
            //// elements of the queue, starting at the middle of the
            //// array.
            //string[] array2 = new string[numbers.Count * 2];
            //numbers.CopyTo(array2, numbers.Count);

            //// Create a second queue, using the constructor that accepts an
            //// IEnumerable(Of T).
            //Queue<string> queueCopy2 = new Queue<string>(array2);

            //Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            //foreach (string number in queueCopy2)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
            //    queueCopy.Contains("four"));

            //Console.WriteLine("\nqueueCopy.Clear()");
            //queueCopy.Clear();
            //Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);



            //Dictionary



            //// Create a new dictionary of strings, with string keys.
            ////
            //Dictionary<string, string> openWith =
            //    new Dictionary<string, string>();

            //// Add some elements to the dictionary. There are no
            //// duplicate keys, but some of the values are duplicates.
            //openWith.Add("txt", "notepad.exe");
            //openWith.Add("bmp", "paint.exe");
            //openWith.Add("dib", "paint.exe");
            //openWith.Add("rtf", "wordpad.exe");

            //// The Add method throws an exception if the new key is
            //// already in the dictionary.
            //try
            //{
            //    openWith.Add("txt", "winword.exe");
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("An element with Key = \"txt\" already exists.");
            //}

            //// The Item property is another name for the indexer, so you
            //// can omit its name when accessing elements.
            //Console.WriteLine("For key = \"rtf\", value = {0}.",
            //    openWith["rtf"]);

            //// The indexer can be used to change the value associated
            //// with a key.
            //openWith["rtf"] = "winword.exe";
            //Console.WriteLine("For key = \"rtf\", value = {0}.",
            //    openWith["rtf"]);

            //// If a key does not exist, setting the indexer for that key
            //// adds a new key/value pair.
            //openWith["doc"] = "winword.exe";

            //// The indexer throws an exception if the requested key is
            //// not in the dictionary.
            //try
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}.",
            //        openWith["tif"]);
            //}
            //catch (KeyNotFoundException)
            //{
            //    Console.WriteLine("Key = \"tif\" is not found.");
            //}

            //// When a program often has to try keys that turn out not to
            //// be in the dictionary, TryGetValue can be a more efficient
            //// way to retrieve values.
            //string value = "";
            //if (openWith.TryGetValue("tif", out value))
            //{
            //    Console.WriteLine("For key = \"tif\", value = {0}.", value);
            //}
            //else
            //{
            //    Console.WriteLine("Key = \"tif\" is not found.");
            //}

            //// ContainsKey can be used to test keys before inserting
            //// them.
            //if (!openWith.ContainsKey("ht"))
            //{
            //    openWith.Add("ht", "hypertrm.exe");
            //    Console.WriteLine("Value added for key = \"ht\": {0}",
            //        openWith["ht"]);
            //}

            //// When you use foreach to enumerate dictionary elements,
            //// the elements are retrieved as KeyValuePair objects.
            //Console.WriteLine();
            //foreach (KeyValuePair<string, string> kvp in openWith)
            //{
            //    Console.WriteLine("Key = {0}, Value = {1}",
            //        kvp.Key, kvp.Value);
            //}

            //// To get the values alone, use the Values property.
            //Dictionary<string, string>.ValueCollection valueColl =
            //    openWith.Values;

            //// The elements of the ValueCollection are strongly typed
            //// with the type that was specified for dictionary values.
            //Console.WriteLine();
            //foreach (string s in valueColl)
            //{
            //    Console.WriteLine("Value = {0}", s);
            //}

            //// To get the keys alone, use the Keys property.
            //Dictionary<string, string>.KeyCollection keyColl =
            //    openWith.Keys;

            //// The elements of the KeyCollection are strongly typed
            //// with the type that was specified for dictionary keys.
            //Console.WriteLine();
            //foreach (string s in keyColl)
            //{
            //    Console.WriteLine("Key = {0}", s);
            //}

            //// Use the Remove method to remove a key/value pair.
            //Console.WriteLine("\nRemove(\"doc\")");
            //openWith.Remove("doc");

            //if (!openWith.ContainsKey("doc"))
            //{
            //    Console.WriteLine("Key \"doc\" is not found.");
            //}







            Console.ReadLine();



        }
        
    }
    public class Customers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    
}
