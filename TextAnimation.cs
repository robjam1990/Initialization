using static System.Console;
using System;
using System.Threading;

namespace Project
{
    class TextAnimation
    {
        private static object? writer;

        public static object? Name { get; private set; }

        public enum Direction // Enum for the direction of the animation
        {
            Left = '⇦',
            Down = '⇩',
            Up = '⇧',
            Right = '⇨'
        }

        public enum Selection // Enum for the selection of the animation
        {
            Select = '⋙',
            Confirm = '✔',
            Deny = '✖'
        }

        public static void GameTitle() //Displays the game art
        {
            WriteLine(@"
  _____                         _                     _       
 |  __ \                       | |                   (_)      
 | |__) |  ___   _   _    ___  | |__     ___    ___   _   ___ 
 |  ___/  / __| | | | |  / __| | '_ \   / _ \  / __| | | / __|
 | |      \__ \ | |_| | | (__  | | | | | (_) | \__ \ | | \__ \
 |_|      |___/  \__, |  \___| |_| |_|  \___/  |___/ |_| |___/
                  __/ |                                       
                 |___/                                         "); // Print game introduction message
        }

        public static void PlayDeadAnimation() // 3.5 Second animation.
        {
            Clear(); // Clear the console
            ResetColor(); // Reset the text and background colors
            ForegroundColor = ConsoleColor.Yellow; // Set the text color to yellow
            BackgroundColor = ConsoleColor.Black; // Set the background color to black

            WriteLine("( 0 0 )"); // Print the animation
            Thread.Sleep(1200); // Pause for 1.2 seconds
            Clear(); // Clear the console
            WriteLine("( O O )"); // Print the animation
            Thread.Sleep(200); // Pause for 0.2 seconds
            Clear(); // Clear the console
            WriteLine("( o o )"); // Print the animation
            Thread.Sleep(200); // Pause for 0.2 seconds
            Clear(); // Clear the console
            WriteLine("( O O )"); // Print the animation
            Thread.Sleep(200); // Pause for 0.2 seconds
            Clear(); // Clear the console
            WriteLine("( O o )"); // Print the animation
            Thread.Sleep(200); // Pause for 0.2 seconds
            Clear(); // Clear the console
            WriteLine("( O - )"); // Print the animation
            Thread.Sleep(500); // Pause for 0.5 seconds
            Clear(); // Clear the console
            WriteLine("( O o )"); // Print the animation
            Thread.Sleep(200); // Pause for 0.2 seconds
            Clear(); // Clear the console
            WriteLine("( O O )");
            Thread.Sleep(200); // Pause for 0.2 seconds
            Clear(); // Clear the console
            WriteLine("( 0 0 )"); // Print the animation
            Thread.Sleep(800); // Pause for 0.8 seconds


            ReadKey(true); // Wait for a key press
            ResetColor(); // Reset the text and background colors
            Clear(); // Clear the console
        }

        public static void Say(string message, ConsoleColor color, int speed) // Method to display a message with a specified color and speed
        {
            ConsoleColor _ = ForegroundColor; // Store the original color

            ForegroundColor = color; // Set the color
            foreach (char c in message) // Iterate through each character in the message
            {
                Write(c); // Write the character
                Thread.Sleep(speed); // Pause for the specified speed
                if (c == '.' || c == '?' || c == '!') // If the character is a punctuation mark
                {
                    Thread.Sleep(500); // Pause for 0.5 seconds
                }
                else if (c == ',') // If the character is a comma
                {
                    Thread.Sleep(250); // Pause for 0.25 seconds
                }
                else if (c == ' ') // If the character is a space
                {
                    Thread.Sleep(50); // Pause for 0.05 seconds
                }
            }
            if (speed == 0) // If the speed is 0
            {
                ReadKey(true); // Wait for a key press
            }
            else
            {
                WriteLine(); // Move to the next line
            }
        }

        public static void WaitForKey() // Wait for the user to press a key
        {
            WriteLine("Press any key to continue..."); // Display a message
            ReadKey(true); // Read the key
            Clear(); // Clear the console
        }

        public static void WaitForInput() // Wait for the user to press a key
        {
            WriteLine("Press any key to continue..."); // Display a message
            ReadKey(false); // Read the key
            Clear(); // Clear the console
        }
        public static void PrintList(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static void CopyList(string[] array1, string[] array0)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                array0[i] += array1[i];
            }
        }

        public static void Record()
        {
            // Utilizing TextReader and TextWriter for text streams
            using (TextWriter encyclopedia = File.CreateText($"{Name}.Encyclopedia"))
            {
                WriteLine("Hello, Thear!");


                using (TextReader reader = File.OpenText($"{Name}.Encyclopedia"))
                {
                    string line = reader.ReadLine()!;
                    WriteLine("Read from file: " + line);
                }
            }
        }
    }
}
