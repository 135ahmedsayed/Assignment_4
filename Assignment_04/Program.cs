namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //_______________________//
            #region Q1
            // Passing by Value Type:Any Changes made in Functions don't affect the orginal type
            int value = 5;
            Console.Write("Print by Passing by Value : ");
            PassByValue(value);
            Console.WriteLine(value);
            // Passing by Value Reference:Any Changes made in Functions do affect the orginal type
            Console.Write("Print by Passing by Value ref : ");
            PassByReference(ref value);
            Console.WriteLine(value);
            #endregion
            //_______________________//
            #region Q2
            // Passing by Reference Value Type:Any Changes made in Functions don't affect the orginal type
            int[] values = new int[] { 1, 2, 3, 4 };
            Console.Write("Print by Passing by Reference Value : ");
            Console.WriteLine(PassByReferenceValue(values));
            foreach (int i in values) Console.WriteLine(i);
            // Passing by Reference Value Type:Any Changes made in Functions do affect the orginal type
            Console.Write("Print by Passing by Reference ref : ");
            Console.WriteLine(PassByReferenceRef(ref values));
            foreach (int i in values) Console.WriteLine(i);
            Console.WriteLine("\n");
            #endregion
            //_______________________//
            #region Q3
            int RSum, RSub;
            SummationAndSubtration(3, 3, out RSum, out RSub);
            Console.WriteLine("The Summation is :" + RSum); //6 
            Console.WriteLine("The Subtration is :" + RSub); //0
            #endregion
            //_______________________//
            #region Q4
            Console.Write("Enter a number: ");
            string Numbers = Console.ReadLine()!;
            Console.WriteLine($"The sum of the digits of the number {Numbers} is: {SumDigits(Numbers)}");
            #endregion
            //_______________________//
            #region Q5
            Console.Write("Enter a number to check if it is prime: ");
            int num = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Is the number prime? " + IsPrime(num)); // Returns true if prime, false otherwise
            #endregion
            //_______________________//
            #region Q6
            int max = 0, min = 0;
            MinMaxArray(ref max, ref min);
            Console.WriteLine("The maximum value in the array is: " + max); // 800
            Console.WriteLine("The minimum value in the array is: " + min); // 2
            #endregion
            //_______________________//
            #region Q7
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine()!);
            long fact = Factorial(input);
            Console.WriteLine($"Factorial of {input} is: {fact}");
            #endregion
            Console.ReadKey();
        }
        //_________________//
        #region with Q1
        public static void PassByValue(int pass)
        {
            pass = 10; // This change will not affect the original variable
        }
        public static void PassByReference(ref int pass)
        {
            pass = 10; // This change will affect the original variable
        }
        #endregion
        //_________________//
        #region with Q2
        public static int PassByReferenceValue(int[] pass)
        {
            pass = new int[] { 0, 0, 0, 0 };
            int sum = pass[1] + pass[2]; // Execute done but the original array remains unchanged
            return sum;
        }
        public static int PassByReferenceRef(ref int[] pass)
        {
            pass = new int[] { 1, 1, 1, 1 };
            int sum = pass[1] + pass[2]; // Execute done and the original array changed
            return sum;
        }
        #endregion
        //_________________//
        #region with Q3
        public static void SummationAndSubtration(int num1, int num2, out int sum, out int sub)
        {
            sum = num1 + num2; // Calculate the sum
            sub = num1 - num2; // Calculate the subtraction
        }
        #endregion
        //_________________//
        #region with Q4
        public static int SumDigits(string Number)
        {
            int sum = 0;
            foreach (char c in Number)
                sum += int.Parse(c.ToString());
            return sum;
        }
        #endregion
        //_________________//
        #region with Q5
        public static bool IsPrime(int number)
        {
            bool P = false;
            if (number >= 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                        P = false;
                }
            }
            else
                P = false;
            return P;
        }
        #endregion
        //_________________//
        #region with Q6
        public static void MinMaxArray(ref int max, ref int min)
        {
            int[] values = { 21, 21, 22, 9, 99, 180, 2, 800 };
            for (int i = 0; i < values.Length; i++)
            {
                if (i != values.Length - 1)
                {
                    max = Math.Max(values[i], values[i + 1]);
                    min = Math.Min(values[i], values[i + 1]);
                }
            }
        }
        #endregion
        //_________________//
        #region with Q7
        public static long Factorial(int Number)
        {
            long factorial = 1; // Initialize factorial to 1
            if (Number > 0)
            {
                for (int i = 2; i <= Number; i++)
                {
                    factorial *= i; // Calculate factorial
                }
            }
            else
                Console.WriteLine("Number must be non-negative.");

            return factorial; // Return the calculated factorial
        }
        #endregion
    }
}
