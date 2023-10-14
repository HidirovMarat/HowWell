namespace HowWellHeWillSpendEvening
{
    public class Student
    {
        private const double FullPizza  = 10;
        private const double FullSoda = 15;
        public string Name { get; private set; }
        public int Age { get ; private set ; }
        public Bag StudentBag { get; private set; }

        public Student(string name, int age, int capacity)
        {
            if (name == string.Empty)
                throw new Exception("Неправильное имя");
            Name = name;
            if (age < 0 && age > 150)
                throw new Exception("Неправильный возраст");
            Age = age;
            if (capacity < 0)
                throw new Exception("Отрицательное значение capacity");
            StudentBag = new Bag(capacity);
        }

        private double Ratio(int age)
        {
            int younStudent = 18;
            int middleStudent = 30;

            double younRatio = 1.2;
            double middleRatio = 1.5;
            double oldRatio = 2;

            if (age < younStudent)
                return younRatio;
            if (age < middleStudent)
                return middleRatio;
            return oldRatio;
        }

        public string CountSatiety(Student student)
        {
            double ratio = Ratio(student.Age);
            int pizzaPieces = student.StudentBag.PizzaPieces;

            if (pizzaPieces * ratio > FullPizza)
                return "переел";
            if (pizzaPieces * ratio < FullPizza)
                return "голоден";
            return "в самый раз";
        }

        public string CountCarbonation(Student student)
        {
            double ratio = Ratio(student.Age);
            int sodaBottles = student.StudentBag.SodaBottles;

            if (sodaBottles * ratio > FullSoda)
                return "перепил";
            if (sodaBottles * ratio < FullSoda)
                return "недопил";
            return "в самый раз";
        }
    }
}
