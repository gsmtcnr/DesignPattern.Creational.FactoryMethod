using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;

namespace DesignPattern.Creational.FactoryMethod.Payments.Implementations.YBank
{
    public class YBankPayInputModel : IPayInputModel
    {
        public string OrderNumber { get; set; }
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
    }
}
