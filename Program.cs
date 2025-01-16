namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            PrintName("Mark Snyder");
            PrintName("Snyder", "Mark");
            PrintName("Snyder", "Mark", "Edward", "Orelius", "Crysanthemum");
        }

        static void PrintName(string name)
        {
            Console.WriteLine("Name: {name}");
        }

        static void PrintName(string firstname, string lastname)
        {
            Console.WriteLine("Name: {lastname}, {firstname}");
        }

        static void PrintName(string firstname, string lastname, params string[] othernames)
        {
            Console.Write("Name: {lastname}, {firstname}");
            foreach (var name in othernames) { Console.Write(", {name}"); }
            Console.WriteLine();
        }

        static int SumOfProducts(params int[] values)
        {
            return 0;
        }
    }
}
