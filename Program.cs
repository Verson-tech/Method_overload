namespace MethodOverloading
{
    internal class Method
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = 0;
            var response = "";

            if (isTrue)
            {
                sum = a + b;
                if (sum == 1)
                {
                    response = $"{sum} dollar";
                }
                else
                {
                    response = $"{sum} dollars";
                }

            }
            return response;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1,1,true));
            Console.WriteLine();
            Console.WriteLine(Add(1, 99, true));
            Console.WriteLine();
            Console.WriteLine(Add(1,0, true));
        }
    }
}