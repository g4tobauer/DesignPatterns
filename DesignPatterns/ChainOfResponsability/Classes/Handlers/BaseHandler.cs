using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Interfaces;
using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers
{
    public class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;

        public BaseHandler()
        {
            _nextHandler = null;
        }

        public virtual void Process(Request request)
        {
            throw new NotImplementedException();
        }

        public IHandler SetNextHandler(IHandler hanlder)
        {
            _nextHandler = hanlder;
            return _nextHandler;
        }
    }
}
