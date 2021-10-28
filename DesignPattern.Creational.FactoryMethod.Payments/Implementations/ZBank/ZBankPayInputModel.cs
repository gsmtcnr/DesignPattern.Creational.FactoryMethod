using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.ZBank
{
    public class ZBankPayInputModel : IPayInputModel
    {
        public string OrderNumber { get; set; }
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
    }
}
