using Classes;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var animal = new Cetaci("13-02-2024", 46, 145, "Cetaci", "Badajoz", "Pedro", 143, "Cetacinus Inventadus");
            //Act
            var result = animal.Tractament(1);
            //Assert
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var animal = new Cetaci("13-02-2024", 46, 145, "Cetaci", "Badajoz", "Pedro", 143, "Cetacinus Inventadus");
            //Act
            var result = animal.Tractament(2);
            //Assert
            Assert.AreEqual(44, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var animal = new AuMarina("28-01-2024", 37, 123, "Au Marina", "Teruel", "David", 16, "Pajarus Volante");
            //Act
            var result = animal.Tractament(1);
            //Assert
            Assert.AreEqual(-1337, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var animal = new TortugaMarina("13-02-2024", 67, 387, "Tortuga Marina", "Hospitalet de Llobregat", "Juan", 75, "Tortuga de chill");
            //Act
            var result = animal.Tractament(2);
            //Assert
            Assert.AreEqual(-8843, result);
        }
    }
}