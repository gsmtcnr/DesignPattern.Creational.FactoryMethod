namespace DesignPattern.Creational.FactoryMethod.Payments.Interfaces
{
    public interface IPayInputModel
    {
        public string OrderNumber { get; set; }
        public string CardNumber { get; set; }
        public decimal Price { get; set; }
    }
}
