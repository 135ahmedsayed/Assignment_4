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
    }
}
