using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Data.PersonData;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;
using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers.PersonHandler
{
    public class MaxNameLengthHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if (person.Name.Length > 10)
                {
                    //person.Name = string.Empty;
                    request.ValidationMessages.Add("Invalid name length");
                }
                if (_nextHandler != null) _nextHandler.Process(request);
            }else
            {
                throw new Exception("Invalid message data.");
            }
        }
    }
}
