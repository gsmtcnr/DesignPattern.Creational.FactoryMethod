namespace DesignPattern.Creational.FactoryMethod.Payments.Interfaces
{
    public interface IPayOutputModel
    {
        public string BankName { get; set; }
        public string TransactionId { get; }
    }
   
}
