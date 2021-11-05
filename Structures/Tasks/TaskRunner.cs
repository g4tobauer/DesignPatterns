using DesignPatterns.Structures.Runner;
using DesignPatterns.Structures.Tasks.Interfaces;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Structures.Tasks
{
    public class TaskRunner : IRunner
    {

        private static int _nextId = 0;

        public bool IsSynchronized { get; set; }
        public bool IsFinished { get; set; }
        public int Id { get; private set; }

        public IExecutable Executable{ get; set; }
        

        public TaskRunner()
        {
            Id = _nextId++;
        }

        public void Run()
        {
            Executable.Execute();
            IsFinished = true;
        }
    }
}
