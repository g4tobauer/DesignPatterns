using DesignPatterns.Structures.Runner;
using DesignPatterns.Structures.Singleton;
using System;
using System.Diagnostics;

namespace DesignPatterns.Structures.Tasks.Examples
{
    class TaskEnveloperRunner : Single<TaskEnveloperRunner>, IRunner
    {
        public void Run()
        {
            var timer = new Stopwatch();

            //timer.Start();
            //for (int i = 0; i < 800000; i++)
            //{
            //    //Console.WriteLine(string.Format("Contador: {0}", i));
            //}
            //timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            //Console.WriteLine("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));

            //timer = new Stopwatch();

            timer.Start();
            for (int i=0; i<2; i++)
            {
                TaskRunner task = new TaskRunner { IsSynchronized = true };
                task.Executable = new Executable { Name = string.Format("exec{0}", i) };
                TaskEnveloper.Instance.CreateTask(task);
            }

            TaskEnveloper.Instance.StartAllTasks();
            TaskEnveloper.Instance.WaitAllTasks();
            timer.Stop();

            timeTaken = timer.Elapsed;

            Console.WriteLine("Time taken: " + timeTaken.ToString(@"m\:ss\.fff"));
        }
    }
}
