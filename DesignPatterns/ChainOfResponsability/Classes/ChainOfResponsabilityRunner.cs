using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Data.PaymentData;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Data.PersonData;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Dto;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers.PaymentHandler;
using DesignPatterns.DesignPatterns.ChainOfResponsability.Classes.Handlers.PersonHandler;
using System;

namespace DesignPatterns.DesignPatterns.ChainOfResponsability.Classes
{
    public class ChainOfResponsabilityRunner : IRunner
    {
        public void Run()
        {
            ProcessPerson();
            ProcessPayment();
        }

        private void ProcessPerson()
        {
            var person = new Person
            {
                Age = 56,
                Name = "Joao Vitor Pierazo de Matos",
                Income = 1001
            };
            var request = new Request(person);
            var maxAgeHandler = new MaxAgeHandler();
            
            maxAgeHandler
                .SetNextHandler(new MaxNameLengthHandler())
                .SetNextHandler(new MaxIncomeHandler());

            maxAgeHandler.Process(request);
            request.ValidationMessages.ForEach(c =>
            {
                Console.WriteLine(c);
            });
            Console.WriteLine(string.Format("Name: {0}, Age: {1}, Income: {2}", person.Name, person.Age, person.Income));
            //Console.ReadKey();
        }

        private void ProcessPayment()
        {
            var payment = new PaymentMethod
            {
                PaymentType = Enums.PaymentType.PaymentWallet
            };
            var request = new Request(payment);
            var creditCardHandler = new CreditCardHandler();

            creditCardHandler
                .SetNextHandler(new DebitCardHandler())
                .SetNextHandler(new NetBankingHandler())
                .SetNextHandler(new PaymentWalletHandler());

            creditCardHandler.Process(request);
            request.ValidationMessages.ForEach(c =>
            {
                Console.WriteLine(c);
            });
            //Console.ReadKey();
        }
    }
}
