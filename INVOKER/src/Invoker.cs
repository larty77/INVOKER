using System.Reflection;

namespace INVOKER.src
{
    internal class Invoker
    {
        public static dynamic Invoke(object target, string methodName, params object[] args) => target?.GetType()?.GetMethod(
                methodName,
                BindingFlags.Public | BindingFlags.NonPublic |
                BindingFlags.Static | BindingFlags.Instance)?.Invoke(target, args)!;
        

        public static dynamic Invoke<T>(object target, string methodName, params object[] args) => target?.GetType()?.GetMethod(
                methodName,
                BindingFlags.Public | BindingFlags.NonPublic | 
                BindingFlags.Static | BindingFlags.Instance)?.MakeGenericMethod(typeof(T))?.Invoke(target, args)!;   
    }
}
