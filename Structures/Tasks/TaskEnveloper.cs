using DesignPatterns.Structures.Runner;
using DesignPatterns.Structures.Singleton;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatterns.Structures.Tasks
{
    public class TaskEnveloper : Single<TaskEnveloper>
    {
        private static readonly List<Task> _lstTasks = new List<Task>();

        public int CountTasks { get { return _lstTasks.Count; } }

        public void CreateTask(TaskRunner taskRunner)
        {
            var task = new Task(ActionMethod, taskRunner);
            _lstTasks.Add(task);
        }

        public void StartAllTasks()
        {
            _lstTasks.ForEach(task =>
            {
                switch(task.Status)
                {
                    case TaskStatus.Created:
                        task.Start();
                        break;
                }
            });
        }

        public void WaitAllTasks()
        {
            Task.WaitAll(_lstTasks.ToArray());
        }

        private class TaskEnveloperExecutable
        {
            public static int Index { get; set; }
            public bool StopExecutable { get; set; }
        }

        private void ActionMethod(object obj)
        {
            TaskRunner taskRunner = (TaskRunner)obj;
            TaskEnveloperExecutable executable = new TaskEnveloperExecutable();

            while (!executable.StopExecutable)
            {
                if (CountTasks == 0) break;
                lock (executable)
                {
                    if (executable.StopExecutable)
                    {
                        ++TaskEnveloperExecutable.Index;
                        break;
                    }

                    if(taskRunner.IsSynchronized)
                    {
                        while (taskRunner.Id != TaskEnveloperExecutable.Index) ;
                    }

                    StructureRunner.RunStructure(taskRunner);
                    executable.StopExecutable = true;

                    if (TaskEnveloperExecutable.Index == (CountTasks - 1)) TaskEnveloperExecutable.Index = 0;
                    else ++TaskEnveloperExecutable.Index;

                    Task.Yield();
                }
            }
        }
    }
}
