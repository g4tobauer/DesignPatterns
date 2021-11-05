using DesignPatterns.Structures.Tasks.Interfaces;
using System;

namespace DesignPatterns.Structures.Tasks.Examples
{
    public class Executable : IExecutable
    {
        public string Name { get; set; }
        public void Execute()
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(string.Format("Contador: {0}", i));
                Console.WriteLine(Name);
            }
        }
    }
}
