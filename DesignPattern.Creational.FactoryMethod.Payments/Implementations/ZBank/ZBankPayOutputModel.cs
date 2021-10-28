using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.ZBank
{
    public class ZBankPayOutputModel : IPayOutputModel
    {
        public string BankName { get; set; }
        public string TransactionId { get; set; }
    }
}
