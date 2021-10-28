namespace DesignPattern.Creational.FactoryMethod.Payments.Interfaces
{
    public interface IPayment
    {
        IPayOutputModel Pay(IPayInputModel payInputModel);
    }
}
