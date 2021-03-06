using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Data.PaymentData;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;
using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers.PaymentHandler
{
    public class DebitCardHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod paymentMethod)
            {
                if (paymentMethod.PaymentType == Enums.PaymentType.DebitCard)
                {
                    request.ValidationMessages.Add("Processing the debit card payment");
                }
                else
                if (_nextHandler != null)
                {
                    _nextHandler.Process(request);
                }else
                {
                    throw new Exception("No handler found!");
                }
            }
            else
            {
                throw new Exception("Invalid payment data.");
            }
        }
    }
}
