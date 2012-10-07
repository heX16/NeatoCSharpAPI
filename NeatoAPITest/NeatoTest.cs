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
            this.Robot = new Neato(new NeatoMockPort());
        }
        
        [TearDown]
        public void TearDown()
        {
            this.Robot = null;
        }

        [Test]
        public void BatteryChargeLevelTest()
        {
            this.Robot.RefreshInformation();
            var response = this.Robot.Command.GetInfo.GetTime();
        }
    }
}
