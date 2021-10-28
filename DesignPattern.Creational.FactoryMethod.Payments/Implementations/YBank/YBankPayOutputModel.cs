using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.YBank
{
    public class YBankPayOutputModel : IPayOutputModel
    {
        public string BankName { get; set; }
        public string TransactionId { get; set; }
    }
}
