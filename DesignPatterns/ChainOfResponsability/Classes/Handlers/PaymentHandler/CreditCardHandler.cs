﻿using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Data.PaymentData;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;
using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers.PaymentHandler
{
    public class CreditCardHandler : BaseHandler
    {
        public override void Process(Request request)
        {
            if (request.Data is PaymentMethod paymentMethod)
            {
                if (paymentMethod.PaymentType == Enums.PaymentType.CreditCard)
                {
                    request.ValidationMessages.Add("Processing the credit card payment");
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
