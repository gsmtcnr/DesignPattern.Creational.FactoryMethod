using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.XBank
{
    public class XBankPayment : IPayment
    {
        public IPayOutputModel Pay(IPayInputModel payInputModel)
        {
            XBankPayInputModel inputModel = (XBankPayInputModel)payInputModel;

            //pay..

            return new YBankPayOutputModel
            {
                BankName = typeof(XBankPayment).Name,
                TransactionId = nameof(XBankPayment) + inputModel.OrderNumber
            };

        }
    }
}
