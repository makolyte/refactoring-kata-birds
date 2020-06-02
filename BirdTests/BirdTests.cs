using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Birds.Tests
{
    [TestClass()]
    public class BirdTests
    {
        [DataRow(BirdType.Cardinal, new BirdColor[] { BirdColor.Red, BirdColor.Black })]
        [DataRow(BirdType.Goldfinch, new BirdColor[] { BirdColor.Yellow, BirdColor.Black, BirdColor.White})]
        [DataRow(BirdType.Chickadee, new BirdColor[] { BirdColor.Black, BirdColor.White, BirdColor.Tan})]
        [DataTestMethod]
        public void GetColorsTest(BirdType birdType, BirdColor[] expected)
        {
            //arrange
            var bird = new Bird(birdType);

            //act
            var actual = bird.GetColors();

            //assert
            CollectionAssert.AreEquivalent(expected, actual.ToArray());
        }
        [DataRow(BirdType.Cardinal, new BirdFood[] { BirdFood.Insects, BirdFood.Seeds, BirdFood.Fruit })]
        [DataRow(BirdType.Goldfinch, new BirdFood[] { BirdFood.Seeds, BirdFood.Insects })]
        [DataRow(BirdType.Chickadee, new BirdFood[] { BirdFood.Insects, BirdFood.Fruit, BirdFood.Seeds})]
        [DataTestMethod]
        public void GetFoodsTest(BirdType birdType, BirdColor[] expected)
        {
            //arrange
            var bird = new Bird(birdType);

            //act
            var actual = bird.GetFoods();

            //assert
            CollectionAssert.AreEquivalent(expected, actual.ToArray());
        }
        [DataRow(BirdType.Cardinal, 8.0, 9.0)]
        [DataRow(BirdType.Goldfinch, 4.5, 5.5)]
        [DataRow(BirdType.Chickadee, 4.75, 5.75)]
        [DataTestMethod]
        public void GetSizeRange(BirdType birdType, double expectedSizeRangeLower, double expectedSizeRangeUpper)
        {
            //arrange
            var bird = new Bird(birdType);

            //act
            var actual = bird.GetSizeRange();

            //assert
            Assert.AreEqual(expectedSizeRangeLower, actual.Lower);
            Assert.AreEqual(expectedSizeRangeUpper, actual.Upper);
        }
    }
}