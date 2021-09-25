using System.Collections.Generic;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto
{
    public class Request
    {
        public object Data { get; set; }
        public List<string> ValidationMessages;

        public Request()
        {
            ValidationMessages = new List<string>();
        }

        public Request(object data) : this()
        {
            Data = data;
        }
    }
}
