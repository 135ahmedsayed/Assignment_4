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
    }
}
