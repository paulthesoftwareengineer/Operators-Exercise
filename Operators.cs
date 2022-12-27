namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("a / b = {0} with a remainder of {1}", quotient, remainder);

            Console.WriteLine("Enter the radius of the circle: ");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine($"The area of the circle is: {area}");
        }

        public static double AreaOfCircle(double r)
        {
            const double pi = 3.14159;
            return pi * Math.Pow(r, 2);
        }
    }
}
