namespace HowWellHeWillSpendEvening
{
    public class Bag
    {
        private const double pizzaPiecesEqualLiter = 0.3;
        private const double sodaBottlesEqualLiter = 0.5;
        private int pizzaPieces;
        private int sodaBottles;
        private double capacity;
        public int PizzaPieces 
        {
            get { return pizzaPieces; }
            set { if (value < 0)
                    throw new Exception("Отрицательное значение pizzaPieces");
                    pizzaPieces = value; 
                }
        }
        public int SodaBottles
        {
            get { return sodaBottles; }
            set
            {
                if (value < 0)
                    throw new Exception("Отрицательное значение sodaBottles");
                sodaBottles = value;
            }
        }
        public double Capacity
        {
            get { return capacity; }
            set
            {
                if (value < 0)
                    throw new Exception("Отрицательное значение capacity");
                capacity = value;
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

        private double PizzaPiecesToLiter (int pizzaPieces) => pizzaPieces * pizzaPiecesEqualLiter;

        private double SodaBottlesToLiter(int sodaBottles) => sodaBottles * sodaBottlesEqualLiter;

    }
}