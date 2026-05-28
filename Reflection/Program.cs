using Reflection;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Reflection Practice/Example:");
            Console.WriteLine("1. Get Private Value and Change it");
            Console.WriteLine("2. Get Method and Variable");
            Console.WriteLine("Select an Option");

            string input = Console.ReadLine();

            if (!Enum.TryParse<Options>(input, out Options choice) || !Enum.IsDefined(typeof(Options), choice))
            {
                Console.WriteLine("Invalid Option");
                continue;
            }

            switch (choice)
            {
                case Options.GetPrivateValueAndChangeIt:
                    var annonymousField = typeof(SecretAgent).GetField("_codename", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                    var SecretAgentInstance = new SecretAgent();

                    object? currentValue = annonymousField.GetValue(SecretAgentInstance);
                    Console.WriteLine(currentValue);

                    annonymousField.SetValue(SecretAgentInstance, "008");
                    var newValue = annonymousField.GetValue(SecretAgentInstance);
                    Console.WriteLine(newValue);

                    break;

                case Options.GetMethodAndVariable:
                    Type type = typeof(Car);

                    Console.WriteLine("Property Info: ");
                    foreach(PropertyInfo prop in type.GetProperties())
                    {
                        Console.WriteLine($" -> {prop.PropertyType.Name} {prop.Name}");
                    }

                    Console.WriteLine(("Field Info: "));
                    foreach(FieldInfo info in type.GetFields())
                    {
                        Console.WriteLine($" -> {info.FieldType.Name} {info.Name}");
                    }

                    Console.WriteLine("Method Info: ");
                    foreach(MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance))
                    {
                        Console.WriteLine($" -> {method.ReturnType.Name} {method.Name}");
                    }

                    break;

                case Options.GetPrivateValueAndChangeItAndRunPrivateMethod:
                    break;
            }
        }
    }

    private enum Options
    {
        GetPrivateValueAndChangeIt = 1,
        GetMethodAndVariable = 2,
        GetPrivateValueAndChangeItAndRunPrivateMethod = 3
    }
}