using System.Reflection;

namespace INVOKER.src
{
    internal class Invoker
    {
        public static event Action<object>? Log;

        public static dynamic Invoke(object? target, string? methodName, params object?[] args)
        {
            try
            {
                if(target is null)
                    throw new ArgumentNullException(nameof(target));

                if(methodName is null)
                    throw new AbandonedMutexException(nameof(methodName));

                Type type = target.GetType();
                MethodInfo method = type.GetMethod(methodName)!;

                if (method is null)
                    throw new Exception($"[{methodName}] Method not found");

                object result = method.Invoke(target, args)!;
                return result!;
            }
            catch (Exception exc)
            {
                Log?.Invoke($"Invoker exception: {exc.Message}!");
                return null!;
            }
        }
    }
}
