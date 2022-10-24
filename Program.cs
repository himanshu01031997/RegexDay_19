namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter The first name:");
            string firstname=Console.ReadLine();
            bool value= p.ValidateNamecode(firstname);
            if (value)
            {
                Console.WriteLine("Name is Correct");
            }
            else
            {
                Console.WriteLine("Name is not Correct");
            }
            
        }
    }
}