using DesignPatterns.DesignPatterns;
using DesignPatterns.DesignPatterns.AbstractFactory.Classes;
using DesignPatterns.DesignPatterns.Adapter.Classes;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes;
using DesignPatterns.Structures.Runner;
using DesignPatterns.Structures.Tasks;
using DesignPatterns.Structures.Tasks.Examples;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {

        static void Main(string[] args)
        {
            StructureRunner.RunStructure(new AdapterRunner());
            StructureRunner.RunStructure(new AbstractFactoryRunner());
            StructureRunner.RunStructure(new ChainOfResponsabilityRunner());
            StructureRunner.RunStructure(new TaskEnveloperRunner());
        }
    }
}
