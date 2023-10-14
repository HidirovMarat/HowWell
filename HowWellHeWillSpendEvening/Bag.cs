namespace HowWellHeWillSpendEvening
{
    public class Bag
    {
        private const double PizzaPiecesEqualLiter = 0.3;
        private const double SodaBottlesEqualLiter = 0.5;

        private int _pizzaPieces;
        private int _sodaBottles;
        private double _capacity;

        public int PizzaPieces 
        {
            get { return _pizzaPieces; }
            set { if (value < 0)
                    throw new Exception("Отрицательное значение pizzaPieces");
                    _pizzaPieces = value; 
                }
        }
        public int SodaBottles
        {
            get { return _sodaBottles; }
            set
            {
                if (value < 0)
                    throw new Exception("Отрицательное значение sodaBottles");
                _sodaBottles = value;
            }
        }
        public double Capacity
        {
            get { return _capacity; }
            set
            {
                if (value < 0)
                    throw new Exception("Отрицательное значение capacity");
                _capacity = value;
            }
        }

        public Bag(double capacity)
        {
            Capacity = capacity;
        }

        public bool AddPizza(int pizzaPieces, Bag bag)
        {
            double freeSpace = bag.Capacity - (PizzaPiecesToLiter(bag.PizzaPieces) + SodaBottlesToLiter(bag.SodaBottles));
            return freeSpace >= PizzaPiecesToLiter(pizzaPieces);
        }

        public bool AddBeer(int sodaBottles, Bag bag)
        {
            double freeSpace = bag.Capacity - (PizzaPiecesToLiter(bag.PizzaPieces) + SodaBottlesToLiter(bag.SodaBottles));
            return freeSpace >= PizzaPiecesToLiter(sodaBottles);
        }

        private double PizzaPiecesToLiter (int pizzaPieces) => pizzaPieces * PizzaPiecesEqualLiter;

        private double SodaBottlesToLiter(int sodaBottles) => sodaBottles * SodaBottlesEqualLiter;

    }
}