using DesignPattern.Creational.FactoryMethod.Payments;
using DesignPattern.Creational.FactoryMethod.Payments.Implementations.XBank;
using DesignPattern.Creational.FactoryMethod.Payments.Interfaces;
using Shouldly;
using System;
using Xunit;

namespace DesignPattern.Creational.FactoryMethod.Tests
{
    public class XBankPaymentTests
    {
        [Fact]
        public void Pay_Should_Be_Success()
        {
            // Arrange

            IPayInputModel payInputModel = new XBankPayInputModel
            {
                CardNumber = "123123",
                Price = 1000M,
                OrderNumber = Guid.NewGuid().ToString()
            };

            //FactorMethod call
            IPayment payment = PaymentFactoryMethod.InitializePayment(payInputModel.CardNumber);

            // Act

            IPayOutputModel payOutputModel = payment.Pay(payInputModel);

            // Assert

            payOutputModel.ShouldNotBeNull();
            payOutputModel.BankName.ShouldBe(payment.GetType().Name);
        }
    }
}
