using DesignPatterns.Structures.Tasks.Interfaces;
using System;

namespace DesignPatterns.Structures.Tasks.Examples
{
    public class Executable : IExecutable
    {
        public string Name { get; set; }
        public void Execute()
        {
            Console.WriteLine(Name);
        }
    }
}
