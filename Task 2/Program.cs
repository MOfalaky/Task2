using System.ComponentModel.Design;
using System.Drawing;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection;
            List<int> numbers = new List<int>();

            do
            {
                // Display the menu
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("D - Delete a number");
                Console.WriteLine("C - Clear the list");
                Console.WriteLine("Q - Quit");
                Console.Write("Choose an option : ");
                //selection = Convert.ToChar(Console.ReadLine());

                if (!char.TryParse(Console.ReadLine(), out selection))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                // Process the selection    
                switch (selection)
                {
                    // print the numbers in the list
                    case 'P':
                    case 'p':
                        if (numbers.Count == 0)
                            Console.WriteLine("the list is empty");
                        else
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                            Console.WriteLine();
                        }
                        break;

                    // add a number to the list
                    case 'A':
                    case 'a':
                        Console.WriteLine("Enter a number to add ; ");
                        int newNumber = Convert.ToInt32(Console.ReadLine());
                        bool duplicate = false;
                        for (int i=0; i<numbers.Count; i++)
                        {
                            if(numbers[i] == newNumber)
                            {
                                duplicate = true;
                                break;
                            }
                        }
                        if (duplicate == false)
                        {
                            numbers.Add(newNumber);
                            Console.WriteLine($"Number {newNumber} added ");
                        }
                        else
                        {
                            Console.WriteLine($"Number {newNumber} already exists in the list.");
                        }
                        break;

                    // calculate the mean of the numbers in the list
                    case 'M':
                    case 'm':
                        if(numbers.Count == 0)
                            Console.WriteLine("Unable to calculate the mean - no data available");
                        else
                        {
                            double sum = 0;

                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }

                            double mean = sum / numbers.Count;
                            Console.WriteLine($"The mean of the numbers is: {mean}");
                        }
                        break;

                    // find the smallest number in the list
                    case 'S':
                    case 's':
                        if (numbers.Count != 0)
                        {
                        int small = numbers[0];
                            for(int i =0; i<numbers.Count;i++)
                            {
                                if (numbers[i] < small)
                                    small = numbers[i];
                            }
                        Console.WriteLine($"The smallest number is: {small}" );
                        }
                        else
                        {
                            Console.WriteLine("Unable to determine the smallest number - list is empty");
                        }
                        break;

                    // find the largest number in the list
                    case 'L':
                    case 'l':
                        if (numbers.Count != 0)
                        {
                        int large = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > large)
                                    large = numbers[i];
                            }
                        Console.WriteLine($"The largest number is: {large}" );
                        }
                        else
                        {
                            Console.WriteLine("Unable to determine the largest number - list is empty");
                        }
                        break;

                    // search for a number in the list
                    case 'F':
                    case 'f':
                        Console.WriteLine("enter a number to search for:");
                        int searchNumber = Convert.ToInt32(Console.ReadLine());
                        int index = -1;
                        bool Found = false;
                        for (int i=0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == searchNumber)
                            {
                                index = i;
                                Found = true;
                                break;
                            }
                        }
                        if (Found == true)
                        {
                            Console.WriteLine($"Number {searchNumber} found in the list at index {index}");
                        }
                        else
                        {
                            Console.WriteLine($"Number {searchNumber} not found in the list.");
                        }
                        break;

                    // delete a number from the list
                    case 'D':
                    case 'd':
                        if (numbers.Count == 0)
                        {
                            Console.WriteLine("Unable to delete - list is empty");
                        }
                        else
                        {
                            Console.WriteLine("enter a number to delete:");
                            int deleteNumber = Convert.ToInt32(Console.ReadLine());
                            bool Is_Found = false;
                            if (numbers.Count == 0)
                            {
                                Console.WriteLine("Unable to delete - list is empty");
                            }
                            else
                            {
                                for (int i = 0; i < numbers.Count; i++)
                                {
                                    if (numbers[i] == deleteNumber)
                                    {
                                        numbers.RemoveAt(i);
                                        Is_Found = true;
                                        break;
                                    }
                                }
                            }
                            if (Is_Found == true)
                            {
                                Console.WriteLine($"Number {deleteNumber} deleted from the list.");
                            }
                            else
                            {
                                Console.WriteLine($"Number {deleteNumber} not found in the list.");

                            }
                        }
                        break;

                    // clear the list
                    case 'C':
                    case 'c':
                        numbers.Clear();
                        Console.WriteLine("List cleared");
                        break;

                    // quit the program
                    case 'Q':
                    case 'q':
                        Console.WriteLine("Goodbye");
                        break;

                    // error message for invalid selection
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }

                if (selection != 'Q' && selection != 'q')
                {
                    Console.WriteLine("Enter any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (selection != 'Q' && selection != 'q');
        }
    }
}
