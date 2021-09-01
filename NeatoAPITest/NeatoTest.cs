namespace NeatoAPITest
{
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
            Robot = new Neato(new NeatoMockPort());
        }

        [TearDown]
        public void TearDown()
        {
            Robot = null;
        }

        [Test]
        public void BatteryChargeLevelTest()
        {
            Robot.RefreshInformation();
            var response = Robot.Command.GetInfo.GetTime();
        }
    }
}