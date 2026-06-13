using System.Reflection;

namespace Reflection
{
    public static class ValidationEngine
    {
        public static bool Validate(object obj)
        {
            if (obj == null)
                return false;

            Type type = obj.GetType();

            foreach(PropertyInfo prop in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var attribute = prop.GetCustomAttribute<StringLengthAttribute>();

                if(attribute != null)
                {
                    string value = prop.GetValue(obj) as string;

                    if(value != null && value.Length > attribute.MaxLength)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}