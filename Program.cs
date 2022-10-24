namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter The Last name:");
            string Lastname=Console.ReadLine();
            bool value= p.ValidateNamecode(Lastname);
            if (value)
            {
                Console.WriteLine("LastName is Correct");
            }
            else
            {
                Console.WriteLine("LastName is not Correct");
            }
            
        }
    }
}