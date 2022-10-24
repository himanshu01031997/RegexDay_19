namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enterr The Mobilepass:");
            string MobilePW = Console.ReadLine();
            bool value= p.ValidateMobilePass(MobilePW);
            if (value)
            {
                Console.WriteLine("Mobilepassword is Correct");
            }
            else
            {
                Console.WriteLine("Mobilepassword is not Correct");
            }
            
        }
    }
}