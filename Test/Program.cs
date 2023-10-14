using HowWellHeWillSpendEvening;

namespace Test
{
   

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Marat", 20, 50);

            Console.WriteLine("Сколько кусков пиццы?");
            int countPizza = int.Parse(Console.ReadLine());
            if (!student.StudentBag.AddPizza(countPizza, student.StudentBag))
            {
                Console.WriteLine("Не влезает");
                return;
            }

            student.StudentBag.PizzaPieces += countPizza;
            Console.WriteLine("Сколько банок газировки?");
            int countSoda = int.Parse(Console.ReadLine());
            if (!student.StudentBag.AddPizza(countSoda, student.StudentBag))
            {
                Console.WriteLine("Не влезает");
                return;
            }

            student.StudentBag.SodaBottles += countSoda;
            string countSatiety = student.CountSatiety(student);
            string countDrunk = student.CountCarbonation(student);
            Console.WriteLine(
                $"    - Имя студента: {student.Name}\r\n" +
                $"    - Количество взятых кусков пиццы:{student.StudentBag.PizzaPieces}\r\n" +
                $"    - Количество бутылок пива:{student.StudentBag.SodaBottles}\r\n" +
                $"    - Степень сытости:{countSatiety}\r\n" +
                $"    - Степень алкогольного опьянения:{countDrunk}");
        }
    }
}

