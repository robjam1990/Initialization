using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; // Added for StringBuilder
using static System.Console;
/*
namespace Project
{
    public class Radiation
    {
        // Changed the dictionary value type to char instead of string


        public string EncodeMessage(string message, string flow = "Map")
        {
            var entropyArray = ReinverseEntropy(flow);
            var encodedMessage = new StringBuilder(); // Using StringBuilder for better performance
            foreach (var character in message)
            {
                encodedMessage.Append(entropyArray.ContainsKey(character) ? entropyArray[character] : character);
            }
            return encodedMessage.ToString();
        }

        public string DecodeMessage(string encodedMessage, string flow = "Map")
        {
            var entropyArray = Entropy(flow);
            var decodedMessage = new StringBuilder(); // Using StringBuilder for better performance
            foreach (var character in encodedMessage)
            {
                decodedMessage.Append(entropyArray.ContainsKey(character) ? entropyArray[character] : character);
            }
            return decodedMessage.ToString();
        }

        public Dictionary<char, char> ReinverseEntropy(string flow = "Map")
        {
            return Entropy(flow).ToDictionary(entry => entry.Value, entry => entry.Key);
        }
    }

    class Radiate
    {
        static void InitializeComponent()
        {
            Radiation radiate = new Radiation();
            var message = "Hello, World!";
            var encodedMessage = radiate.EncodeMessage(message);
            var decodedMessage = radiate.DecodeMessage(encodedMessage);

            var cache = new StringBuilder(); // Changed StringCache to StringBuilder
            var radiateInstance = new Radiate();
            radiateInstance.Run(message, cache);
        }

        // Changed the parameter type from StringCache to StringBuilder
        void Run(string message, StringBuilder cache)
        {
            cache.AppendLine($"Original message: {message}");
            WriteLine("Encoded message: " + Radiate.EncodeMessage(message)); // Fixed referencing issues
            WriteLine("Decoded message: " + Radiate.DecodeMessage(message)); // Fixed referencing issues
        }
    }
}
*/