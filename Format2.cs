using System;
using System.IO;

namespace CS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Usage: dotnet run input_file1 input_file2 ... output_file");
                Environment.Exit(1);
            }

            string[] filePaths = new string[args.Length - 1];
            Array.Copy(args, filePaths, args.Length - 1);
            string outputFile = args[args.Length - 1];

            try
            {
                FormatToCSharp(filePaths, outputFile);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        public static void FormatToCSharp(string[] filePaths, string outputFile)
        {
            try
            {
                using (StreamWriter formattedFile = new StreamWriter(outputFile))
                {
                    foreach (string filePath in filePaths)
                    {
                        try
                        {
                            string content = ReadFileContent(filePath);
                            string extension = GetFileExtension(filePath);

                            switch (extension)
                            {
                                case "js":
                                    content = ConvertJavaScriptToCSharp(content);
                                    break;
                                case "json":
                                    content = ConvertJsonToCSharp(content);
                                    break;
                                case "cs":
                                    // No conversion needed for C# files
                                    break;
                                default:
                                    throw new NotSupportedException($"Unsupported file extension: {extension}");
                            }

                            formattedFile.WriteLine(content);
                        }
                        catch (FileNotFoundException)
                        {
                            Console.WriteLine($"Input file '{filePath}' not found.");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred while processing '{filePath}': {ex.Message}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An unexpected error occurred: {e.Message}");
            }
        }

        private static string ReadFileContent(string filePath)
        {
            using (StreamReader originalFile = new StreamReader(filePath))
            {
                return originalFile.ReadToEnd();
            }
        }

        private static string GetFileExtension(string filePath)
        {
            return Path.GetExtension(filePath)?.Substring(1).ToLower() ?? string.Empty;
        }

        private static string ConvertJavaScriptToCSharp(string content)
        {
            // Convert JavaScript function declarations to C# method declarations
            return content.Replace("function ", "public static void ")
                          .Replace("{", "{}")
                          .Replace("}", "}");
        }

        private static string ConvertJsonToCSharp(string content)
        {
            // JSON files don't need conversion for C# compatibility
            return content;
        }
    }
}
