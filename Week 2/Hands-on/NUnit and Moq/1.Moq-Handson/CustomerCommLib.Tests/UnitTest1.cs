using NUnit.Framework;
using Moq;
using CustomerCommLib;

namespace CustomerCommLib.Tests
{
    public class Tests
    {
        [Test]
        public void SendMailToCustomer_WhenCalled_ShouldReturnTrue()
        {
            // Arrange
            var mockMailSender = new Mock<IMailSender>();
            mockMailSender.Setup(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>())).Returns(true);

            var customerComm = new CustomerComm(mockMailSender.Object);

            // Act
            bool result = customerComm.SendMailToCustomer();

            // Assert
            Assert.IsTrue(result);
            mockMailSender.Verify(x => x.SendMail(It.IsAny<string>(), It.IsAny<string>()), Times.Once);
        }
    }
}

