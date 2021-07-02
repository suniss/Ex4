using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
            List<string> theList = new List<string>();
            do
            {
                Console.Clear();
                Console.WriteLine("This list contains of:");
                Console.WriteLine(DisplayList(theList));
                Console.WriteLine("*********");
                Console.WriteLine("Please input + to add person to list");
                Console.WriteLine("Please input - to remove person from list");
                Console.WriteLine("Please input 0 to exit from menu");
                string input = Console.ReadLine();

                //user exit from menu
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);

                // add(+) or remove(-)
                if (value.Length == 0)
                {
                    Console.WriteLine("Should not input empty value");
                    continue;
                }
                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        break;
                    case '-':
                        if (!theList.Remove(value))
                            Console.WriteLine("Input " + value + "list is empty");
                        break;
                    default:
                        Console.WriteLine("Please use + or string to add or remove person");
                        break;
                }
            } while (true);

        }

       
        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            Queue theQueue = new Queue();
            do
            {
                Console.Clear();
                Console.WriteLine("This queue contains of:");
                Console.WriteLine(DisplayList(theQueue));
                Console.WriteLine("*********");
                Console.WriteLine("Please input + to add person to queue");
                Console.WriteLine("Please input - to remove person from queue");
                Console.WriteLine("Please input 0 to return to menu");
                string input = Console.ReadLine();
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);
                switch(nav)
                {
                    case '+':
                        if (value.Length == 0)
                            Console.WriteLine("Input name should not be empty");
                        else
                            theQueue.Enqueue(value);
                        break;
                    case '-':
                        if (theQueue.Count > 0)
                            theQueue.Dequeue();
                        else
                            Console.WriteLine("The queue is empty");
                        break;
                    default:
                        Console.WriteLine("Please only use + or - to get name to queue or remove name from queue");
                        break;
                }
            } while (true) ;
            
        }

        



        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
            Stack theStack = new Stack();
            do
            {
                Console.Clear();
                Console.WriteLine(DisplayList(theStack));
                Console.WriteLine("********");
                Console.WriteLine("Please input + to add name into stack ");
                Console.WriteLine("Please input - to remove name from stack");
                Console.WriteLine("Input * to reverse string");
                Console.WriteLine("Input 0 to return to main menu");
                string input = Console.ReadLine();
                if (input == "0" || input.Length == 0) break;

                char nav = input[0];
                string value = input.Substring(1);
                switch(nav)
                {
                    case '+':
                        if (value.Length == 0)
                            Console.WriteLine("Name can not be empty");
                        else
                            theStack.Push(value);
                        break;
                    case '-':
                        if (theStack.Count > 0)
                            theStack.Pop();
                        else
                            Console.WriteLine("The stack is empty");
                        break;
                    case '*':
                        if (value.Length == 0)
                            Console.WriteLine("String name can not be empty");
                        else
                            Console.WriteLine("Reverse string :" + ReverseString(value));
                        break;
                    default:
                        Console.WriteLine("Please only use +,- or # to update stack");
                        break;
                }

            } while (true);
        }

        



        /* private static string ReverseString(string value)
         {
             throw new NotImplementedException();
         }*/
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            do
            {
                Console.Clear();
                Console.WriteLine("Please input string to chek paranthesis");
                Console.WriteLine("Please enter to get back to menu");
                string input = Console.ReadLine();

                //user enter empty string
                if (input.Length == 0) break;

                Queue theQueue = new Queue();
                char[] paranthesis = new char[] { '<', '>', '{', '}', '[', ']', '(', ')' };

                Stack theStack = new Stack();
                foreach (char ch in input)
                {
                    if (paranthesis.Contains(ch))
                    {
                        if (theStack.Count == 0 || !MatchCouple((char)theStack.Peek(), ch))
                        {
                            theStack.Push(ch);
                        }
                        else
                        {
                            theStack.Pop();
                        }
                    }

                }
                if (theStack.Count == 0)
                    Console.WriteLine("Input string is good");
                else
                    Console.WriteLine("The string is not good");
                Console.ReadLine();
            } while (true);
        }

        private static bool MatchCouple(char v, char ch)
        {
            throw new NotImplementedException();
        }

        private static string DisplayList(List<string> theList)
        {
            string output = "";
            if (theList.Count == 0) output += "Empty";
            else
            {
                foreach (string p in theList)
                {
                    output += p + "\n";
                }
            }
            output += "\nThe List capacity is: " + theList.Capacity;
            return output;
        }
        private static string DisplayList(ICollection theList)
        {
            string output = theList.GetType().Name + " contains: \n";
            if (theList.Count == 0) output += "Empty";
            else
            {
                foreach(var n in theList)
                {
                    output += n + "\n";
                }
            }
            output += "\nTotal: " + theList.Count;
            return output;
        }
        private static string ReverseString(string input)
        {
            //throw new NotImplementedException();
            Stack theStack = new Stack();
            string output = "";
            foreach (char ch in input)
            {
                theStack.Push(ch);
            }
            while (theStack.Count > 0)
            {
                output += theStack.Pop();
            }
            return output;
        }
      
    }

        
    }


