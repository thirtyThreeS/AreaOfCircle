// See https://aka.ms/new-console-template for more information


namespace AreaOfCircle
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double areaOfCircle = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle with radius of {radius} is {areaOfCircle}");
        }

        public static double AreaOfCircle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
