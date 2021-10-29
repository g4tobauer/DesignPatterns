using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structures.Runner
{
    public static class StructureRunner
    {
        public static void RunStructure(IRunner runner)
        {
            runner.Run();
        }
    }
}
