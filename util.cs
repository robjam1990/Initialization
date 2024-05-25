```csharp
 using System;
using System.IO;

namespace Translate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create or overwrite the file "example.md" and write some text to it.
            File.WriteAllText("example.md", "Translating files in C#");

            // Append text to the existing file.
            string str = "Done working with files in C#";
            File.AppendAllText("example.md", str);

            // Read the content of the file and print it to the console.
            string txt = File.ReadAllText("example.md");
            Console.WriteLine(txt);
        }
    }
}
```

```csharp
 using System;
using System.Collections;
using System.Text;

namespace BitArray
{
    class Program
    {
        // Printing BitArray
        public static void PrintBarr(string name, BitArray ba)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(name);
            sb.Append(" : ");

            for (int x = 0; x < ba.Length; x++)
            {
                sb.Append(ba.Get(x));
                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }

        public static void Main(string[] args)
        {
            BitArray ba1 = new BitArray(4);
            BitArray ba2 = new BitArray(4);

            ba1.SetAll(true);
            ba2.SetAll(false);

            ba1.Set(2, false);
            ba2.Set(3, true);

            PrintBarr("ba1", ba1);
            PrintBarr("ba2", ba2);

            Console.WriteLine();
            PrintBarr("ba1 AND ba2", ba1.And(ba2));
            PrintBarr("NOT ba2", ba2.Not());
        }
    }
}

```