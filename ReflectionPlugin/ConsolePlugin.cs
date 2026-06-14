using Contracts;

namespace ReflectionPlugin
{
    public class ConsolePlugin : IPlugin
    {
        public void Execute()
        {
            Console.WriteLine("This is from a dll file");
        }
    }
}