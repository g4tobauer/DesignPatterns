using DesignPatterns.Structures.Runner;
using System;
using System.Diagnostics;

namespace DesignPatterns.Structures.Tasks.Examples
{
    class TaskEnveloperRunner : IRunner
    {

        public void Run()
        {
            var timer = new Stopwatch();

            timer.Start();
            for (int i = 0; i < 8000; i++)
            {
                //Console.WriteLine(string.Format("Contador: {0}", i));
            }
            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));

            timer = new Stopwatch();

            timer.Start();
            TaskEnveloper.CreateTask(new TaskEnveloper.Teste());
            TaskEnveloper.CreateTask(new TaskEnveloper.Teste());
            TaskEnveloper.StartAllTasks();
            TaskEnveloper.WaitAllTasks();
            timer.Stop();

            timeTaken = timer.Elapsed;

            Console.WriteLine("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
        }
    }
}
