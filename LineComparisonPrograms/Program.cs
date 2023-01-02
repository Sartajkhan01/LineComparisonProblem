namespace LineComparisonPrograms
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To Line Comparison Computation Program==========");
            LineLength length = new LineLength();
            length.CalculateLength(); //Call The Methods
            length.CheckEquality();
            Console.ReadLine();
        }
    }
}