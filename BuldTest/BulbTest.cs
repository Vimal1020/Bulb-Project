//using BulbLibrary;
//using Xunit;

//namespace BuldTest
//{
//    public class BulbTest
//    {
//        [Theory]
//        [InlineData(1, new bool[] { true })]
//        [InlineData(10, new bool[] { true, false, false, true, false, false, false, true, false, false })]
//        // Add more test cases...
//        public void Simulate_ReturnsCorrectBulbStates(int numBulbs, bool[] expectedStates)
//        {
//            var simulator = new BulbService();
//            var bulbs = simulator.Simulate(numBulbs);

//            Assert.Equal(numBulbs, bulbs.Count);
//            for (int i = 0; i < numBulbs; i++)
//            {
//                Assert.Equal(expectedStates[i], bulbs[i].IsOn);
//            }
//        }
//    }
//}