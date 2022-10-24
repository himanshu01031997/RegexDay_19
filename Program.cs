namespace RegexDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pattern p = new Pattern();
            Console.WriteLine("Enter The MobileNo:");
            string MobileNo = Console.ReadLine();
            bool value= p.ValidateMobilecode(MobileNo);
            if (value)
            {
                Console.WriteLine("MobileNo is Correct");
            }
            else
            {
                Console.WriteLine("MobileNo is not Correct");
            }
            
        }
    }
}