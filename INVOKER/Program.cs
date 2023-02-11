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

            Invoker.Invoke(target, "WriteTime"); //DateTime.Now

            Invoker.Invoke(target, "WriteMsg", "Test!"); //Test!

            Console.WriteLine(Invoker.Invoke(target, "Sum", 24, 43)); //67
        }


    }

    internal class Class
    {

        public void WriteTime() => Console.WriteLine(DateTime.Now);

        public void WriteMsg(string msg) => Console.WriteLine(msg);

        public int Sum(int first, int second) { return first + second; }
    }
}