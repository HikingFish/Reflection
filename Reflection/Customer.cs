namespace Reflection
{
    public class Customer
    {
        [StringLength(10)]
        private string Username { get; set; }
        public Customer(string username)
        {
            Username = username;
        }
    }
}