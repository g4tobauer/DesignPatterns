using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Data.PersonData;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;
using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers.PersonHandler
{
    public class MaxIncomeHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if(request.Data is Person person)
            {
                if (person.Income > 1000)
                {
                    //person.Income = 0;
                    request.ValidationMessages.Add("Invalid income length");
                }
                if (_nextHandler != null) _nextHandler.Process(request);
            }else
            {
                throw new Exception("Invalid message data.");
            }
        }
    }
}
