namespace HowWellHeWillSpendEvening
{
    public class Bag
    {
        private const double pizzaPiecesEqualLiter = 0.3;
        private const double sodaBottlesEqualLiter = 0.5;

        public int PizzaPieces { get; set;}
        public int SodaBottles { get; set;}
        public double Capacity { get; set;}

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