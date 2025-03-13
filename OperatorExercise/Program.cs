namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
            
        }

        public static void PrintAreaofCircle()
        {
            Console.WriteLine("What is the raidus of your Circle");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"This area of a circle with a radius of {radius} is {Math.Round(AreaOfCircle(radius), 3)}");
        }

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int subtraction = a - b;
            int mult = a * b;
            
            int quotient = a / b;
            int remainder = a % b;

            //Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            
            //PrintAreaofCircle();
            
            int i = 3;
            int j = 4;
            int k = ++i * j++;

            Console.WriteLine(k); // What will this output?
            
            
        }
    }
}
