namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter The Emailid:");
            string Emailid = Console.ReadLine();
            bool value= p.ValidateNamecode(Emailid);
            if (value)
            {
                Console.WriteLine("Emailid is Correct");
            }
            else
            {
                Console.WriteLine("Emailid is not Correct");
            }
            
        }
    }
}