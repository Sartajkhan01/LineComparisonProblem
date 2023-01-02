namespace LineComparisonProblem
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Line Comparison Computation Program==========");
            LineComparison length = new LineComparison();
            length.CalculateLength(); //Call The Methods
            Console.ReadLine();
        }
    }
}