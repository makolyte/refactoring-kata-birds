using System.Collections.Generic;

namespace Birds
{
    public class Bird
    {
        private readonly BirdType birdType;

        public Bird(BirdType type)
        {
            birdType = type;
        }
        public List<BirdColor> GetColors()
        {
            switch (birdType)
            {
                case BirdType.Cardinal:
                    return new List<BirdColor>() { BirdColor.Black, BirdColor.Red };
                case BirdType.Goldfinch:
                    return new List<BirdColor>() { BirdColor.Black, BirdColor.Yellow, BirdColor.White };
                case BirdType.Chickadee:
                    return new List<BirdColor>() { BirdColor.Black, BirdColor.White, BirdColor.Tan };
            }
            throw new InvalidBirdTypeException();
        }
        public List<BirdFood> GetFoods()
        {
            switch (birdType)
            {
                case BirdType.Cardinal:
                    return new List<BirdFood>() { BirdFood.Insects, BirdFood.Seeds, BirdFood.Fruit};
                case BirdType.Goldfinch:
                    return new List<BirdFood>() { BirdFood.Insects, BirdFood.Seeds };
                case BirdType.Chickadee:
                    return new List<BirdFood>() { BirdFood.Insects, BirdFood.Fruit, BirdFood.Seeds };
            }
            throw new InvalidBirdTypeException();
        }
        public BirdSizeRange GetSizeRange()
        {
            switch (birdType)
            {
                case BirdType.Cardinal:
                    return new BirdSizeRange() { Lower=8, Upper=9 };
                case BirdType.Goldfinch:
                    return new BirdSizeRange() { Lower=4.5, Upper=5.5 };
                case BirdType.Chickadee:
                    return new BirdSizeRange() { Lower=4.75, Upper=5.75 };
            }
            throw new InvalidBirdTypeException();
        }

        
    }
}