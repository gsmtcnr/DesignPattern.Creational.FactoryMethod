using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.YBank
{
    public class YBankPayment : IPayment
    {
        public IPayOutputModel Pay(IPayInputModel payInputModel)
        {
            YBankPayInputModel inputModel = (YBankPayInputModel)payInputModel;

            //pay..

            return new YBankPayOutputModel
            {
                BankName = typeof(YBankPayment).Name,
                TransactionId = nameof(YBankPayment) + inputModel.OrderNumber
            };

        }
    }
}
