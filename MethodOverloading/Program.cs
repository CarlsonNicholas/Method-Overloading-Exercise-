namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            int partOne = Maths.Add(1, 2);
            decimal partTwo = Maths.Add(1.1m, 2.2m);
           string partThree =  Maths.Add(2, 3, true);

            Console.WriteLine(partOne);
            Console.WriteLine("");
            Console.WriteLine(partTwo);
            Console.WriteLine("");
            Console.WriteLine(partThree);

        }
    }
}
