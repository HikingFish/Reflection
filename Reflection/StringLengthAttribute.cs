namespace Reflection
{
    public class StringLengthAttribute : Attribute
    {
        public int MaxLength {get;}
        public StringLengthAttribute(int maxLength)
        {
            MaxLength = maxLength;
        }
    }
}