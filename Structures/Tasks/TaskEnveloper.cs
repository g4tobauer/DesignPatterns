using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structures.Tasks
{
    public sealed class TaskEnveloper
    {
        private static readonly List<Task> _lstTasks = new List<Task>();

        public static int CountTasks { get { return _lstTasks.Count; } }
        public TaskEnveloper()
        {
        }

        public static void CreateTask(object obj)
        {
            var task = new Task(ActionMethod, obj);
            _lstTasks.Add(task);
        }

        public static void StartAllTasks()
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

        public static void WaitAllTasks()
        {
            Task.WaitAll(_lstTasks.ToArray());
        }

        public class Teste
        {
            private static int NextId = 0;

            public Teste()
            {
                Id = NextId++;
            }

            public static int Index { get; set; }
            public int Id { get; private set; }
            public string MyProperty { get; set; }
            public bool StopTeste { get; set; }
        }

        public static void ActionMethod(object obj)
        {
            Teste teste = (Teste)obj;
            int count = 4000;

            while (!teste.StopTeste)
            {
                if (CountTasks == 0) break;
                lock (teste)
                {
                    if (teste.StopTeste)
                    {
                        ++Teste.Index;
                        break;
                    }

                    while (teste.Id != Teste.Index) ;
                    //Console.WriteLine(string.Format("Contador: {0} - Id: {1}", count, teste.Id));

                    --count;
                    if (count < 0) teste.StopTeste = true;


                    if (Teste.Index == (CountTasks - 1))
                        Teste.Index = 0;
                    else
                        ++Teste.Index;

                    Task.Yield();
                }
            }
        }
    }
}
