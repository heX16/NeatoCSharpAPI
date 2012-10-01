namespace NeatoAPITest
{
    using Moq;
    using NeatoAPI;
    using NUnit.Framework;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    [TestFixture]
    public class NeatoTest
    {
        public Neato Robot;

        [SetUp]
        public void SetUp()
        {
            this.Robot = null;
        }
        
        [TearDown]
        public void TearDown()
        {
            this.Robot = null;
        }

        [Test]
        public void GetLDSScanTest()
        {
            this.Robot.Command.Test.TestMode(TestModeFlag.On);
            var response = this.Robot.Command.GetInfo.GetLDSScan();
        }
    }
}
