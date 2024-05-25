using static System.Console;

namespace Project
{
    public class Threading
    {
        static async Task Initialize()
        {
            // Create a list of tasks
            var tasks = new List<Task>();

            // Use Parallel.ForEach to parallelize the loop
            Parallel.ForEach(Enumerable.Range(0, 10), async (i) =>
            {
                // Capture the loop variable in a local copy
                var taskId = i;

                // Create a task that simulates work
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        // Simulate work by sleeping for a random duration
                        await Task.Delay(new Random().Next(1000, 5000));
                        lock (Out)
                        {
                            WriteLine($"Task {taskId} completed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        WriteLine($"Task {taskId} failed: {ex.Message}");
                    }
                }));
            });

            // Wait for all tasks to complete
            try
            {
                await Task.WhenAll(tasks);
                WriteLine("All tasks completed!");
            }
            catch (Exception ex)
            {
                WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
