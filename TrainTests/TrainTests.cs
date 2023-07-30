using TrainAssignmentLibrary;

namespace TrainTests
{
    /// <summary>
    /// ������������ ����������� ���������� � ��������.
    /// </summary>
    [TestClass]
    public class TrainTests
    {
        /// <summary>
        /// ���� �� �������� ������ � �������� ����������� �������.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTrainCreation()
        {
            Train train1 = new Train(0);
            Train train2 = new Train(-1);
            Train train3 = new Train(-100000);
            Train train4 = new Train(-99999999);
        }

        /// <summary>
        /// ���� �� ���������/���������� ����� � �������.
        /// </summary>
        [TestMethod]
        public void TestToggleLight()
        {
            Train train = new Train(3);
            train.CurrentWagon.IsLightOn = false;
            train.ToggleLight();
            Assert.IsTrue(train.CurrentWagon.IsLightOn);
            train.ToggleLight();
            Assert.IsFalse(train.CurrentWagon.IsLightOn);
        }

        /// <summary>
        /// ���� �� ����������� ����������� �� �������.
        /// </summary>
        [TestMethod]
        public void TestMoveObserver()
        {
            Train train = new Train(4);
            Wagon firstWagon = train.CurrentWagon;
            train.MoveObserver();
            Assert.AreEqual(firstWagon.NextWagon, train.CurrentWagon);
            train.MoveObserver();
            Assert.AreEqual(firstWagon.NextWagon.NextWagon, train.CurrentWagon);
        }
    }
}