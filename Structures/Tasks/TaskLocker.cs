using DesignPatterns.Structures.Singleton;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structures.Tasks
{
    public class TaskLocker : Single<TaskLocker>
    {
        private Queue<TaskRunner> _queueTaskRunner = new Queue<TaskRunner>();

        public void EnqueueTaskRunner(TaskRunner taskRunner)
        {
            _queueTaskRunner.Enqueue(taskRunner);
        }
        public void DequeueTaskRunner()
        {
            _queueTaskRunner.Dequeue();
        }

        public bool HasTheLock(TaskRunner taskRunner)
        {
            return _queueTaskRunner.Peek() == taskRunner;
        }
    }
}
