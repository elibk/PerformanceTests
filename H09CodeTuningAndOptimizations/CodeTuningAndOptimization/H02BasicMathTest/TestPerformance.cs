using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace H02BasicMathTest
{
    class TestPerformance
    {
        private const int CountOfOperations = 1000;
        private static readonly Stopwatch recordTime = new Stopwatch();

        static void Main(string[] args)
        {
            object[]  param = new object[2];
            param[0] = 5;
            param[1] = 5;
            DisplayReportForPerformance("AddIntegers", param);
            Console.Clear();  // first time doesn't work correct. I've no idea why.

            param[0] = 5;
            param[1] = 5;
            DisplayReportForPerformance("AddIntegers", param);
            param[0] = 5L;
            param[1] = 5L;
            DisplayReportForPerformance("AddLongs", param);
            param[0] = 5f;
            param[1] = 5f;
            DisplayReportForPerformance("AddFloats", param);
            param[0] = 5.0;
            param[1] = 5.0;
            DisplayReportForPerformance("AddDoubles", param);
            param[0] = 5.0m;
            param[1] = 5.0m;
            DisplayReportForPerformance("AddDecimals", param);
            Console.WriteLine(new string('-', Console.WindowWidth));

            param[0] = 5;
            param[1] = 5;
            DisplayReportForPerformance("SubtractIntegers", param);
            param[0] = 5L;
            param[1] = 5L;
            DisplayReportForPerformance("SubtractLongs", param);
            param[0] = 5f;
            param[1] = 5f;
            DisplayReportForPerformance("SubtractFloats", param);
            param[0] = 5.0;
            param[1] = 5.0;
            DisplayReportForPerformance("SubtractDoubles", param);
            param[0] = 5.0m;
            param[1] = 5.0m;
            DisplayReportForPerformance("SubtractDecimals", param);

            Console.WriteLine(new string('-', Console.WindowWidth));

            param = new object[1];

            param[0] = 5;
           
            DisplayReportForPerformance("IncreaseInteger", param);
            param[0] = 5L;
           
            DisplayReportForPerformance("IncreaseLong", param);
            param[0] = 5f;
           
            DisplayReportForPerformance("IncreaseFloat", param);
            param[0] = 5.0;
           
            DisplayReportForPerformance("IncreaseDouble", param);
            param[0] = 5.0m;

            DisplayReportForPerformance("IncreaseDecimal", param);

            Console.WriteLine(new string('-', Console.WindowWidth));
            param = new object[2];
            param[0] = 5;
            param[1] = 5;

            DisplayReportForPerformance("MultiplyIntegers", param);
            param[0] = 5L;
            param[1] = 5L;
            DisplayReportForPerformance("MultiplyLongs", param);
            param[0] = 5f;
            param[1] = 5f;
            DisplayReportForPerformance("MultiplyFloats", param);
            param[0] = 5.0;
            param[1] = 5.0;
            DisplayReportForPerformance("MultiplyDoubles", param);
            param[0] = 5.0m;
            param[1] = 5.0m;
            DisplayReportForPerformance("MultiplyDecimals", param);

            Console.WriteLine(new string('-', Console.WindowWidth));

            param[0] = 5;
            param[1] = 5;
            DisplayReportForPerformance("DivideInteger", param);
            param[0] = 5L;
            param[1] = 5L;
            DisplayReportForPerformance("DivideLong", param);
            param[0] = 5f;
            param[1] = 5f;
            DisplayReportForPerformance("DivideFloat", param);
            param[0] = 5.0;
            param[1] = 5.0;
            DisplayReportForPerformance("DivideDouble", param);
            param[0] = 5.0m;
            param[1] = 5.0m;
            DisplayReportForPerformance("DivideDecimal", param);
        }

        private static void DisplayReportForPerformance(string methodName, object[] parameters)
        {
            recordTime.Reset();
            Type classType = typeof(TestPerformance);
            MethodInfo method = classType.GetMethod(methodName);
            if (method != null)
            {
                
                for (int i = 0; i < CountOfOperations; i++)
                {
                    
                    method.Invoke(null, parameters);
                    
                }
            }
            
            Console.WriteLine(methodName);
            Console.WriteLine("Performed {0} operations. Time elapsed in milliseconds {1}.", CountOfOperations, recordTime.Elapsed.TotalMilliseconds);
        }
    
        #region Addition
        public static void AddIntegers(int firstNumber, int secondNumber)
        {
            recordTime.Start();
            int sum = firstNumber + secondNumber;
            recordTime.Stop();
        }

        public static void AddLongs(long firstNumber, long secondNumber)
        {
            recordTime.Start();
            long sum = firstNumber + secondNumber;
            recordTime.Stop();
        }

        public static void AddFloats(float firstNumber, float secondNumber)
        {
            recordTime.Start();
            float sum = firstNumber + secondNumber;
            recordTime.Stop();
        }

        public static void AddDoubles(double firstNumber, double secondNumber)
        {
            recordTime.Start();
            double sum = firstNumber + secondNumber;
            recordTime.Stop();
        }

        public static void AddDecimals(decimal firstNumber, decimal secondNumber)
        {
            recordTime.Start();
            decimal sum = firstNumber + secondNumber;
            recordTime.Stop();
        }
        #endregion

        #region Subtraction
        public static void SubtractIntegers(int firstNumber, int secondNumber)
        {
            recordTime.Start();
            int sum = firstNumber - secondNumber;
            recordTime.Stop();
            
        }

        public static void SubtractLongs(long firstNumber, long secondNumber)
        {

            recordTime.Start();
            long sum = firstNumber - secondNumber;
            recordTime.Stop();
        }

        public static void SubtractFloats(float firstNumber, float secondNumber)
        {
            recordTime.Start();
            float sum = firstNumber - secondNumber;
            recordTime.Stop();
        }

        public static void SubtractDoubles(double firstNumber, double secondNumber)
        {
            recordTime.Start();
            double sum = firstNumber - secondNumber;
            recordTime.Stop();
        }

        public static void SubtractDecimals(decimal firstNumber, decimal secondNumber)
        {
            recordTime.Start();
            decimal sum = firstNumber - secondNumber;
            recordTime.Stop();
        }
        #endregion

        #region Increment
        public static void IncreaseInteger(int number)
        {
            recordTime.Start();
            number++;
            recordTime.Stop();
        }

        public static void IncreaseLong(long number)
        {
            recordTime.Start();
            number++;
            recordTime.Stop();
        }

        public static void IncreaseFloat(float number)
        {
            recordTime.Start();
            number++;
            recordTime.Stop();
        }

        public static void IncreaseDouble(double number)
        {
            recordTime.Start();
            number++;
            recordTime.Stop();
        }

        public static void IncreaseDecimal(decimal number)
        {
            recordTime.Start();
            number++;
            recordTime.Stop();
        }
        #endregion

        #region Multiplication
        public static void MultiplyIntegers(int firstNumber, int secondNumber)
        {
            int product;
            recordTime.Start();
            product = firstNumber * secondNumber;
            recordTime.Stop();
        }

        public static void MultiplyLongs(long firstNumber, long secondNumber)
        {
            long product;
            recordTime.Start();
            product = firstNumber * secondNumber;
            recordTime.Stop();
        }

        public static void MultiplyFloats(float firstNumber, float secondNumber)
        {
            float product;
            recordTime.Start();
            product = firstNumber * secondNumber;
            recordTime.Stop();
        }

        public static void MultiplyDoubles(double firstNumber, double secondNumber)
        {
            double product;
            recordTime.Start();
            product = firstNumber * secondNumber;
            recordTime.Stop();
        }

        public static void MultiplyDecimals(decimal firstNumber, decimal secondNumber)
        {
            decimal product;
            recordTime.Start();
            product = firstNumber * secondNumber;
            recordTime.Stop();
        }
        #endregion

        #region Division
        public static void DivideInteger(int number, int divider)
        {
            int product;
            recordTime.Start();
            product = number / divider;
            recordTime.Stop();
        }

        public static void DivideLong(long number, long divider)
        {
            long product;
            recordTime.Start();
            product = number / divider;
            recordTime.Stop();
        }

        public static void DivideFloat(float number, float divider)
        {
            float product;
            recordTime.Start();
            product = number / divider;
            recordTime.Stop();
        }

        public static void DivideDouble(double number, double divider)
        {
            double product;
            recordTime.Start();
            product = number / divider;
            recordTime.Stop();
        }

        public static void DivideDecimal(decimal number, decimal divider)
        {
            decimal product;
            recordTime.Start();
            product = number / divider;
            recordTime.Stop();
        }
        #endregion
    }
}
