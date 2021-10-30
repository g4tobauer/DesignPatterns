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

            TaskRunner taskRunner1 = new TaskRunner();
            taskRunner1.Executable = new Executable { Name = "exec1" };

            TaskRunner taskRunner2 = new TaskRunner();
            taskRunner2.Executable = new Executable {Name = "exec2" };

            //taskRunner1.IsSynchronized = true;
            //taskRunner2.IsSynchronized = true;

            timer.Start();
            TaskEnveloper.Instance.CreateTask(taskRunner1);
            TaskEnveloper.Instance.CreateTask(taskRunner2);
            TaskEnveloper.Instance.StartAllTasks();
            TaskEnveloper.Instance.WaitAllTasks();
            timer.Stop();

            timeTaken = timer.Elapsed;

            Console.WriteLine("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
        }
    }
}
