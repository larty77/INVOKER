using System.Reflection;

using INVOKER.src;

namespace INVOKER
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Class target = new Class();

            Invoker.Log += Console.WriteLine;

            Invoker.Invoke(target, "WriteTime");

            Invoker.Invoke(target, "WriteMsg", "Test!");

            Console.WriteLine(Invoker.Invoke(target, "Sum", 24, 144));
        }


    }

    internal class Class
    {

        private void WriteTime() => Console.WriteLine(DateTime.Now);

        public void WriteMsg(string msg) => Console.WriteLine(msg);

        private int Sum(int first, int second) { return first + second; }
    }
}