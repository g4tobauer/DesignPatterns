using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Interfaces
{
    public interface IHandler
    {
        public IHandler SetNextHandler(IHandler hanlder);
        public void Process(Request request);
    }
}
