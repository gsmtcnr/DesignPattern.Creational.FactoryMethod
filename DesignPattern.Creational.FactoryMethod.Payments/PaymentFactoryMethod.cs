using DesignPattern.Creational.FactoryMethod.Payments.Implementations.XBank;
using DesignPattern.Creational.FactoryMethod.Payments.Implementations.YBank;
using DesignPattern.Creational.FactoryMethod.Payments.Implementations.ZBank;
using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments
{
    public static class PaymentFactoryMethod
    {
        public static IPayment InitializePayment(string cardNumber)
        {
            //Cards starting with number 1 XBank
            //Cards starting with number 2 YBank
            //Cards starting with number 3 ZBank

            IPayment payment = cardNumber switch
            {
                string s when s.StartsWith("1") => new XBankPayment(),
                string s when s.StartsWith("2") => new YBankPayment(),
                string s when s.StartsWith("3") => new ZBankPayment(),
                _ => new XBankPayment(),
            };

            return payment;
        }
    }
}
