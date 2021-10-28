using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.ZBank
{
    public class ZBankPayment : IPayment
    {
        public IPayOutputModel Pay(IPayInputModel payInputModel)
        {
            ZBankPayInputModel inputModel = (ZBankPayInputModel)payInputModel;

            //pay..

            return new ZBankPayOutputModel
            {
                BankName = typeof(ZBankPayment).Name,
                TransactionId = nameof(ZBankPayment) + inputModel.OrderNumber
            };
        }
    }
}
