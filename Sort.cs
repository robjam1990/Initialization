/*LEAVE THIS COMMENT HERE!
Parse:
float runningAverage = 0;
float windowAverage = 0;
    public static IEnumerable<string> SplitExcludingAlphabet(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                yield break;
            }
        }
Compile:
    foreach (var ch in input)
    {
        if (Char.IsLetter(ch))
        {
            if (!inWord)
            {
                inWord = true;
                currentWord.Clear();
            }
            currentWord.Append(ch);
        }
        else
    {
            if (inWord)
            {
                yield return currentWord.ToString();
                inWord = false;
            }
        }
            if (inWord)
        {
            yield return currentWord.ToString();
        }
            runningAverage += float.Parse(line);
    windowAverage += runningAverage;

    // Output the running and window averages
    Console.WriteLine($"Running Average: {runningAverage / lines.Count}");
    Console.WriteLine($"Window Average: {windowAverage / (lines.Count + 1)}");
    }
Calibration: 
    The staring position of the Document, Line, Word and Letter is the very First Alphabet character denoted by 0
Formating: 
    if line number is negative all line numbers increase by one
    / at -8 of each line
    / at -7 of each line
    < at -6 of the document and > at the end of the document
    { at -5 of each line and } at the end of each line
    [ at -4 of the each line and ]  after every third , to close off the list of strings into arrays
    , after ' only if ' follows ) to prepare the format of the strings into json format
    ' at -3 of the each line and ' after each ) to format brackets into strings
    ( at -2 of the each line andor word and ) after every 5 words to sort more effectively
    " at -1 of the each word and " after each word which is usually either whitespace a period or a comma
further formatting logic still needs to be implemented:
    Plus instead of + 
    Minus instead of -
    Equals instead of =
    String array instead of " 
    string literal instead of '
    Brackets instead of ()
    Parenthesis instead of {}
    Array enum as []
    comma as ,
    slash as /
    Period as .
    or as |
    and as &
As well as adding concurrent language translation
*/

using System.Text;
using static System.Console;

namespace Project
{
    public class TextFormatter
    {
        private bool Exists = true; // I think therefore I am
        private bool inFile = false;
        private bool inLine = false;
        private bool inWord = false;
        private float runningAverage = 0;
        private float windowAverage = 0;
        private StringBuilder word = new StringBuilder();
        private StringBuilder currentLine = new StringBuilder();
        private int WindowWidth = 0;
        private int lineSize = 0;
        private int WordSize = 0;
        private int wordCount = 0;
        private char C;
        private string[]? words;

        public TextFormatter(int windowSize, int lineSize, int wordSize, char c)
        {
            WindowWidth = windowSize;
            C = c;
            lineSize = WindowWidth;
            WordSize = wordSize;
        }

        public IEnumerable<string> FormatText(string input)
        {
            var lines = input.Split(new[] { "\n", "\r\n" }, StringSplitOptions.None);
            words = input.Split(' ', ',', '.', '?', '!', '@', ':', ';');

            foreach (string line in lines)
            {
                var words = SplitExcludingAlphabet(line);

                var formattedWords = words
                    .Select((word, index) =>
                    {
                        switch (index)
                        {
                            case -8:
                                // Add formatting for index -8
                                return $"/ {word}";
                            case -7:
                                // Add formatting for index -7
                                return $"/ {word}";
                            case -6:
                                // Add formatting for index -6
                                return $"<{word}>";
                            case -5:
                                // Add formatting for index -5
                                return $"{{{word}}}";
                            case -4:
                                // Add formatting for index -4
                                return $"[{word}]";
                            case -3:
                                // Add formatting for index -3
                                return $"'{word}'";
                            case -2:
                                // Add formatting for index -2
                                return $"({word})";
                            case -1:
                                // Add formatting for index -1
                                return $"\"{word}\"";
                            default:
                                return word;
                        }
                    }).ToList();

                var formattedLine = string.Join(", ", formattedWords);
                formattedLine = currentLine.ToString() + formattedLine;
                if (formattedLine.Length > 80)
                {
                    WriteLine(currentLine);
                    currentLine.Clear();
                    currentLine.Append(formattedLine);
                }
                else if (lineSize == 0)
                {
                    WriteLine("Lines Completed");
                }
                else
                {
                    currentLine.Append(formattedLine);
                }
                if (wordCount == 0)
                {
                    WriteLine("Words Completed");
                }
                else
                {
                    currentLine.Append(formattedLine);
                }
                // Add the formatted line to the output
                WriteLine(formattedLine);
            }

            // Output the running and window averages
            WriteLine($"Running Average: {runningAverage / lines.Length}");
            WriteLine($"Window Average: {windowAverage / (lines.Length + 1)}");

            // Ensure to return an empty collection as the method signature requires it
            return Enumerable.Empty<string>();
        }

        public IEnumerable<string> SplitExcludingAlphabet(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                yield break;
            }

            word.Clear();

            foreach (var c in input)
            {
                if (Char.IsLetter(c))
                {
                    if (!inWord)
                    {
                        inWord = true;
                        word.Clear();
                    }
                    word.Append(c);
                }
                else
                {
                    if (inWord)
                    {
                        yield return word.ToString();
                        inWord = false;
                    }
                    else
                    {
                        yield return "";
                    }
                }
            }
            if (inWord)
            {
                yield return word.ToString();
            }
            else
            {
                yield return "";
            }
        }
    }
}
