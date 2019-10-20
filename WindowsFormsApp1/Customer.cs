namespace WindowsFormsApp1
{
    public class Customer
    {
        public int Identifier { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{Identifier}";
        }
    }
}