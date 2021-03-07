using System;

namespace ExceptionsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoubleStr("256");
            ToDoubleStr("pi");
            ToDoubleStr("1.23e456");
            Console.ReadKey();
        }

        static void ToDoubleStr(string str)
        {
            double num = 0;
            try
            {
                num = Convert.ToDouble(str);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FormatException caught: {0}", e);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("OverflowException caught: {0}", e);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("InvalidCastException caught: {0}", e);
            }
            finally
            {
                Console.WriteLine(num);
            }
        }
    }
}
