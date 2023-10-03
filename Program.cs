namespace Problema_1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numele: ");
            string name = Console.ReadLine();

            Console.Write("Introduceti varsta: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine($"{name} are drept de vot.");
            }
            else
            {
                Console.WriteLine($"{name} nu are drept de vot.");
            }
        }
    }
}
