using static System.Console;

namespace Project
{
    class HotkeyManager
    {
        private Dictionary<ConsoleKey, Action> hotkeys = new Dictionary<ConsoleKey, Action>();
        private bool isRunning = true;
        private Thread? listenerThread;

        public HotkeyManager()
        {
            listenerThread = new Thread(ListenHotkeys);
            listenerThread.Start();
        }

        public static void Initialize()
        {
            HotkeyManager? manager = new HotkeyManager();
            manager?.StartInputThread();
            manager?.AddHotkey(ConsoleKey.A, TestFunction);
        }

        public static void TestFunction()
        {
            WriteLine("Test function executed.");
        }

        public void AddHotkey(ConsoleKey key, Action function)
        {
            hotkeys[key] = function;
        }

        public void RemoveHotkey(ConsoleKey key)
        {
            if (hotkeys.ContainsKey(key))
            {
                hotkeys.Remove(key);
            }
        }

        public void Stop()
        {
            isRunning = false;
            listenerThread?.Join();
        }

        private void ListenHotkeys()
        {
            while (isRunning)
            {
                if (KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = ReadKey(true);
                    if (hotkeys.ContainsKey(keyInfo.Key))
                    {
                        WriteLine($"Executing function for hotkey: {keyInfo.Key}");
                        hotkeys[keyInfo.Key]?.Invoke();
                    }
                }
            }
        }

        public void StartInputThread()
        {
            Thread inputThread = new Thread(ListenForInput);
            inputThread.Start();
        }

        private void ListenForInput()
        {
            while (isRunning)
            {
                WriteLine("Enter the hotkey combination (e.g., 'a', 'Ctrl+c', 'Alt+x'): ");
                ConsoleKeyInfo keyInfo = ReadKey();
                WriteLine();
                WriteLine("Enter the function name to be executed when the hotkey is pressed: ");
                string? functionName = ReadLine();
                if (!string.IsNullOrEmpty(functionName))
                {
                    try
                    {
                        Action? function = null;
                        if (typeof(Program).GetMethod(functionName) != null)
                        {
                            function = (Action)Delegate.CreateDelegate(typeof(Action), typeof(Program), functionName);
                            WriteLine($"Hotkey '{keyInfo.KeyChar}' added successfully. Press the hotkey to execute the function '{functionName}'.");
                        }
                        else
                        {
                            WriteLine("Function not found. Please enter a valid function name.");
                        }
                    }
                    catch (Exception)
                    {
                        WriteLine("Function not found. Please enter a valid function name.");
                    }
                }
                else
                {
                    WriteLine("Function name cannot be empty. Please enter a valid function name.");
                }
            }
        }
    }
}
