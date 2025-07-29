using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace MockExample
{
    [TestFixture]
    internal class DetailsTest
    {
        [Test]
        public void TestShowStudent()
        {
            Mock<IDetails> mockDetails = new Mock<IDetails>();
            mockDetails.Setup(d => d.ShowStudent()).Returns("Hi I am Kusuma...");
            Assert.AreEqual("Hi I am Kusuma...", mockDetails.Object.ShowStudent());
        }

        [Test]
        public void TestShowCompany()
        {
            Mock<IDetails> obj = new Mock<IDetails>();
            obj.Setup(x => x.ShowCompany()).Returns("Its from Wipro Bangalore...");
            Assert.AreEqual("Its from Wipro Bangalore...", obj.Object.ShowCompany());
            //Details obj  = new Details();
            //Assert.AreEqual("Its from Wipro Chennai...",obj.ShowCompany());
        }
    }
}
