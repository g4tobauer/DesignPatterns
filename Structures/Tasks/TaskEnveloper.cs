using DesignPatterns.Structures.Runner;
using DesignPatterns.Structures.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Structures.Tasks
{
    public class TaskEnveloper : Single<TaskEnveloper>
    {
        private readonly List<Task> _lstTasks = new List<Task>();
        private readonly List<Task> _lstTasksQueue = new List<Task>();



        public void CreateTask(TaskRunner taskRunner)
        {
            TaskLocker.Instance.EnqueueTaskRunner(taskRunner);
            AddTask(new Task(ActionMethod, taskRunner));
        }

        public void StartAllTasks()
        {
            _lstTasks.ForEach(task =>
            {
                StartTask(task);
            });
        }

        public void WaitAllTasks()
        {
            var taskIndex = Task.WaitAny(_lstTasks.ToArray());
            if (taskIndex < 0) return;

            lock (TaskLocker.Instance)
            {
                RemoveTask(taskIndex);
            }
            WaitAllTasks();
        }

        private void AddTask(Task task)
        {
            if (_lstTasks.Count < 8)
            {
                _lstTasks.Add(task);
            }
            else if (!_lstTasksQueue.Contains(task)) _lstTasksQueue.Add(task);
        }

        private void StartTask(Task task)
        {
            switch (task.Status)
            {
                case TaskStatus.Created:
                    task.Start();
                    break;
            }
        }

        private void RemoveTask(int index)
        {
            _lstTasks.Remove(_lstTasks[index]);
            if (_lstTasksQueue.Any())
            {
                var task = _lstTasksQueue.First();
                _lstTasksQueue.Remove(task);
                AddTask(task);
                StartAllTasks();
            }
        }

        private void ActionMethod(object obj)
        {
            TaskRunner taskRunner = (TaskRunner)obj;

            while (!taskRunner.IsFinished)
            {
                lock (TaskLocker.Instance)
                {
                    if(TaskLocker.Instance.HasTheLock(taskRunner))
                    {
                        StructureRunner.RunStructure(taskRunner);
                        TaskLocker.Instance.DequeueTaskRunner();
                        if (!taskRunner.IsFinished)
                            TaskLocker.Instance.EnqueueTaskRunner(taskRunner);
                    }
                }
            }
        }

    }
}
