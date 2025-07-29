using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using Moq;

namespace MockRepeat
{
    [TestFixture]
    public class MockTest
    {
        [Test]
        public void TestMileStone1()
        {
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MilestoneExam1()).Returns("MileStone Exam 1 on Aug 1...");
            Assert.AreEqual("MileStone Exam 1 on Aug 1...", mock.Object.MilestoneExam1());
        }

        [Test]
        public void TestMileStone2()
        {
            Mock<IWiproData> mock = new Mock<IWiproData>();
            mock.Setup(x => x.MileStoneExam2()).Returns("MileStone Exam 2 On Aug 10...");
            Assert.AreEqual("MileStone Exam 2 On Aug 10...",mock.Object.MileStoneExam2());
        }
    }
}
