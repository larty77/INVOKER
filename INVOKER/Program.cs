using System.Reflection;

using INVOKER.src;

namespace INVOKER
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Class target = new Class();

                Invoker.Invoke(target, "WriteTime");

                Invoker.Invoke<int>(target, "WriteType");

                Invoker.Invoke(target, "WriteMsg", "Test!");

                Console.WriteLine(Invoker.Invoke(target, "Sum", 24, 43));

                Console.WriteLine(Invoker.Invoke(target, "GetRandom"));

                Console.WriteLine(Invoker.Invoke(target, ""));
            }

            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

    }

    internal class Class
    {

        public void WriteTime() => Console.WriteLine(DateTime.Now);

        private static void WriteType<T>() => Console.WriteLine(typeof(T));

        public void WriteMsg(string msg) => Console.WriteLine(msg);

        private int Sum(int first, int second) => first + second; 

        private static int GetRandom() => new Random().Next(0, 100); 
    }
}