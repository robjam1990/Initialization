using System;
using System.Collections.Generic;
using System.IO;

namespace FileEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Usage examples

            // Example for changing file content
            List<Dictionary<string, string>> fileContentChanges = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string> { {"file_path", "file1.txt"}, {"new_content", "Alek is good"} },
                new Dictionary<string, string> { {"file_path", "new_file2.txt"}, {"new_content", "I am the best"} },
                // Add more files as needed
            };

            ExecuteFileContentChanges(fileContentChanges);

            // Example for renaming files
            List<Dictionary<string, string>> fileRenames = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string> { {"file_path", "file1.txt"}, {"new_file_name", "renamed_file1.txt"} },
                new Dictionary<string, string> { {"file_path", "new_file2.txt"}, {"new_file_name", "new_file2_renamed.txt"} },
                // Add more files as needed
            };

            ExecuteFileRenames(fileRenames);

            // Example for creating and saving text files
            List<Dictionary<string, string>> fileCreationInfo = new List<Dictionary<string, string>>
            {
                new Dictionary<string, string> { {"file_path", "file1.txt"}, {"text", "Alek is good"} },
                new Dictionary<string, string> { {"file_path", "new_file2.txt"}, {"text", "I am the best"} },
                // Add more files as needed
            };

            CreateAndSaveTextFiles(fileCreationInfo);

            // Open the created text files
            OpenFiles(fileCreationInfo);
        }

        static void CreateAndSaveTextFiles(List<Dictionary<string, string>> fileInfoList)
        {
            foreach (var fileInfo in fileInfoList)
            {
                string filePath = fileInfo["file_path"];
                string text = fileInfo["text"];

                try
                {
                    File.WriteAllText(filePath, text);
                    Console.WriteLine($"File '{filePath}' created and saved.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating or saving file '{filePath}': {ex.Message}");
                }
            }
        }

        static void OpenFiles(List<Dictionary<string, string>> fileInfoList)
        {
            foreach (var fileInfo in fileInfoList)
            {
                string filePath = fileInfo["file_path"];

                try
                {
                    System.Diagnostics.Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error opening file '{filePath}': {ex.Message}");
                }
            }
        }

        static void ExecuteFileContentChanges(List<Dictionary<string, string>> fileInfoList)
        {
            foreach (var fileInfo in fileInfoList)
            {
                string filePath = fileInfo["file_path"];
                string newContent = fileInfo["new_content"];

                try
                {
                    File.WriteAllText(filePath, newContent);
                    Console.WriteLine($"Content of file '{filePath}' changed.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error changing content of file '{filePath}': {ex.Message}");
                }
            }
        }

        static void ExecuteFileRenames(List<Dictionary<string, string>> fileInfoList)
        {
            foreach (var fileInfo in fileInfoList)
            {
                string filePath = fileInfo["file_path"];
                string newFilePath = fileInfo["new_file_name"];

                try
                {
                    File.Move(filePath, newFilePath);
                    Console.WriteLine($"File '{filePath}' renamed to '{newFilePath}'.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error renaming file '{filePath}' to '{newFilePath}': {ex.Message}");
                }
            }
        }
    }
}
